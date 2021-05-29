using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.ServiceModel;
using System.IO;

namespace LocalMessengerServer
{
    public partial class FormServer : Form
    {
        #region Переменные
        ServiceHost hostChat;
        List<User> users = new List<User>();
        WorkingWithDatabase withDatabase;
        bool admin = false;
        readonly int resize = 350;
        int maxID = 0;
        int iter = 0;
        #endregion

        #region Конструктор
        public FormServer()
        {
            InitializeComponent();
        }
        #endregion

        #region Загрузка формы
        private void FormServer_Load(object sender, EventArgs e)
        {
            #region Попытка запуска сервера
            try
            {
                hostChat = new ServiceHost(typeof(ServiceChat));
                hostChat.Open();
                labelChat.Text = "Обмен сообщениями - on";
                labelChat.ForeColor = Color.Green;
            }
            catch (Exception ex)
            {                
                if (MessageBox.Show(ex.Message, "Ошибка сервиса чата", MessageBoxButtons.OK, MessageBoxIcon.Error) != DialogResult.No)
                    Close();
            }
            #endregion 
        }
        #endregion

        #region Закрытие формы
        private void FormServer_FormClosing(object sender, FormClosingEventArgs e)
        {
            hostChat.Abort();                        
        }
        #endregion

        #region Открытие/Закрытие панели администратора
        private void ButtonAdmin_Click(object sender, EventArgs e)
        {
            withDatabase = new WorkingWithDatabase();
            if (admin)
            {
                admin = false;
                buttonAdmin.Text = "Открыть панель администратора";
                buttonAdmin.BackColor = Color.Blue;
                Size = new Size(Size.Width, Size.Height - resize);
                users.Clear();
            }
            else
            {
                Hide();
                FormPassworAdministrator form = new FormPassworAdministrator();
                form.ShowDialog();
                admin = form.DialogResult == DialogResult.Yes;
                Show();
                if (admin)
                {
                    buttonAdmin.Text = "Закрыть панель администратора";
                    buttonAdmin.BackColor = Color.DarkRed;
                    Size = new Size(Size.Width, Size.Height + resize);
                    users = withDatabase.AllUsers();
                    maxID = users.Max(i => i.ID);
                    if (users.Count >= 1)
                    {
                        labelBackID.Text = String.Empty;
                        labelNextID.Text = users.Count > 1 ? users[1].ID.ToString() : "";
                        buttonBackID.Enabled = false;
                        labelID.Text = users[0].ID.ToString();
                        buttonNextID.Enabled = users.Count > 1;
                        textBoxLogin.Text = users[0].Name;
                        textBoxPassword.Text = users[0].Password.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Пустая БД!", "Ошибка");
                        admin = false;
                        buttonAdmin.Text = "Открыть панель администратора";
                        buttonAdmin.BackColor = Color.Blue;
                        Size = new Size(Size.Width, Size.Height - resize);                    
                    }
                }
            }
            ReVisible(admin);
        }

        #endregion

        #region Инструменты адимнистратора

        #region Изменение видимости панели администратора
        private void ReVisible(bool what)
        {
            labelBackID.Visible = 
            labelNextID.Visible = 
            buttonBackID.Visible = 
            labelID.Visible = 
            buttonNextID.Visible = 
            labelLogin.Visible = 
            textBoxLogin.Visible = 
            labelPassword.Visible = 
            textBoxPassword.Visible = 
            pictureBoxPassword.Visible = 
            buttonChange.Visible = 
            buttonDelete.Visible = 
            pictureBoxSearch.Visible =
            textBoxSearch.Visible =
            buttonAdd.Visible = 
            what;
        }

        #endregion

        #region Показать/скрыть пароль
        private void PictureBox1_Click(object sender, EventArgs e)
        {
            if (textBoxPassword.PasswordChar == '*')
            {
                textBoxPassword.PasswordChar = '\0';
                pictureBoxPassword.BackgroundImage = Properties.Resources.ShowPassword;
            }
            else
            {
                textBoxPassword.PasswordChar = '*';
                pictureBoxPassword.BackgroundImage = Properties.Resources.HidePassword;
            }
        }
        #endregion

        #region Кнопки изменения текущего пользователя
        private void ButtonBackID_Click(object sender, EventArgs e)
        {
            iter--;
            if (iter == 0)
            {
                labelBackID.Text = String.Empty;
                buttonBackID.Enabled = false;
            }
            else
                labelBackID.Text = users[iter - 1].ID.ToString();
            if (iter == users.Count - 1)
            {
                labelNextID.Text = "+";
                buttonNextID.Enabled = true;
            }
            else
                labelNextID.Text = users[iter + 1].ID.ToString();
            labelID.Text = users[iter].ID.ToString();
            textBoxLogin.Text = users[iter].Name;
            textBoxPassword.Text = users[iter].Password.ToString();
            buttonDelete.Enabled = true;
            buttonChange.Text = "Изменить";
            buttonChange.Enabled = true;
        }

