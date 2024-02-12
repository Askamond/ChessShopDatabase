namespace ChessShopDatabase.Forms
{

    partial class MainForm
    {
        
        private System.ComponentModel.IContainer components = null;
        
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.userManagementAdminButton = new System.Windows.Forms.Button();
            this.adminPanel = new System.Windows.Forms.Panel();
            this.loadDatabaseBackupAdminButton = new System.Windows.Forms.Button();
            this.createDatabaseBackupAdminButton = new System.Windows.Forms.Button();
            this.showLogsAdminButton = new System.Windows.Forms.Button();
            this.editorPanel = new System.Windows.Forms.Panel();
            this.showOrdersEditorButton = new System.Windows.Forms.Button();
            this.showCatalogEditorButton = new System.Windows.Forms.Button();
            this.showLogsEditorButton = new System.Windows.Forms.Button();
            this.showCatalogUserButton = new System.Windows.Forms.Button();
            this.showCartUserButton = new System.Windows.Forms.Button();
            this.userPanel = new System.Windows.Forms.Panel();
            this.adminPanel.SuspendLayout();
            this.editorPanel.SuspendLayout();
            this.userPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // userManagementAdminButton
            // 
            this.userManagementAdminButton.Location = new System.Drawing.Point(3, 3);
            this.userManagementAdminButton.Name = "userManagementAdminButton";
            this.userManagementAdminButton.Size = new System.Drawing.Size(300, 25);
            this.userManagementAdminButton.TabIndex = 0;
            this.userManagementAdminButton.Text = "Управление пользователями";
            this.userManagementAdminButton.UseVisualStyleBackColor = true;
            this.userManagementAdminButton.Click += new System.EventHandler(this.userManagementAdminButton_Click);
            // 
            // adminPanel
            // 
            this.adminPanel.Controls.Add(this.loadDatabaseBackupAdminButton);
            this.adminPanel.Controls.Add(this.createDatabaseBackupAdminButton);
            this.adminPanel.Controls.Add(this.showLogsAdminButton);
            this.adminPanel.Controls.Add(this.userManagementAdminButton);
            this.adminPanel.Location = new System.Drawing.Point(12, 12);
            this.adminPanel.Name = "adminPanel";
            this.adminPanel.Size = new System.Drawing.Size(306, 124);
            this.adminPanel.TabIndex = 1;
            this.adminPanel.Visible = false;
            // 
            // loadDatabaseBackupAdminButton
            // 
            this.loadDatabaseBackupAdminButton.Location = new System.Drawing.Point(3, 96);
            this.loadDatabaseBackupAdminButton.Name = "loadDatabaseBackupAdminButton";
            this.loadDatabaseBackupAdminButton.Size = new System.Drawing.Size(300, 25);
            this.loadDatabaseBackupAdminButton.TabIndex = 5;
            this.loadDatabaseBackupAdminButton.Text = "Восстановить БД из резервной копии";
            this.loadDatabaseBackupAdminButton.UseVisualStyleBackColor = true;
            this.loadDatabaseBackupAdminButton.Click += new System.EventHandler(this.loadDatabaseBackupAdminButton_Click);
            // 
            // createDatabaseBackupAdminButton
            // 
            this.createDatabaseBackupAdminButton.Location = new System.Drawing.Point(3, 65);
            this.createDatabaseBackupAdminButton.Name = "createDatabaseBackupAdminButton";
            this.createDatabaseBackupAdminButton.Size = new System.Drawing.Size(300, 25);
            this.createDatabaseBackupAdminButton.TabIndex = 4;
            this.createDatabaseBackupAdminButton.Text = "Создать резервную копию БД";
            this.createDatabaseBackupAdminButton.UseVisualStyleBackColor = true;
            this.createDatabaseBackupAdminButton.Click += new System.EventHandler(this.createDatabaseBackupAdminButton_Click);
            // 
            // showLogsAdminButton
            // 
            this.showLogsAdminButton.Location = new System.Drawing.Point(3, 34);
            this.showLogsAdminButton.Name = "showLogsAdminButton";
            this.showLogsAdminButton.Size = new System.Drawing.Size(300, 25);
            this.showLogsAdminButton.TabIndex = 1;
            this.showLogsAdminButton.Text = "Просмотр действий пользователей";
            this.showLogsAdminButton.UseVisualStyleBackColor = true;
            this.showLogsAdminButton.Click += new System.EventHandler(this.showLogsAdminButton_Click);
            // 
            // editorPanel
            // 
            this.editorPanel.Controls.Add(this.showOrdersEditorButton);
            this.editorPanel.Controls.Add(this.showCatalogEditorButton);
            this.editorPanel.Controls.Add(this.showLogsEditorButton);
            this.editorPanel.Location = new System.Drawing.Point(12, 12);
            this.editorPanel.Name = "editorPanel";
            this.editorPanel.Size = new System.Drawing.Size(306, 93);
            this.editorPanel.TabIndex = 2;
            this.editorPanel.Visible = false;
            // 
            // showOrdersEditorButton
            // 
            this.showOrdersEditorButton.Location = new System.Drawing.Point(3, 65);
            this.showOrdersEditorButton.Name = "showOrdersEditorButton";
            this.showOrdersEditorButton.Size = new System.Drawing.Size(300, 25);
            this.showOrdersEditorButton.TabIndex = 4;
            this.showOrdersEditorButton.Text = "Управление заказами";
            this.showOrdersEditorButton.UseVisualStyleBackColor = true;
            this.showOrdersEditorButton.Click += new System.EventHandler(this.showOrdersEditorButton_Click);
            // 
            // showCatalogEditorButton
            // 
            this.showCatalogEditorButton.Location = new System.Drawing.Point(3, 34);
            this.showCatalogEditorButton.Name = "showCatalogEditorButton";
            this.showCatalogEditorButton.Size = new System.Drawing.Size(300, 25);
            this.showCatalogEditorButton.TabIndex = 3;
            this.showCatalogEditorButton.Text = "Управление каталогом";
            this.showCatalogEditorButton.UseVisualStyleBackColor = true;
            this.showCatalogEditorButton.Click += new System.EventHandler(this.showCatalogEditorButton_Click);
            // 
            // showLogsEditorButton
            // 
            this.showLogsEditorButton.Location = new System.Drawing.Point(3, 3);
            this.showLogsEditorButton.Name = "showLogsEditorButton";
            this.showLogsEditorButton.Size = new System.Drawing.Size(300, 25);
            this.showLogsEditorButton.TabIndex = 2;
            this.showLogsEditorButton.Text = "Просмотр действий пользователей";
            this.showLogsEditorButton.UseVisualStyleBackColor = true;
            this.showLogsEditorButton.Click += new System.EventHandler(this.showLogsEditorButton_Click);
            // 
            // showCatalogUserButton
            // 
            this.showCatalogUserButton.Location = new System.Drawing.Point(3, 3);
            this.showCatalogUserButton.Name = "showCatalogUserButton";
            this.showCatalogUserButton.Size = new System.Drawing.Size(300, 25);
            this.showCatalogUserButton.TabIndex = 5;
            this.showCatalogUserButton.Text = "Просмотр каталога";
            this.showCatalogUserButton.UseVisualStyleBackColor = true;
            this.showCatalogUserButton.Click += new System.EventHandler(this.showCatalogUserButton_Click);
            // 
            // showCartUserButton
            // 
            this.showCartUserButton.Location = new System.Drawing.Point(3, 34);
            this.showCartUserButton.Name = "showCartUserButton";
            this.showCartUserButton.Size = new System.Drawing.Size(300, 25);
            this.showCartUserButton.TabIndex = 6;
            this.showCartUserButton.Text = "Корзина";
            this.showCartUserButton.UseVisualStyleBackColor = true;
            this.showCartUserButton.Click += new System.EventHandler(this.showCartUserButton_Click);
            // 
            // userPanel
            // 
            this.userPanel.Controls.Add(this.showCartUserButton);
            this.userPanel.Controls.Add(this.showCatalogUserButton);
            this.userPanel.Location = new System.Drawing.Point(12, 12);
            this.userPanel.Name = "userPanel";
            this.userPanel.Size = new System.Drawing.Size(306, 62);
            this.userPanel.TabIndex = 2;
            this.userPanel.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 86);
            this.Controls.Add(this.userPanel);
            this.Controls.Add(this.editorPanel);
            this.Controls.Add(this.adminPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Шахматный магазин - главная";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.adminPanel.ResumeLayout(false);
            this.editorPanel.ResumeLayout(false);
            this.userPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        
        private System.Windows.Forms.Panel adminPanel;
        private System.Windows.Forms.Button userManagementAdminButton;
        private System.Windows.Forms.Button showLogsAdminButton;
        private System.Windows.Forms.Panel editorPanel;
        private System.Windows.Forms.Button showLogsEditorButton;
        private System.Windows.Forms.Button showOrdersEditorButton;
        private System.Windows.Forms.Button showCatalogEditorButton;
        private System.Windows.Forms.Panel userPanel;
        private System.Windows.Forms.Button showCatalogUserButton;
        private System.Windows.Forms.Button showCartUserButton;
        private System.Windows.Forms.Button loadDatabaseBackupAdminButton;
        private System.Windows.Forms.Button createDatabaseBackupAdminButton;
    }

}