using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography;
using System.ServiceModel;
using System.Text;
using MySql.Data.MySqlClient;

namespace LocalMessengerServer
{
  
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class ServiceChat : IServiceChat
    {
        static ServiceChat()
        {
            GenerateKeys();
        }
        public static byte[] publicKey;
        private static byte[] privateKey;
        const int Key_size = 2048;
        readonly List<ServerUser> users = new List<ServerUser>();
        public static string stringBuilder = "server=127.0.0.1;Port=3306;Database=usersdb;Uid=root;Pwd=8725;";
        public int Authentication(string name, byte[] encryptedPassword)
        {
            //Расшифруем пароль
            string password = "";
            try
            {
                password = Encoding.UTF8.GetString(Decrypt(encryptedPassword));
            }
            catch (Exception) { return -1; }
            int id = -1;
            MySqlConnection connection = new MySqlConnection(stringBuilder);
            connection.Open();
            MySqlCommand command = new MySqlCommand($"SELECT Users.ID FROM Users WHERE Users.Login = '{name}' AND Users.Password = {password}", connection);
            MySqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                id = Convert.ToInt32(reader.GetValue(0));
            }
            var user = users.FirstOrDefault(i => i.ID == id);
            if (user != null)
                id = -1;
            reader.Dispose();
            reader.Close();
            command.Dispose();
            connection.Close();
            connection.Dispose();
            return id;
        }

        public byte[] GetPublicKey()
            => publicKey;

        public byte[] GetPrivateKey()
            => privateKey;

        public void Connect(int id, string name)
        {
            try
            {
                SendMsg(Encrypt(Encoding.UTF8.GetBytes(">" + name + ": подключился к чату!")), 0);
            }
            catch (ArgumentNullException){}
            users.Add(new ServerUser()
            {
                ID = id,
                Name = name,
                OperationContext = OperationContext.Current
            });
            List<string> list = ListName();
            foreach (var item in users)
            {
                if (item.ID != id)
                    item.OperationContext.GetCallbackChannel<IServerChatCallback>().ListUsersOnline(list);
            }
        }

        public void Disconnect(int id)
        {
            var user = users.FirstOrDefault(i => i.ID == id);
            if (user!=null)
            {
                users.Remove(user);
                try
                {
                    SendMsg(Encrypt(Encoding.UTF8.GetBytes(">" + user.Name + ": покинул чат!")), 0);
                }
                catch (ArgumentNullException){}
            }
            List<string> list = ListName();
            foreach (var item in users)
            {
                if (item.ID != id)
                    item.OperationContext.GetCallbackChannel<IServerChatCallback>().ListUsersOnline(list);
            }
        }

        public List<string> ListName()
        {
            return users.Select(i => i.Name).ToList();          
        }

		public List<byte[]> OldMessege()
		{
            List<byte[]> answer = new List<byte[]>();
            MySqlConnection connection = new MySqlConnection(stringBuilder);
            connection.Open();
            MySqlCommand command = new MySqlCommand($"SELECT messege.Time, messege.IDUsers, messege.Messege FROM usersdb.messege", connection);
            MySqlDataReader reader = command.ExecuteReader();
            try
			{
                string str;
                if (reader.HasRows)
                {
                    while (reader.Read() && answer.Count < 50)
                    {
                        str = reader.GetString(0) + ">" + Login(Convert.ToInt32(reader.GetString(1))) + ": "
                            + reader.GetString(2);
                        answer.Add(Encrypt(Encoding.UTF8.GetBytes(str)));
                    }
                }
            }
			catch (ArgumentNullException){}
            reader.Dispose();
            reader.Close();
            command.Dispose();
            connection.Close();
            connection.Dispose();
            return answer;
        }

        private string Login(int id)
        {
            string answer = "";
            MySqlConnection connection = new MySqlConnection(stringBuilder);
            connection.Open();
            MySqlCommand command = new MySqlCommand($"SELECT users.Login FROM usersdb.users WHERE users.ID = {id}", connection);
            MySqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                answer = reader.GetString(0);
            }
            reader.Dispose();
            reader.Close();
            command.Dispose();
            connection.Close();
            connection.Dispose();
            return answer;
        }

		public void SendMsg(byte[] encryptedData, int id)
        {
            //Расшифровываем полученное сообщение
            string msg = "";
            try
            {
                msg = Encoding.UTF8.GetString(Decrypt(encryptedData));
            }
            catch (Exception) { }
            string answer = DateTime.Now.ToShortTimeString();
            var user = users.FirstOrDefault(i => i.ID == id);
            if (user != null)
            {
                answer += ">" + user.Name + ": ";
                #region Запись в БД
                int maxID = MaxIDMessege();
                MySqlConnection connection = new MySqlConnection(stringBuilder);
                connection.Open();
                MySqlCommand command = new MySqlCommand($"INSERT INTO `usersdb`.`messege` (`ID`, `Messege`, `Time`, `IDUsers`) VALUES ('{maxID + 1}', '{msg}', '{DateTime.Now.ToShortTimeString()}', '{id}')", connection);
                try
                {
                    command.ExecuteNonQuery();
                    command.Dispose();
                }
                catch (Exception)
                {

                }
                connection.Close();
                connection.Dispose();
                #endregion
            }
            answer += msg;
            //Зашифровываем обратно
            try
            {
                foreach (var item in users)
                   item.OperationContext.GetCallbackChannel<IServerChatCallback>().MsgCallback(Encrypt(Encoding.UTF8.GetBytes(answer)));
            }
            catch (Exception){}
		}

		private int MaxIDMessege()
        {
            int max = 0;
            MySqlConnection connection = new MySqlConnection(stringBuilder);
            connection.Open();
            MySqlCommand command = new MySqlCommand("SELECT max(messege.ID) AS 'MAX' FROM usersdb.messege;", connection);
            MySqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                max = Convert.ToInt32(reader.GetValue(0));
            }
            reader.Dispose();
            reader.Close();
            command.Dispose();
            connection.Close();
            connection.Dispose();
            return max;
        }

		#region Функционал шифровальщика
		static void GenerateKeys()
        {
			try
			{
                using (var rsa = new RSACryptoServiceProvider(Key_size))
                {
                    rsa.PersistKeyInCsp = false;
                    publicKey = rsa.ExportCspBlob(false);
                    privateKey = rsa.ExportCspBlob(true);
                }
            }
			catch (Exception)
			{
			}
        }

        private byte[] Encrypt(byte[] input)
        {
            byte[] encrypted = null;
            try
			{
                using (var rsa = new RSACryptoServiceProvider(Key_size))
                {
                    rsa.PersistKeyInCsp = false;
                    rsa.ImportCspBlob(publicKey);
                    encrypted = rsa.Encrypt(input, true);
                }
            }
			catch (Exception)
			{

			}
            return encrypted;
        }

        private byte[] Decrypt(byte[] input)
        {
            byte[] decrypted = null;
			try
			{
                using (var rsa = new RSACryptoServiceProvider(Key_size))
                {
                    rsa.PersistKeyInCsp = false;
                    rsa.ImportCspBlob(privateKey);
                    decrypted = rsa.Decrypt(input, true);
                }
            }
			catch (Exception)
			{
			}
            return decrypted;
        }
		#endregion
	}
}