        private void ButtonNextID_Click(object sender, EventArgs e)
        {
            iter++;
            if (iter == users.Count)
            {
                buttonChange.Enabled = false;
                labelID.Text = "+";
                labelNextID.Text = String.Empty;
                buttonDelete.Enabled = false;
                textBoxLogin.Clear();
                textBoxPassword.Clear();
                textBoxLogin.Focus();
                buttonNextID.Enabled = false;
                labelBackID.Text = users[iter - 1].ID.ToString();
            }
            else
            {
                if(iter == users.Count - 1)
                    labelNextID.Text = "+";
                else
                    labelNextID.Text = users[iter + 1].ID.ToString();
                labelBackID.Text = users[iter - 1].ID.ToString();
                labelID.Text = users[iter].ID.ToString();
                textBoxLogin.Text = users[iter].Name;
                textBoxPassword.Text = users[iter].Password.ToString();
            }
            buttonBackID.Enabled = true;
        }
        #endregion

        #region Кнопки редактирования БД
        private void ButtonChange_Click(object sender, EventArgs e)
        {
            if (textBoxLogin.Text != String.Empty && textBoxPassword.Text != String.Empty)
            {
                User newUser = new User(users[iter].ID, textBoxLogin.Text, Convert.ToInt32(textBoxPassword.Text));
                if (users[iter].Name == newUser.Name && users[iter].Password == newUser.Password)
                    MessageBox.Show("Измени что-нибудь", "Ошибка!");
                else
                {
                    string txt = withDatabase.ChangeUser(newUser);
                    if (txt == "1")
                    {
                        MessageBox.Show($"Пользователь {newUser.Name} изменил свои данные", "Успех");
                        users[iter] = newUser;
                    }
                    else
                        MessageBox.Show(txt, "Ошибка!");
                    textBoxLogin.Text = users[iter].Name;
                    textBoxPassword.Text = users[iter].Password.ToString();
                }                
            }
            else
            {
                textBoxLogin.BackColor = textBoxLogin.Text == String.Empty ? Color.LightPink : Color.White;
                textBoxPassword.BackColor = textBoxPassword.Text == String.Empty ? Color.LightPink : Color.White;
            }
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Удалить пользователя {textBoxLogin.Text}?", "Подтверждение", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
                == DialogResult.Yes)
            {
                string txt = withDatabase.DeleteUser(Convert.ToInt32(labelID.Text));
                if (txt == "1")
                {
                    users.RemoveAt(iter);
                    iter = iter == 0 ? 1 : iter;
                    ButtonBackID_Click(null, null);
                }
                else
                    MessageBox.Show(txt, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
               

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            if (labelID.Text == "+")
            {
                if (textBoxLogin.Text != String.Empty && textBoxPassword.Text != String.Empty)
                {
                    string txt = withDatabase.AddUser(++maxID, textBoxLogin.Text, Convert.ToInt32(textBoxPassword.Text));
                    if (txt == "1")
                    {
                        MessageBox.Show($"Пользователь {textBoxLogin.Text} добавлен!", "Успех");
                        users.Clear();
                        users = withDatabase.AllUsers();
                        maxID = users.Max(i => i.ID);
                        iter = users.Count;
                        ButtonBackID_Click(null, null);
                    }
                    else
                    {
                        MessageBox.Show(txt, "Ошибка!");
                    }    
                }
                else
                {
                    textBoxLogin.BackColor = textBoxLogin.Text == String.Empty ? Color.LightPink : Color.White;
                    textBoxPassword.BackColor = textBoxPassword.Text == String.Empty ? Color.LightPink : Color.White;
                }

            }
            else
            {
                iter = users.Count - 1;
                ButtonNextID_Click(null, null);
            }
        }
        #endregion

        #region Поиск пользователя
        private void PictureBoxSearch_Click(object sender, EventArgs e)
        {
            List<User> Search = users.Where(i => i.Name.Contains(textBoxSearch.Text)).OrderBy(i => i.ID).ToList<User>();
            if (textBoxSearch.Text != String.Empty && Search.Count() > 0)
            {
                users.Clear();
                foreach (var item in Search)
                {
                    users.Add(new User(item.ID, item.Name, item.Password));
                }
            }
            else
            {
                if (Search.Count() == 0 && textBoxSearch.Text != "Поиск") 
                    textBoxSearch.BackColor = Color.LightPink;
                withDatabase = new WorkingWithDatabase();
                users = withDatabase.AllUsers();
                buttonNextID.Enabled = true;
            }
            iter = 1;
            ButtonBackID_Click(null, null);
        }
        
        private void TextBoxSearch_Enter(object sender, EventArgs e)
        {
            if (textBoxSearch.Text == "Поиск")
                textBoxSearch.Clear();
            textBoxSearch.BackColor = Color.White;
        }
                
        private void TextBoxSearch_Leave(object sender, EventArgs e)
        {
            if (textBoxSearch.Text == String.Empty)
                textBoxSearch.Text = "Поиск";
        }
                
        private void TextBoxSearch_TextChanged(object sender, EventArgs e)
        {
            textBoxSearch.BackColor = Color.White;
            PictureBoxSearch_Click(null, null);
        }

        #endregion

        #region Ввод логина и пароля пользователя
        private void TextBoxPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9')) return;
            if (e.KeyChar != 8) e.Handled = true;
        }

        private void TextBoxPassword_Enter(object sender, EventArgs e)
        {
            textBoxPassword.BackColor = Color.White;
        }

        private void TextBoxLogin_Enter(object sender, EventArgs e)
        {
            textBoxLogin.BackColor = Color.White;
        }

        #endregion

        #endregion
    }
}