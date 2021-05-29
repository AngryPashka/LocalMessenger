namespace LocalMessengerClient
{
    partial class FormChat
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormChat));
			this.tableLayoutPanelMSG = new System.Windows.Forms.TableLayoutPanel();
			this.listBoxMsg = new System.Windows.Forms.ListBox();
			this.textBoxMsg = new System.Windows.Forms.TextBox();
			this.tableLayoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
			this.tableLayoutPanelUsers = new System.Windows.Forms.TableLayoutPanel();
			this.label1 = new System.Windows.Forms.Label();
			this.richTextBoxUsers = new System.Windows.Forms.RichTextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.tableLayoutPanelMSG.SuspendLayout();
			this.tableLayoutPanelMain.SuspendLayout();
			this.tableLayoutPanelUsers.SuspendLayout();
			this.SuspendLayout();
			// 
			// tableLayoutPanelMSG
			// 
			this.tableLayoutPanelMSG.ColumnCount = 1;
			this.tableLayoutPanelMSG.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.66666F));
			this.tableLayoutPanelMSG.Controls.Add(this.listBoxMsg, 0, 0);
			this.tableLayoutPanelMSG.Controls.Add(this.textBoxMsg, 0, 1);
			this.tableLayoutPanelMSG.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanelMSG.Location = new System.Drawing.Point(4, 4);
			this.tableLayoutPanelMSG.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.tableLayoutPanelMSG.Name = "tableLayoutPanelMSG";
			this.tableLayoutPanelMSG.RowCount = 2;
			this.tableLayoutPanelMSG.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanelMSG.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 123F));
			this.tableLayoutPanelMSG.Size = new System.Drawing.Size(845, 546);
			this.tableLayoutPanelMSG.TabIndex = 0;
			this.tableLayoutPanelMSG.TabStop = true;
			// 
			// listBoxMsg
			// 
			this.listBoxMsg.BackColor = System.Drawing.Color.White;
			this.listBoxMsg.Dock = System.Windows.Forms.DockStyle.Fill;
			this.listBoxMsg.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.listBoxMsg.FormattingEnabled = true;
			this.listBoxMsg.ItemHeight = 24;
			this.listBoxMsg.Location = new System.Drawing.Point(4, 4);
			this.listBoxMsg.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.listBoxMsg.Name = "listBoxMsg";
			this.listBoxMsg.Size = new System.Drawing.Size(837, 415);
			this.listBoxMsg.TabIndex = 0;
			this.listBoxMsg.TabStop = false;
			// 
			// textBoxMsg
			// 
			this.textBoxMsg.BackColor = System.Drawing.Color.White;
			this.textBoxMsg.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBoxMsg.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxMsg.ForeColor = System.Drawing.Color.Gray;
			this.textBoxMsg.Location = new System.Drawing.Point(4, 427);
			this.textBoxMsg.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.textBoxMsg.Multiline = true;
			this.textBoxMsg.Name = "textBoxMsg";
			this.textBoxMsg.Size = new System.Drawing.Size(837, 115);
			this.textBoxMsg.TabIndex = 1;
			this.textBoxMsg.Text = "Сообщение";
			this.textBoxMsg.Enter += new System.EventHandler(this.TextBoxMsg_Enter);
			this.textBoxMsg.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxMsg_KeyDown);
			this.textBoxMsg.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TextBoxMsg_KeyUp);
			this.textBoxMsg.Leave += new System.EventHandler(this.TextBoxMsg_Leave);
			// 
			// tableLayoutPanelMain
			// 
			this.tableLayoutPanelMain.ColumnCount = 2;
			this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
			this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanelMain.Controls.Add(this.tableLayoutPanelMSG, 0, 0);
			this.tableLayoutPanelMain.Controls.Add(this.tableLayoutPanelUsers, 1, 0);
			this.tableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanelMain.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanelMain.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.tableLayoutPanelMain.Name = "tableLayoutPanelMain";
			this.tableLayoutPanelMain.RowCount = 1;
			this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanelMain.Size = new System.Drawing.Size(1067, 554);
			this.tableLayoutPanelMain.TabIndex = 1;
			// 
			// tableLayoutPanelUsers
			// 
			this.tableLayoutPanelUsers.ColumnCount = 1;
			this.tableLayoutPanelUsers.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanelUsers.Controls.Add(this.label1, 0, 0);
			this.tableLayoutPanelUsers.Controls.Add(this.richTextBoxUsers, 0, 1);
			this.tableLayoutPanelUsers.Controls.Add(this.button1, 0, 2);
			this.tableLayoutPanelUsers.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanelUsers.Location = new System.Drawing.Point(857, 4);
			this.tableLayoutPanelUsers.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.tableLayoutPanelUsers.Name = "tableLayoutPanelUsers";
			this.tableLayoutPanelUsers.RowCount = 3;
			this.tableLayoutPanelUsers.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
			this.tableLayoutPanelUsers.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanelUsers.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 123F));
			this.tableLayoutPanelUsers.Size = new System.Drawing.Size(206, 546);
			this.tableLayoutPanelUsers.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe Script", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(4, 13);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(198, 42);
			this.label1.TabIndex = 0;
			this.label1.Text = "Online:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// richTextBoxUsers
			// 
			this.richTextBoxUsers.Dock = System.Windows.Forms.DockStyle.Fill;
			this.richTextBoxUsers.Font = new System.Drawing.Font("Segoe Script", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.richTextBoxUsers.Location = new System.Drawing.Point(4, 59);
			this.richTextBoxUsers.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.richTextBoxUsers.Name = "richTextBoxUsers";
			this.richTextBoxUsers.Size = new System.Drawing.Size(198, 360);
			this.richTextBoxUsers.TabIndex = 1;
			this.richTextBoxUsers.Text = "";
			// 
			// button1
			// 
			this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
			this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Red;
			this.button1.FlatAppearance.BorderSize = 3;
			this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Location = new System.Drawing.Point(46, 448);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(114, 73);
			this.button1.TabIndex = 2;
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1_Click);
			// 
			// FormChat
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1067, 554);
			this.Controls.Add(this.tableLayoutPanelMain);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "FormChat";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Чат";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormChat_FormClosing);
			this.Load += new System.EventHandler(this.FormChat_Load);
			this.tableLayoutPanelMSG.ResumeLayout(false);
			this.tableLayoutPanelMSG.PerformLayout();
			this.tableLayoutPanelMain.ResumeLayout(false);
			this.tableLayoutPanelUsers.ResumeLayout(false);
			this.tableLayoutPanelUsers.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMSG;
        private System.Windows.Forms.ListBox listBoxMsg;
        private System.Windows.Forms.TextBox textBoxMsg;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanelUsers;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.RichTextBox richTextBoxUsers;
		private System.Windows.Forms.Button button1;
	}
}

