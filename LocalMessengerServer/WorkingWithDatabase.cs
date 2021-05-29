using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace LocalMessengerServer
{
	class WorkingWithDatabase
    {
        readonly string stringBuilder = ServiceChat.stringBuilder;
        
        public WorkingWithDatabase() 
        {            
        }

        //Возврат всех пользователей
        public List<User> AllUsers()
        {
            List<User> users = new List<User>();
			try
			{
                MySqlConnection connection = new MySqlConnection(stringBuilder.ToString());
                connection.Open();
                MySqlCommand command = new MySqlCommand("SELECT Users.ID, Users.Login, Users.Password FROM Users ORDER BY Users.ID", connection);
                MySqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                    while (reader.Read())
                    {
                        if (reader.GetValue(1).ToString() != "admin")
                            users.Add(new User(Convert.ToInt32(reader.GetValue(0)), reader.GetValue(1).ToString(), Convert.ToInt32(reader.GetValue(2))));
                    }
                reader.Dispose();
                reader.Close();
                command.Dispose();
                connection.Close();
                connection.Dispose();
            }
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
            return users;
        }

        //Проверка на адимнистратора
        public bool Administration(int pass)
        {
            MySqlConnection connection = new MySqlConnection(stringBuilder.ToString());
            bool isAdmin = false;
            try
			{
                connection.Open();
                MySqlCommand command = new MySqlCommand($"SELECT Users.ID FROM Users WHERE Users.Login = 'admin' AND Users.Password = {pass}", connection);
                MySqlDataReader reader = command.ExecuteReader();
                isAdmin = reader.HasRows;
                reader.Dispose();
                reader.Close();
                command.Dispose();
                connection.Close();
                connection.Dispose();
            }
			catch (Exception ex)
			{
                MessageBox.Show(ex.Message);
                Environment.Exit(0);
            }
            return isAdmin;
        }

        //Добавление пользователя
        public string AddUser(int ID, string Login, int Password)
        {
            MySqlConnection connection = new MySqlConnection(stringBuilder.ToString());
            MySqlCommand command = new MySqlCommand($"INSERT INTO Users Values (@i, @l, @p)", connection);
			string answer;
			try
            {
                try
                {
                    connection.Open();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    Environment.Exit(0);
                }
                command.Parameters.Add(new MySqlParameter("@i", ID));
                command.Parameters.Add(new MySqlParameter("@l", Login));
                command.Parameters.Add(new MySqlParameter("@p", Password));            
                answer = command.ExecuteNonQuery().ToString();
            }
            catch (Exception ex)
            {
                answer = ex.Message;
            }
            command.Dispose();
            connection.Close();
            connection.Dispose();
            return answer;
        }

        //Изменение пользователя
        public string ChangeUser(User user)
        {
            MySqlConnection connection = new MySqlConnection(stringBuilder.ToString());
            MySqlCommand command = new MySqlCommand($"UPDATE Users SET Users.Login = '{user.Name}', Users.Password = {user.Password} WHERE Users.ID = @i", connection);
			string answer;
			try
            {
                try
                {
                    connection.Open();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    Environment.Exit(0);
                }
                command.Parameters.Add(new MySqlParameter("@i", user.ID));                
                answer = command.ExecuteNonQuery().ToString();
            }
            catch (Exception ex)
            {
                answer = ex.Message;
            }
            command.Dispose();
            connection.Close();
            connection.Dispose();
            return answer;
        }

        //Удаление пользователя
        public string DeleteUser(int ID)
        {
            MySqlConnection connection = new MySqlConnection(stringBuilder.ToString());
            MySqlCommand command = new MySqlCommand($"DELETE Users.ID FROM Users WHERE Users.ID = @i", connection);
			string answer;
			try
            {
                try
                {
                    connection.Open();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    Environment.Exit(0);
                }
                command.Parameters.Add(new MySqlParameter("@i", ID));
                answer = command.ExecuteNonQuery().ToString();
            }
            catch (Exception ex)
            {
                answer = ex.Message;
            }
            command.Dispose();
            connection.Close();
            connection.Dispose();
            return answer;
        }
    }

    //Класс пользователя
    class User
    {
        public User(int id, string name, int pass)
        {
            ID = id; Name = name; Password = pass;
        }
        public int ID { get; set; }

        public string Name { get; set; }

        public int Password { get; set; }
    }
}
