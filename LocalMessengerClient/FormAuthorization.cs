using System;
using System.Drawing;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using LocalMessengerClient.ServiceChat;

namespace LocalMessengerClient
{
    public partial class FormAuthorization : Form, IServiceChatCallback
    {
        #region Конструктор

        int Fail = 0;
        ServiceChatClient client;        
        public FormAuthorization()
        {
            InitializeComponent();
        }
        #endregion

        #region Ok
        readonly int Key_size = 2048;
        public static byte[] publicKey;
        private void ButtonOk_Click(object sender, EventArgs e)
        {
            string Login = textBoxLogin.Text, Password = textBoxPassword.Text;
            textBoxLogin.BackColor = Login == String.Empty || Login == "Логин" ? Color.LightPink : Color.White;
            textBoxPassword.BackColor = Password == String.Empty || Password == "Пароль" ? Color.LightPink : Color.White;
            if (Login != String.Empty && Login != "Логин" 
             && Password != String.Empty && Password != "Пароль")
            {
                int id = -1;
				try
				{
                    id = client.Authentication(Login, Encrypt(Encoding.UTF8.GetBytes(Password)));
                }
				catch (Exception ex)
				{
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Close();
				}
                
                if (id != -1)
                {
                    client.Close();
                    Hide();
                    FormChat formChat = new FormChat(id, Login);
                    formChat.ShowDialog();
                    Close();
                }
                else
                {
                    Fail++;
                    MessageBox.Show("Неверный логин и(или) пароль!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if (Fail > 2)
                    {
                        client.Close();
                        Close();
                    }
                }
            }
        }
        #endregion

        #region Обработка событий нажатий клавиш
        private void TextBoxLogin_Enter(object sender, EventArgs e)
        {
            if (textBoxLogin.Text == "Логин")
            {
                textBoxLogin.Clear();
                textBoxLogin.ForeColor = Color.Black;
            }
            textBoxLogin.BackColor = Color.White;
        }

        private void TextBoxLogin_Leave(object sender, EventArgs e)
        {
            if (textBoxLogin.Text == String.Empty)
            {
                textBoxLogin.Text = "Логин";
                textBoxLogin.ForeColor = Color.Gray;
            }
        }

        private void TextBoxPassword_Enter(object sender, EventArgs e)
        {
            if (textBoxPassword.Text == "Пароль")
            {
                textBoxPassword.Clear();
                textBoxPassword.ForeColor = Color.Black;
            }
            textBoxPassword.BackColor = Color.White;
            textBoxPassword.PasswordChar = '*';
        }

        private void TextBoxPassword_Leave(object sender, EventArgs e)
        {
            if (textBoxPassword.Text == String.Empty)
            {
                textBoxPassword.Text = "Пароль";
                textBoxPassword.ForeColor = Color.Gray;
                textBoxPassword.PasswordChar = '\0';
            }
        }

        private void TextBoxLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                textBoxPassword.Focus();
        }

        private void TextBoxPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter) ButtonOk_Click(null, null);
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9')) return;         
            if (e.KeyChar != 8) e.Handled = true;
        }

        public void MsgCallback(byte[] vs)
        {
            //Ничего не надо, спасибо
        }
        public void ListUsersOnline(string[] list)
        {
            //Ничего не надо, спасибо
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
            catch (Exception) { }
            return encrypted;
        }
        #endregion

        #region Открытие формы
        private void FormAuthorization_Load(object sender, EventArgs e)
		{
            try
            {
                client = new ServiceChatClient(new System.ServiceModel.InstanceContext(this));
                publicKey = client.GetPublicKey();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
        }
		#endregion
	}
}
