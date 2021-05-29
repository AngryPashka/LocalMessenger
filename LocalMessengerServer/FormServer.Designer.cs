namespace LocalMessengerServer
{
    partial class FormServer
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormServer));
			this.labelChat = new System.Windows.Forms.Label();
			this.buttonAdmin = new System.Windows.Forms.Button();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.panelAdmin = new System.Windows.Forms.Panel();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
			this.buttonAdd = new System.Windows.Forms.Button();
			this.buttonDelete = new System.Windows.Forms.Button();
			this.buttonChange = new System.Windows.Forms.Button();
			this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
			this.textBoxPassword = new System.Windows.Forms.TextBox();
			this.pictureBoxPassword = new System.Windows.Forms.PictureBox();
			this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
			this.labelPassword = new System.Windows.Forms.Label();
			this.textBoxLogin = new System.Windows.Forms.TextBox();
			this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
			this.labelLogin = new System.Windows.Forms.Label();
			this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
			this.labelID = new System.Windows.Forms.Label();
			this.buttonBackID = new System.Windows.Forms.Button();
			this.buttonNextID = new System.Windows.Forms.Button();
			this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
			this.labelNextID = new System.Windows.Forms.Label();
			this.labelBackID = new System.Windows.Forms.Label();
			this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
			this.textBoxSearch = new System.Windows.Forms.TextBox();
			this.pictureBoxSearch = new System.Windows.Forms.PictureBox();
			this.tableLayoutPanel1.SuspendLayout();
			this.panelAdmin.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			this.tableLayoutPanel9.SuspendLayout();
			this.tableLayoutPanel6.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxPassword)).BeginInit();
			this.tableLayoutPanel7.SuspendLayout();
			this.tableLayoutPanel5.SuspendLayout();
			this.tableLayoutPanel4.SuspendLayout();
			this.tableLayoutPanel3.SuspendLayout();
			this.tableLayoutPanel8.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxSearch)).BeginInit();
			this.SuspendLayout();
			// 
			// labelChat
			// 
			this.labelChat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.labelChat.AutoSize = true;
			this.labelChat.Font = new System.Drawing.Font("Courier New", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelChat.Location = new System.Drawing.Point(4, 12);
			this.labelChat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.labelChat.Name = "labelChat";
			this.labelChat.Size = new System.Drawing.Size(640, 37);
			this.labelChat.TabIndex = 0;
			this.labelChat.Text = "Обмен сообщениями - off";
			this.labelChat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// buttonAdmin
			// 
			this.buttonAdmin.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.buttonAdmin.BackColor = System.Drawing.Color.Blue;
			this.buttonAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
			this.buttonAdmin.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.buttonAdmin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.buttonAdmin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.buttonAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonAdmin.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonAdmin.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.buttonAdmin.Location = new System.Drawing.Point(156, 69);
			this.buttonAdmin.Margin = new System.Windows.Forms.Padding(4);
			this.buttonAdmin.Name = "buttonAdmin";
			this.buttonAdmin.Size = new System.Drawing.Size(336, 48);
			this.buttonAdmin.TabIndex = 1;
			this.buttonAdmin.Text = "Открыть панель администратора";
			this.buttonAdmin.UseVisualStyleBackColor = false;
			this.buttonAdmin.Click += new System.EventHandler(this.ButtonAdmin_Click);
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 1;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Controls.Add(this.buttonAdmin, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.labelChat, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.panelAdmin, 0, 2);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 3;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(648, 127);
			this.tableLayoutPanel1.TabIndex = 2;
			// 
			// panelAdmin
			// 
			this.panelAdmin.Controls.Add(this.tableLayoutPanel2);
			this.panelAdmin.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelAdmin.Location = new System.Drawing.Point(4, 128);
			this.panelAdmin.Margin = new System.Windows.Forms.Padding(4);
			this.panelAdmin.Name = "panelAdmin";
			this.panelAdmin.Size = new System.Drawing.Size(640, 1);
			this.panelAdmin.TabIndex = 2;
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.ColumnCount = 1;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel9, 0, 7);
			this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel6, 0, 6);
			this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel7, 0, 5);
			this.tableLayoutPanel2.Controls.Add(this.textBoxLogin, 0, 4);
			this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel5, 0, 3);
			this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 0, 2);
			this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 1);
			this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel8, 0, 0);
			this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 8;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.88802F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.728879F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.98134F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.728879F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.98134F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.728879F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.98134F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.98134F));
			this.tableLayoutPanel2.Size = new System.Drawing.Size(640, 1);
			this.tableLayoutPanel2.TabIndex = 0;
			// 
			// tableLayoutPanel9
			// 
			this.tableLayoutPanel9.ColumnCount = 3;
			this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel9.Controls.Add(this.buttonAdd, 0, 0);
			this.tableLayoutPanel9.Controls.Add(this.buttonDelete, 2, 0);
			this.tableLayoutPanel9.Controls.Add(this.buttonChange, 1, 0);
			this.tableLayoutPanel9.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel9.Location = new System.Drawing.Point(4, 4);
			this.tableLayoutPanel9.Margin = new System.Windows.Forms.Padding(4);
			this.tableLayoutPanel9.Name = "tableLayoutPanel9";
			this.tableLayoutPanel9.RowCount = 1;
			this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel9.Size = new System.Drawing.Size(632, 1);
			this.tableLayoutPanel9.TabIndex = 9;
			// 
			// buttonAdd
			// 
			this.buttonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.buttonAdd.Dock = System.Windows.Forms.DockStyle.Fill;
			this.buttonAdd.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
			this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonAdd.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonAdd.Location = new System.Drawing.Point(4, 4);
			this.buttonAdd.Margin = new System.Windows.Forms.Padding(4);
			this.buttonAdd.Name = "buttonAdd";
			this.buttonAdd.Size = new System.Drawing.Size(202, 1);
			this.buttonAdd.TabIndex = 5;
			this.buttonAdd.Text = "Добавить";
			this.buttonAdd.UseVisualStyleBackColor = false;
			this.buttonAdd.Visible = false;
			this.buttonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
			// 
			// buttonDelete
			// 
			this.buttonDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.buttonDelete.Dock = System.Windows.Forms.DockStyle.Fill;
			this.buttonDelete.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
			this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonDelete.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonDelete.Location = new System.Drawing.Point(424, 4);
			this.buttonDelete.Margin = new System.Windows.Forms.Padding(4);
			this.buttonDelete.Name = "buttonDelete";
			this.buttonDelete.Size = new System.Drawing.Size(204, 1);
			this.buttonDelete.TabIndex = 7;
			this.buttonDelete.Text = "Удалить";
			this.buttonDelete.UseVisualStyleBackColor = false;
			this.buttonDelete.Visible = false;
			this.buttonDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
			// 
			// buttonChange
			// 
			this.buttonChange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.buttonChange.Dock = System.Windows.Forms.DockStyle.Fill;
			this.buttonChange.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
			this.buttonChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonChange.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonChange.Location = new System.Drawing.Point(214, 4);
			this.buttonChange.Margin = new System.Windows.Forms.Padding(4);
			this.buttonChange.Name = "buttonChange";
			this.buttonChange.Size = new System.Drawing.Size(202, 1);
			this.buttonChange.TabIndex = 6;
			this.buttonChange.Text = "Измененить";
			this.buttonChange.UseVisualStyleBackColor = false;
			this.buttonChange.Visible = false;
			this.buttonChange.Click += new System.EventHandler(this.ButtonChange_Click);
			// 
			// tableLayoutPanel6
			// 
			this.tableLayoutPanel6.ColumnCount = 2;
			this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85F));
			this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
			this.tableLayoutPanel6.Controls.Add(this.textBoxPassword, 0, 0);
			this.tableLayoutPanel6.Controls.Add(this.pictureBoxPassword, 1, 0);
			this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel6.Location = new System.Drawing.Point(4, 4);
			this.tableLayoutPanel6.Margin = new System.Windows.Forms.Padding(4);
			this.tableLayoutPanel6.Name = "tableLayoutPanel6";
			this.tableLayoutPanel6.RowCount = 1;
			this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel6.Size = new System.Drawing.Size(632, 1);
			this.tableLayoutPanel6.TabIndex = 8;
			// 
			// textBoxPassword
			// 
			this.textBoxPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.textBoxPassword.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxPassword.Location = new System.Drawing.Point(4, 4);
			this.textBoxPassword.Margin = new System.Windows.Forms.Padding(4);
			this.textBoxPassword.Name = "textBoxPassword";
			this.textBoxPassword.PasswordChar = '*';
			this.textBoxPassword.Size = new System.Drawing.Size(529, 34);
			this.textBoxPassword.TabIndex = 4;
			this.textBoxPassword.Visible = false;
			this.textBoxPassword.Enter += new System.EventHandler(this.TextBoxPassword_Enter);
			this.textBoxPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxPassword_KeyPress);
			// 
			// pictureBoxPassword
			// 
			this.pictureBoxPassword.BackgroundImage = global::LocalMessengerServer.Properties.Resources.HidePassword;
			this.pictureBoxPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.pictureBoxPassword.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pictureBoxPassword.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pictureBoxPassword.Location = new System.Drawing.Point(541, 4);
			this.pictureBoxPassword.Margin = new System.Windows.Forms.Padding(4);
			this.pictureBoxPassword.Name = "pictureBoxPassword";
			this.pictureBoxPassword.Size = new System.Drawing.Size(87, 1);
			this.pictureBoxPassword.TabIndex = 9;
			this.pictureBoxPassword.TabStop = false;
			this.pictureBoxPassword.Visible = false;
			this.pictureBoxPassword.Click += new System.EventHandler(this.PictureBox1_Click);
			// 
			// tableLayoutPanel7
			// 
			this.tableLayoutPanel7.ColumnCount = 3;
			this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel7.Controls.Add(this.labelPassword, 0, 0);
			this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel7.Location = new System.Drawing.Point(4, 4);
			this.tableLayoutPanel7.Margin = new System.Windows.Forms.Padding(4);
			this.tableLayoutPanel7.Name = "tableLayoutPanel7";
			this.tableLayoutPanel7.RowCount = 1;
			this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel7.Size = new System.Drawing.Size(632, 1);
			this.tableLayoutPanel7.TabIndex = 4;
			// 
			// labelPassword
			// 
			this.labelPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.labelPassword.AutoSize = true;
			this.labelPassword.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelPassword.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.labelPassword.Location = new System.Drawing.Point(4, 0);
			this.labelPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.labelPassword.Name = "labelPassword";
			this.labelPassword.Size = new System.Drawing.Size(202, 1);
			this.labelPassword.TabIndex = 1;
			this.labelPassword.Text = "Пароль";
			this.labelPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.labelPassword.Visible = false;
			// 
			// textBoxLogin
			// 
			this.textBoxLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.textBoxLogin.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxLogin.Location = new System.Drawing.Point(4, 4);
			this.textBoxLogin.Margin = new System.Windows.Forms.Padding(4);
			this.textBoxLogin.Name = "textBoxLogin";
			this.textBoxLogin.Size = new System.Drawing.Size(632, 34);
			this.textBoxLogin.TabIndex = 3;
			this.textBoxLogin.Visible = false;
			this.textBoxLogin.Enter += new System.EventHandler(this.TextBoxLogin_Enter);
			// 
			// tableLayoutPanel5
			// 
			this.tableLayoutPanel5.ColumnCount = 3;
			this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel5.Controls.Add(this.labelLogin, 0, 0);
			this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel5.Location = new System.Drawing.Point(4, 4);
			this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(4);
			this.tableLayoutPanel5.Name = "tableLayoutPanel5";
			this.tableLayoutPanel5.RowCount = 1;
			this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel5.Size = new System.Drawing.Size(632, 1);
			this.tableLayoutPanel5.TabIndex = 2;
			// 
			// labelLogin
			// 
			this.labelLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.labelLogin.AutoSize = true;
			this.labelLogin.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelLogin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.labelLogin.Location = new System.Drawing.Point(4, 0);
			this.labelLogin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.labelLogin.Name = "labelLogin";
			this.labelLogin.Size = new System.Drawing.Size(202, 1);
			this.labelLogin.TabIndex = 1;
			this.labelLogin.Text = "Логин";
			this.labelLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.labelLogin.Visible = false;
			// 
			// tableLayoutPanel4
			// 
			this.tableLayoutPanel4.ColumnCount = 3;
			this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel4.Controls.Add(this.labelID, 1, 0);
			this.tableLayoutPanel4.Controls.Add(this.buttonBackID, 0, 0);
			this.tableLayoutPanel4.Controls.Add(this.buttonNextID, 2, 0);
			this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel4.Location = new System.Drawing.Point(4, 4);
			this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(4);
			this.tableLayoutPanel4.Name = "tableLayoutPanel4";
			this.tableLayoutPanel4.RowCount = 1;
			this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel4.Size = new System.Drawing.Size(632, 1);
			this.tableLayoutPanel4.TabIndex = 1;
			// 
			// labelID
			// 
			this.labelID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.labelID.AutoSize = true;
			this.labelID.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.labelID.Location = new System.Drawing.Point(214, 0);
			this.labelID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.labelID.Name = "labelID";
			this.labelID.Size = new System.Drawing.Size(202, 1);
			this.labelID.TabIndex = 0;
			this.labelID.Text = "ID";
			this.labelID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.labelID.Visible = false;
			// 
			// buttonBackID
			// 
			this.buttonBackID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.buttonBackID.Dock = System.Windows.Forms.DockStyle.Fill;
			this.buttonBackID.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
			this.buttonBackID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonBackID.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonBackID.Location = new System.Drawing.Point(4, 4);
			this.buttonBackID.Margin = new System.Windows.Forms.Padding(4);
			this.buttonBackID.Name = "buttonBackID";
			this.buttonBackID.Size = new System.Drawing.Size(202, 1);
			this.buttonBackID.TabIndex = 1;
			this.buttonBackID.TabStop = false;
			this.buttonBackID.Text = "<<";
			this.buttonBackID.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.buttonBackID.UseVisualStyleBackColor = false;
			this.buttonBackID.Visible = false;
			this.buttonBackID.Click += new System.EventHandler(this.ButtonBackID_Click);
			// 
			// buttonNextID
			// 
			this.buttonNextID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.buttonNextID.Dock = System.Windows.Forms.DockStyle.Fill;
			this.buttonNextID.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
			this.buttonNextID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonNextID.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonNextID.Location = new System.Drawing.Point(424, 4);
			this.buttonNextID.Margin = new System.Windows.Forms.Padding(4);
			this.buttonNextID.Name = "buttonNextID";
			this.buttonNextID.Size = new System.Drawing.Size(204, 1);
			this.buttonNextID.TabIndex = 2;
			this.buttonNextID.TabStop = false;
			this.buttonNextID.Text = ">>";
			this.buttonNextID.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.buttonNextID.UseVisualStyleBackColor = false;
			this.buttonNextID.Visible = false;
			this.buttonNextID.Click += new System.EventHandler(this.ButtonNextID_Click);
			// 
			// tableLayoutPanel3
			// 
			this.tableLayoutPanel3.ColumnCount = 3;
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel3.Controls.Add(this.labelNextID, 2, 0);
			this.tableLayoutPanel3.Controls.Add(this.labelBackID, 0, 0);
			this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel3.Location = new System.Drawing.Point(4, 4);
			this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(4);
			this.tableLayoutPanel3.Name = "tableLayoutPanel3";
			this.tableLayoutPanel3.RowCount = 1;
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel3.Size = new System.Drawing.Size(632, 1);
			this.tableLayoutPanel3.TabIndex = 0;
			// 
			// labelNextID
			// 
			this.labelNextID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.labelNextID.AutoSize = true;
			this.labelNextID.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelNextID.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
			this.labelNextID.Location = new System.Drawing.Point(424, 0);
			this.labelNextID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.labelNextID.Name = "labelNextID";
			this.labelNextID.Size = new System.Drawing.Size(204, 1);
			this.labelNextID.TabIndex = 2;
			this.labelNextID.Text = "nextID";
			this.labelNextID.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.labelNextID.Visible = false;
			// 
			// labelBackID
			// 
			this.labelBackID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.labelBackID.AutoSize = true;
			this.labelBackID.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelBackID.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
			this.labelBackID.Location = new System.Drawing.Point(4, 0);
			this.labelBackID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.labelBackID.Name = "labelBackID";
			this.labelBackID.Size = new System.Drawing.Size(202, 1);
			this.labelBackID.TabIndex = 0;
			this.labelBackID.Text = "backID";
			this.labelBackID.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.labelBackID.Visible = false;
			// 
			// tableLayoutPanel8
			// 
			this.tableLayoutPanel8.ColumnCount = 2;
			this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85F));
			this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
			this.tableLayoutPanel8.Controls.Add(this.textBoxSearch, 0, 0);
			this.tableLayoutPanel8.Controls.Add(this.pictureBoxSearch, 1, 0);
			this.tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel8.Location = new System.Drawing.Point(4, 4);
			this.tableLayoutPanel8.Margin = new System.Windows.Forms.Padding(4);
			this.tableLayoutPanel8.Name = "tableLayoutPanel8";
			this.tableLayoutPanel8.RowCount = 1;
			this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel8.Size = new System.Drawing.Size(632, 1);
			this.tableLayoutPanel8.TabIndex = 8;
			// 
			// textBoxSearch
			// 
			this.textBoxSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.textBoxSearch.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxSearch.Location = new System.Drawing.Point(4, 4);
			this.textBoxSearch.Margin = new System.Windows.Forms.Padding(4);
			this.textBoxSearch.Name = "textBoxSearch";
			this.textBoxSearch.Size = new System.Drawing.Size(529, 34);
			this.textBoxSearch.TabIndex = 2;
			this.textBoxSearch.Text = "Поиск";
			this.textBoxSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.textBoxSearch.Visible = false;
			this.textBoxSearch.TextChanged += new System.EventHandler(this.TextBoxSearch_TextChanged);
			this.textBoxSearch.Enter += new System.EventHandler(this.TextBoxSearch_Enter);
			this.textBoxSearch.Leave += new System.EventHandler(this.TextBoxSearch_Leave);
			// 
			// pictureBoxSearch
			// 
			this.pictureBoxSearch.BackgroundImage = global::LocalMessengerServer.Properties.Resources.Search;
			this.pictureBoxSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pictureBoxSearch.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pictureBoxSearch.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pictureBoxSearch.Location = new System.Drawing.Point(541, 4);
			this.pictureBoxSearch.Margin = new System.Windows.Forms.Padding(4);
			this.pictureBoxSearch.Name = "pictureBoxSearch";
			this.pictureBoxSearch.Size = new System.Drawing.Size(87, 1);
			this.pictureBoxSearch.TabIndex = 9;
			this.pictureBoxSearch.TabStop = false;
			this.pictureBoxSearch.Visible = false;
			this.pictureBoxSearch.Click += new System.EventHandler(this.PictureBoxSearch_Click);
			// 
			// FormServer
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(648, 127);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "FormServer";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Server";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormServer_FormClosing);
			this.Load += new System.EventHandler(this.FormServer_Load);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.panelAdmin.ResumeLayout(false);
			this.tableLayoutPanel2.ResumeLayout(false);
			this.tableLayoutPanel2.PerformLayout();
			this.tableLayoutPanel9.ResumeLayout(false);
			this.tableLayoutPanel6.ResumeLayout(false);
			this.tableLayoutPanel6.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxPassword)).EndInit();
			this.tableLayoutPanel7.ResumeLayout(false);
			this.tableLayoutPanel7.PerformLayout();
			this.tableLayoutPanel5.ResumeLayout(false);
			this.tableLayoutPanel5.PerformLayout();
			this.tableLayoutPanel4.ResumeLayout(false);
			this.tableLayoutPanel4.PerformLayout();
			this.tableLayoutPanel3.ResumeLayout(false);
			this.tableLayoutPanel3.PerformLayout();
			this.tableLayoutPanel8.ResumeLayout(false);
			this.tableLayoutPanel8.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxSearch)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelChat;
        private System.Windows.Forms.Button buttonAdmin;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panelAdmin;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label labelBackID;
        private System.Windows.Forms.Label labelNextID;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Button buttonBackID;
        private System.Windows.Forms.Button buttonNextID;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel9;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonChange;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.PictureBox pictureBoxPassword;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.PictureBox pictureBoxSearch;
    }
}

