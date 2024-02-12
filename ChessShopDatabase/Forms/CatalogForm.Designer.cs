namespace ChessShopDatabase.Forms
{

    partial class CatalogForm
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

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CatalogForm));
            this.addNewGoodButton = new System.Windows.Forms.Button();
            this.catalogPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // addNewGoodButton
            // 
            this.addNewGoodButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addNewGoodButton.Location = new System.Drawing.Point(548, 12);
            this.addNewGoodButton.Name = "addNewGoodButton";
            this.addNewGoodButton.Size = new System.Drawing.Size(50, 50);
            this.addNewGoodButton.TabIndex = 2;
            this.addNewGoodButton.Text = "+";
            this.addNewGoodButton.UseVisualStyleBackColor = true;
            this.addNewGoodButton.Click += new System.EventHandler(this.addNewGoodButton_Click);
            // 
            // catalogPanel
            // 
            this.catalogPanel.AutoScroll = true;
            this.catalogPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.catalogPanel.Location = new System.Drawing.Point(12, 12);
            this.catalogPanel.Name = "catalogPanel";
            this.catalogPanel.Size = new System.Drawing.Size(530, 400);
            this.catalogPanel.TabIndex = 4;
            // 
            // CatalogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 424);
            this.Controls.Add(this.addNewGoodButton);
            this.Controls.Add(this.catalogPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CatalogForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Шахматный магазин - каталог";
            this.Load += new System.EventHandler(this.CatalogForm_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button addNewGoodButton;
        private System.Windows.Forms.Panel catalogPanel;
    }

}