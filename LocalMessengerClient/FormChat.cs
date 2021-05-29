using System;
using System.Diagnostics;
using System.Drawing;
using System.Net;
using System.Net.Sockets;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using LocalMessengerClient.ServiceChat;
using NAudio.Wave;

namespace LocalMessengerClient
{
    public partial class FormChat : Form, IServiceChatCallback
    {
        #region Переменные
        bool isStart = false;
        bool isSpeak = false;
        ServiceChatClient client;
        readonly int ID;
        readonly string Login;
        readonly int Key_size = 2048;
        public static byte[] publicKey;
        private static byte[] privateKey;
        readonly System.Media.SoundPlayer Notification = new System.Media.SoundPlayer(Properties.Resources.Уведомление);
        WaveIn input;
        WaveOut output;
        BufferedWaveProvider bufferStream;
        private bool connected;
        Thread in_thread;
        Socket clientS;
        Socket listeningSocket;
        #endregion 

        #region Конструктор
        public FormChat(int id, string name)
        {
            InitializeComponent();
            ID = id;
            Login = name;
        }
        #endregion 

        #region События обработки клавиш
        private void TextBoxMsg_Enter(object sender, EventArgs e)
        {
            if (textBoxMsg.Text == "Сообщение")
            {
                textBoxMsg.Clear();
                textBoxMsg.ForeColor = Color.Black;
            }
        }

        private void TextBoxMsg_Leave(object sender, EventArgs e)
        {
            if (textBoxMsg.Text == String.Empty)
            {
                textBoxMsg.Text = "Сообщение";
                textBoxMsg.ForeColor = Color.Gray;
            }
        }

        private void TextBoxMsg_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && client != null && textBoxMsg.Text != String.Empty)
            {
				try
				{ 
                    client.SendMsg(Encrypt(Encoding.UTF8.GetBytes(textBoxMsg.Text)), ID);
                }
				catch (Exception)
				{
                    MessageBox.Show("Сервер не отвечает", "404", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Environment.Exit(0);
				}
                textBoxMsg.Clear();
            }
        }

        private void TextBoxMsg_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                textBoxMsg.Clear();
        }

        #endregion

        #region Обработка событий формы
        private void FormChat_Load(object sender, EventArgs e)
        {
            input = new WaveIn
            {
                WaveFormat = new WaveFormat(8000, 16, 1)
            };
            input.DataAvailable += Voice_Input;
            clientS = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            output = new WaveOut();
            bufferStream = new BufferedWaveProvider(new WaveFormat(8000, 16, 1));
            output.Init(bufferStream);
            listeningSocket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            in_thread = new Thread(new ThreadStart(Listening));
            connected = true;
            in_thread.Start();
            try
            {
                client = new ServiceChatClient(new System.ServiceModel.InstanceContext(this));
                isStart = true;
                client.Connect(ID, Login);
                Text = "Чат: " + Login;
                privateKey = client.GetPrivateKey();
                publicKey = client.GetPublicKey();
                foreach (byte[] encrypted in client.OldMessege())
                {
                    try
                    {
                        listBoxMsg.Items.Add(Encoding.UTF8.GetString(Decrypt(encrypted)));
                    }
                    catch (Exception){}
                }
                UpdateUsers(client.ListName());
                listBoxMsg.SelectedIndex = listBoxMsg.Items.Count - 1;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
                Close();
            }
        }

        private void FormChat_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(isStart)
				try
				{
                    client.Disconnect(ID);
                    if (input != null)
                    {
                        input.Dispose();
                        input = null;
                    }
                    listeningSocket.Close();
                    listeningSocket.Dispose();
                    if (output != null)
                    {
                        output.Stop();
                        output.Dispose();
                        output = null;
                    }
                    bufferStream = null;
                    Process.GetCurrentProcess().Kill();
                }
				catch (Exception){}
        }
        #endregion

        #region Ответы от сервера
        public void MsgCallback(byte[] encrypted)
        {
            Notification.Load();
            Notification.Play();
            try
            {
                listBoxMsg.Items.Add(Encoding.UTF8.GetString(Decrypt(encrypted)));
                listBoxMsg.SelectedIndex = listBoxMsg.Items.Count - 1;
            }
            catch (Exception){}
        }

		public void ListUsersOnline(string[] list)
		{
            UpdateUsers(list);
		}
        #endregion

        #region Обновление списка пользователей
        private void UpdateUsers(string[] list)
        {
            char c = '●';
            richTextBoxUsers.Clear();
            foreach (string item in list)
            {
                richTextBoxUsers.SelectionFont = new Font("Segoe Script", 7);
                richTextBoxUsers.SelectionColor = Color.Lime;                
                richTextBoxUsers.SelectedText += c.ToString();
                richTextBoxUsers.SelectionFont = new Font("Segoe Script", 14);
                richTextBoxUsers.SelectionColor = Color.Black;
                richTextBoxUsers.SelectedText += $" {item}{Environment.NewLine}";   
            }
        }

        #endregion

        #region Шифрование/Дешифрование
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
            catch (Exception){}
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
            catch (Exception){}
            return decrypted;
        }
        #endregion
        
        #region Часть передачи звука
        private void Button1_Click(object sender, EventArgs e)
		{
            if (isSpeak) input.StopRecording();
            else input.StartRecording();
            isSpeak = !isSpeak;
            button1.FlatAppearance.BorderColor = isSpeak ? Color.Blue : Color.Red;
        }

        private void Voice_Input(object sender, WaveInEventArgs e)
        {
            try
            {
                IPEndPoint remote_point = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 5555);
                clientS.SendTo(e.Buffer, remote_point);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Listening()
        {
            int port = 5555;
            while (port < 5570)
            {
				try
				{
                    listeningSocket.Bind(new IPEndPoint(IPAddress.Parse("127.0.0.1"), port));
                }
				catch (Exception)
                {
                    port++;
                }
            }
            output.Play();
            EndPoint remoteIp = new IPEndPoint(IPAddress.Any, 0);
            while (connected == true)
            {
                try
                {
                    byte[] data = new byte[65535];
                    int received = listeningSocket.ReceiveFrom(data, ref remoteIp);
                    bufferStream.AddSamples(data, 0, received);
                }
                catch (SocketException)
                { }
            }
        }
        #endregion
    }
}
