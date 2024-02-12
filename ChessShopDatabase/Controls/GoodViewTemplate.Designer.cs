namespace ChessShopDatabase.Controls
{

    partial class GoodViewTemplate
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

        #region Component Designer generated code
        
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GoodViewTemplate));
            this.editorPanel = new System.Windows.Forms.Panel();
            this.deleteGoodButton = new System.Windows.Forms.Button();
            this.editGoodButton = new System.Windows.Forms.Button();
            this.goodTypeLabel = new System.Windows.Forms.Label();
            this.goodNameLabel = new System.Windows.Forms.Label();
            this.goodImage = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.editorPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.goodImage)).BeginInit();
            this.SuspendLayout();
            // 
            // editorPanel
            // 
            this.editorPanel.Controls.Add(this.button1);
            this.editorPanel.Controls.Add(this.deleteGoodButton);
            this.editorPanel.Controls.Add(this.editGoodButton);
            this.editorPanel.Controls.Add(this.goodTypeLabel);
            this.editorPanel.Controls.Add(this.goodNameLabel);
            this.editorPanel.Controls.Add(this.goodImage);
            this.editorPanel.Location = new System.Drawing.Point(3, 3);
            this.editorPanel.Name = "editorPanel";
            this.editorPanel.Size = new System.Drawing.Size(500, 56);
            this.editorPanel.TabIndex = 1;
            // 
            // deleteGoodButton
            // 
            this.deleteGoodButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteGoodButton.Image = global::ChessShopDatabase.Properties.Resources.Trash;
            this.deleteGoodButton.Location = new System.Drawing.Point(447, 3);
            this.deleteGoodButton.Name = "deleteGoodButton";
            this.deleteGoodButton.Size = new System.Drawing.Size(50, 50);
            this.deleteGoodButton.TabIndex = 6;
            this.deleteGoodButton.UseVisualStyleBackColor = true;
            this.deleteGoodButton.Click += new System.EventHandler(this.deleteGoodButton_Click);
            // 
            // editGoodButton
            // 
            this.editGoodButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.editGoodButton.Image = ((System.Drawing.Image)(resources.GetObject("editGoodButton.Image")));
            this.editGoodButton.Location = new System.Drawing.Point(391, 3);
            this.editGoodButton.Name = "editGoodButton";
            this.editGoodButton.Size = new System.Drawing.Size(50, 50);
            this.editGoodButton.TabIndex = 5;
            this.editGoodButton.UseVisualStyleBackColor = true;
            this.editGoodButton.Click += new System.EventHandler(this.editGoodButton_Click);
            // 
            // goodTypeLabel
            // 
            this.goodTypeLabel.AutoSize = true;
            this.goodTypeLabel.Location = new System.Drawing.Point(59, 37);
            this.goodTypeLabel.Name = "goodTypeLabel";
            this.goodTypeLabel.Size = new System.Drawing.Size(32, 13);
            this.goodTypeLabel.TabIndex = 4;
            this.goodTypeLabel.Text = "Тип: ";
            // 
            // goodNameLabel
            // 
            this.goodNameLabel.AutoSize = true;
            this.goodNameLabel.Location = new System.Drawing.Point(59, 6);
            this.goodNameLabel.Name = "goodNameLabel";
            this.goodNameLabel.Size = new System.Drawing.Size(89, 13);
            this.goodNameLabel.TabIndex = 2;
            this.goodNameLabel.Text = "Наименование: ";
            // 
            // goodImage
            // 
            this.goodImage.Location = new System.Drawing.Point(3, 3);
            this.goodImage.Name = "goodImage";
            this.goodImage.Size = new System.Drawing.Size(50, 50);
            this.goodImage.TabIndex = 1;
            this.goodImage.TabStop = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(335, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 50);
            this.button1.TabIndex = 7;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // GoodViewTemplate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.editorPanel);
            this.Name = "GoodViewTemplate";
            this.Size = new System.Drawing.Size(506, 62);
            this.Load += new System.EventHandler(this.GoodViewTemplate_Load);
            this.editorPanel.ResumeLayout(false);
            this.editorPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.goodImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel editorPanel;
        private System.Windows.Forms.Label goodNameLabel;
        private System.Windows.Forms.PictureBox goodImage;
        private System.Windows.Forms.Label goodTypeLabel;
        private System.Windows.Forms.Button editGoodButton;
        private System.Windows.Forms.Button deleteGoodButton;
        private System.Windows.Forms.Button button1;
    }

}
