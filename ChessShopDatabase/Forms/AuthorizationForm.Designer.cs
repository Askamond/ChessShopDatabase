namespace ChessShopDatabase.Forms
{

    partial class AuthorizationForm
    {

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuthorizationForm));
            this.userLoginTextBox = new System.Windows.Forms.TextBox();
            this.userPasswordTextBox = new System.Windows.Forms.MaskedTextBox();
            this.userLoginLabel = new System.Windows.Forms.Label();
            this.userPasswordLabel = new System.Windows.Forms.Label();
            this.connectButton = new System.Windows.Forms.Button();
            this.checkInButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // userLoginTextBox
            // 
            this.userLoginTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.userLoginTextBox.Location = new System.Drawing.Point(124, 12);
            this.userLoginTextBox.Name = "userLoginTextBox";
            this.userLoginTextBox.ShortcutsEnabled = false;
            this.userLoginTextBox.Size = new System.Drawing.Size(148, 20);
            this.userLoginTextBox.TabIndex = 0;
            this.userLoginTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.anyTextBox_KeyDown);
            // 
            // userPasswordTextBox
            // 
            this.userPasswordTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.userPasswordTextBox.Location = new System.Drawing.Point(124, 38);
            this.userPasswordTextBox.Name = "userPasswordTextBox";
            this.userPasswordTextBox.PasswordChar = '*';
            this.userPasswordTextBox.PromptChar = ' ';
            this.userPasswordTextBox.Size = new System.Drawing.Size(148, 20);
            this.userPasswordTextBox.TabIndex = 1;
            this.userPasswordTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.anyTextBox_KeyDown);
            // 
            // userLoginLabel
            // 
            this.userLoginLabel.AutoSize = true;
            this.userLoginLabel.Location = new System.Drawing.Point(12, 15);
            this.userLoginLabel.Name = "userLoginLabel";
            this.userLoginLabel.Size = new System.Drawing.Size(106, 13);
            this.userLoginLabel.TabIndex = 2;
            this.userLoginLabel.Text = "Имя пользователя:";
            // 
            // userPasswordLabel
            // 
            this.userPasswordLabel.AutoSize = true;
            this.userPasswordLabel.Location = new System.Drawing.Point(12, 41);
            this.userPasswordLabel.Name = "userPasswordLabel";
            this.userPasswordLabel.Size = new System.Drawing.Size(48, 13);
            this.userPasswordLabel.TabIndex = 3;
            this.userPasswordLabel.Text = "Пароль:";
            // 
            // connectButton
            // 
            this.connectButton.Location = new System.Drawing.Point(15, 64);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(257, 23);
            this.connectButton.TabIndex = 4;
            this.connectButton.Text = "Подключиться";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // checkInButton
            // 
            this.checkInButton.Location = new System.Drawing.Point(15, 93);
            this.checkInButton.Name = "checkInButton";
            this.checkInButton.Size = new System.Drawing.Size(257, 23);
            this.checkInButton.TabIndex = 5;
            this.checkInButton.Text = "Зарегистрироваться";
            this.checkInButton.UseVisualStyleBackColor = true;
            this.checkInButton.Click += new System.EventHandler(this.checkInButton_Click);
            // 
            // AuthorizationForm
            // 
            this.AcceptButton = this.connectButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 128);
            this.Controls.Add(this.checkInButton);
            this.Controls.Add(this.connectButton);
            this.Controls.Add(this.userPasswordLabel);
            this.Controls.Add(this.userLoginLabel);
            this.Controls.Add(this.userPasswordTextBox);
            this.Controls.Add(this.userLoginTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AuthorizationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация пользователя";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox userLoginTextBox;
        private System.Windows.Forms.MaskedTextBox userPasswordTextBox;
        private System.Windows.Forms.Label userLoginLabel;
        private System.Windows.Forms.Label userPasswordLabel;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.Button checkInButton;
    }

}