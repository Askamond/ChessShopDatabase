namespace ChessShopDatabase.Forms
{

    partial class CheckInForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CheckInForm));
            this.checkInButton = new System.Windows.Forms.Button();
            this.userLoginLabel = new System.Windows.Forms.Label();
            this.userPasswordLabel = new System.Windows.Forms.Label();
            this.userLoginTextBox = new System.Windows.Forms.TextBox();
            this.userPasswordTextBox = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // checkInButton
            // 
            this.checkInButton.Location = new System.Drawing.Point(12, 58);
            this.checkInButton.Name = "checkInButton";
            this.checkInButton.Size = new System.Drawing.Size(260, 23);
            this.checkInButton.TabIndex = 0;
            this.checkInButton.Text = "Зарегистрироваться";
            this.checkInButton.UseVisualStyleBackColor = true;
            this.checkInButton.Click += new System.EventHandler(this.checkInButton_Click);
            // 
            // userLoginLabel
            // 
            this.userLoginLabel.AutoSize = true;
            this.userLoginLabel.Location = new System.Drawing.Point(12, 9);
            this.userLoginLabel.Name = "userLoginLabel";
            this.userLoginLabel.Size = new System.Drawing.Size(106, 13);
            this.userLoginLabel.TabIndex = 1;
            this.userLoginLabel.Text = "Имя пользователя:";
            // 
            // userPasswordLabel
            // 
            this.userPasswordLabel.AutoSize = true;
            this.userPasswordLabel.Location = new System.Drawing.Point(12, 35);
            this.userPasswordLabel.Name = "userPasswordLabel";
            this.userPasswordLabel.Size = new System.Drawing.Size(48, 13);
            this.userPasswordLabel.TabIndex = 2;
            this.userPasswordLabel.Text = "Пароль:";
            // 
            // userLoginTextBox
            // 
            this.userLoginTextBox.Location = new System.Drawing.Point(124, 6);
            this.userLoginTextBox.Name = "userLoginTextBox";
            this.userLoginTextBox.Size = new System.Drawing.Size(148, 20);
            this.userLoginTextBox.TabIndex = 3;
            this.userLoginTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.anyTextBox_KeyDown);
            // 
            // userPasswordTextBox
            // 
            this.userPasswordTextBox.Location = new System.Drawing.Point(124, 32);
            this.userPasswordTextBox.Name = "userPasswordTextBox";
            this.userPasswordTextBox.PasswordChar = '*';
            this.userPasswordTextBox.PromptChar = ' ';
            this.userPasswordTextBox.Size = new System.Drawing.Size(148, 20);
            this.userPasswordTextBox.TabIndex = 4;
            this.userPasswordTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.anyTextBox_KeyDown);
            // 
            // CheckInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 93);
            this.Controls.Add(this.userPasswordTextBox);
            this.Controls.Add(this.userLoginTextBox);
            this.Controls.Add(this.userPasswordLabel);
            this.Controls.Add(this.userLoginLabel);
            this.Controls.Add(this.checkInButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CheckInForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Регистрация пользователя";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button checkInButton;
        private System.Windows.Forms.Label userLoginLabel;
        private System.Windows.Forms.Label userPasswordLabel;
        private System.Windows.Forms.TextBox userLoginTextBox;
        private System.Windows.Forms.MaskedTextBox userPasswordTextBox;
    }

}