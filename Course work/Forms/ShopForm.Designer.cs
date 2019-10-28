namespace Adventure
{
    partial class ShopForm
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
            this.InventoryButton = new System.Windows.Forms.Button();
            this.СategoriesComboBox = new System.Windows.Forms.ComboBox();
            this.СategoriesLabel = new System.Windows.Forms.Label();
            this.BuyButton = new System.Windows.Forms.Button();
            this.ItemLabel = new System.Windows.Forms.Label();
            this.ItemComboBox = new System.Windows.Forms.ComboBox();
            this.ShopGroupBox = new System.Windows.Forms.GroupBox();
            this.NameItemLabel = new System.Windows.Forms.Label();
            this.ItemInfoLabel = new System.Windows.Forms.Label();
            this.CostLabel = new System.Windows.Forms.Label();
            this.ItemPictureBox = new System.Windows.Forms.PictureBox();
            this.MoneyLabel = new System.Windows.Forms.Label();
            this.ShopGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ItemPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // InventoryButton
            // 
            this.InventoryButton.Location = new System.Drawing.Point(169, 175);
            this.InventoryButton.Name = "InventoryButton";
            this.InventoryButton.Size = new System.Drawing.Size(70, 23);
            this.InventoryButton.TabIndex = 14;
            this.InventoryButton.Text = "инвентарь";
            this.InventoryButton.UseVisualStyleBackColor = true;
            this.InventoryButton.Click += new System.EventHandler(this.InventoryButton_Click);
            // 
            // СategoriesComboBox
            // 
            this.СategoriesComboBox.FormattingEnabled = true;
            this.СategoriesComboBox.Location = new System.Drawing.Point(9, 36);
            this.СategoriesComboBox.Name = "СategoriesComboBox";
            this.СategoriesComboBox.Size = new System.Drawing.Size(135, 21);
            this.СategoriesComboBox.TabIndex = 15;
            this.СategoriesComboBox.SelectedIndexChanged += new System.EventHandler(this.СategoriesComboBox_SelectedIndexChanged);
            // 
            // СategoriesLabel
            // 
            this.СategoriesLabel.AutoSize = true;
            this.СategoriesLabel.Location = new System.Drawing.Point(6, 20);
            this.СategoriesLabel.Name = "СategoriesLabel";
            this.СategoriesLabel.Size = new System.Drawing.Size(59, 13);
            this.СategoriesLabel.TabIndex = 16;
            this.СategoriesLabel.Text = "категории";
            // 
            // BuyButton
            // 
            this.BuyButton.Location = new System.Drawing.Point(249, 175);
            this.BuyButton.Name = "BuyButton";
            this.BuyButton.Size = new System.Drawing.Size(55, 23);
            this.BuyButton.TabIndex = 21;
            this.BuyButton.Text = "купить";
            this.BuyButton.UseVisualStyleBackColor = true;
            this.BuyButton.Click += new System.EventHandler(this.BuyButton_Click);
            // 
            // ItemLabel
            // 
            this.ItemLabel.AutoSize = true;
            this.ItemLabel.Location = new System.Drawing.Point(10, 62);
            this.ItemLabel.Name = "ItemLabel";
            this.ItemLabel.Size = new System.Drawing.Size(55, 13);
            this.ItemLabel.TabIndex = 18;
            this.ItemLabel.Text = "Предмет:";
            // 
            // ItemComboBox
            // 
            this.ItemComboBox.FormattingEnabled = true;
            this.ItemComboBox.Location = new System.Drawing.Point(9, 78);
            this.ItemComboBox.Name = "ItemComboBox";
            this.ItemComboBox.Size = new System.Drawing.Size(133, 21);
            this.ItemComboBox.TabIndex = 17;
            this.ItemComboBox.SelectedIndexChanged += new System.EventHandler(this.ItemComboBox_SelectedIndexChanged);
            // 
            // ShopGroupBox
            // 
            this.ShopGroupBox.Controls.Add(this.MoneyLabel);
            this.ShopGroupBox.Controls.Add(this.NameItemLabel);
            this.ShopGroupBox.Controls.Add(this.InventoryButton);
            this.ShopGroupBox.Controls.Add(this.ItemInfoLabel);
            this.ShopGroupBox.Controls.Add(this.CostLabel);
            this.ShopGroupBox.Controls.Add(this.BuyButton);
            this.ShopGroupBox.Controls.Add(this.ItemPictureBox);
            this.ShopGroupBox.Controls.Add(this.ItemLabel);
            this.ShopGroupBox.Controls.Add(this.ItemComboBox);
            this.ShopGroupBox.Controls.Add(this.СategoriesLabel);
            this.ShopGroupBox.Controls.Add(this.СategoriesComboBox);
            this.ShopGroupBox.Location = new System.Drawing.Point(7, 12);
            this.ShopGroupBox.Name = "ShopGroupBox";
            this.ShopGroupBox.Size = new System.Drawing.Size(316, 203);
            this.ShopGroupBox.TabIndex = 23;
            this.ShopGroupBox.TabStop = false;
            this.ShopGroupBox.Text = "Магазин";
            // 
            // NameItemLabel
            // 
            this.NameItemLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NameItemLabel.AutoSize = true;
            this.NameItemLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameItemLabel.Location = new System.Drawing.Point(210, 28);
            this.NameItemLabel.Name = "NameItemLabel";
            this.NameItemLabel.Size = new System.Drawing.Size(62, 15);
            this.NameItemLabel.TabIndex = 26;
            this.NameItemLabel.Text = "название";
            this.NameItemLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ItemInfoLabel
            // 
            this.ItemInfoLabel.BackColor = System.Drawing.SystemColors.Window;
            this.ItemInfoLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ItemInfoLabel.Location = new System.Drawing.Point(9, 102);
            this.ItemInfoLabel.Name = "ItemInfoLabel";
            this.ItemInfoLabel.Size = new System.Drawing.Size(135, 99);
            this.ItemInfoLabel.TabIndex = 25;
            this.ItemInfoLabel.Text = "характеристики";
            // 
            // CostLabel
            // 
            this.CostLabel.AutoSize = true;
            this.CostLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CostLabel.Location = new System.Drawing.Point(166, 153);
            this.CostLabel.Name = "CostLabel";
            this.CostLabel.Size = new System.Drawing.Size(85, 16);
            this.CostLabel.TabIndex = 24;
            this.CostLabel.Text = "стоимость";
            this.CostLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ItemPictureBox
            // 
            this.ItemPictureBox.BackColor = System.Drawing.Color.White;
            this.ItemPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ItemPictureBox.Location = new System.Drawing.Point(169, 46);
            this.ItemPictureBox.Name = "ItemPictureBox";
            this.ItemPictureBox.Size = new System.Drawing.Size(135, 104);
            this.ItemPictureBox.TabIndex = 23;
            this.ItemPictureBox.TabStop = false;
            // 
            // MoneyLabel
            // 
            this.MoneyLabel.AutoSize = true;
            this.MoneyLabel.Location = new System.Drawing.Point(166, 16);
            this.MoneyLabel.Name = "MoneyLabel";
            this.MoneyLabel.Size = new System.Drawing.Size(35, 13);
            this.MoneyLabel.TabIndex = 27;
            this.MoneyLabel.Text = "label1";
            // 
            // ShopForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 235);
            this.Controls.Add(this.ShopGroupBox);
            this.Location = new System.Drawing.Point(0, 400);
            this.Name = "ShopForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Магазин";
            this.ShopGroupBox.ResumeLayout(false);
            this.ShopGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ItemPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button InventoryButton;
        private System.Windows.Forms.ComboBox СategoriesComboBox;
        private System.Windows.Forms.Label СategoriesLabel;
        private System.Windows.Forms.Button BuyButton;
        private System.Windows.Forms.Label ItemLabel;
        private System.Windows.Forms.ComboBox ItemComboBox;
        private System.Windows.Forms.GroupBox ShopGroupBox;
        private System.Windows.Forms.Label NameItemLabel;
        private System.Windows.Forms.Label ItemInfoLabel;
        private System.Windows.Forms.Label CostLabel;
        private System.Windows.Forms.PictureBox ItemPictureBox;
        private System.Windows.Forms.Label MoneyLabel;
    }
}