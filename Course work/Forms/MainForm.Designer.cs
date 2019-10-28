namespace Adventure
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.ToShopButton = new System.Windows.Forms.Button();
            this.СharacteristicsLabel = new System.Windows.Forms.Label();
            this.ShowInventoryButton = new System.Windows.Forms.Button();
            this.PetLabel = new System.Windows.Forms.Label();
            this.CharacterGroupBox = new System.Windows.Forms.GroupBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.BattleButton = new System.Windows.Forms.Button();
            this.SkillsButton = new System.Windows.Forms.Button();
            this.CharacterGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ToShopButton
            // 
            this.ToShopButton.Location = new System.Drawing.Point(218, 183);
            this.ToShopButton.Name = "ToShopButton";
            this.ToShopButton.Size = new System.Drawing.Size(75, 23);
            this.ToShopButton.TabIndex = 4;
            this.ToShopButton.Text = "Магазин";
            this.ToShopButton.UseVisualStyleBackColor = true;
            this.ToShopButton.Click += new System.EventHandler(this.ShowShop_Button_Click);
            // 
            // СharacteristicsLabel
            // 
            this.СharacteristicsLabel.AutoSize = true;
            this.СharacteristicsLabel.Location = new System.Drawing.Point(12, 20);
            this.СharacteristicsLabel.Name = "СharacteristicsLabel";
            this.СharacteristicsLabel.Size = new System.Drawing.Size(13, 117);
            this.СharacteristicsLabel.TabIndex = 0;
            this.СharacteristicsLabel.Text = "1\r\n2\r\n3\r\n4\r\n5\r\n6\r\n7\r\n8\r\n9";
            // 
            // ShowInventoryButton
            // 
            this.ShowInventoryButton.Location = new System.Drawing.Point(12, 183);
            this.ShowInventoryButton.Name = "ShowInventoryButton";
            this.ShowInventoryButton.Size = new System.Drawing.Size(117, 23);
            this.ShowInventoryButton.TabIndex = 5;
            this.ShowInventoryButton.Text = "Инвентарь";
            this.ShowInventoryButton.UseVisualStyleBackColor = true;
            this.ShowInventoryButton.Click += new System.EventHandler(this.ShowInventory_Button_Click);
            // 
            // PetLabel
            // 
            this.PetLabel.AutoSize = true;
            this.PetLabel.Location = new System.Drawing.Point(158, 20);
            this.PetLabel.Name = "PetLabel";
            this.PetLabel.Size = new System.Drawing.Size(13, 91);
            this.PetLabel.TabIndex = 9;
            this.PetLabel.Text = "1\r\n2\r\n3\r\n4\r\n5\r\n6\r\n7";
            // 
            // CharacterGroupBox
            // 
            this.CharacterGroupBox.Controls.Add(this.PetLabel);
            this.CharacterGroupBox.Controls.Add(this.СharacteristicsLabel);
            this.CharacterGroupBox.Location = new System.Drawing.Point(12, 2);
            this.CharacterGroupBox.Name = "CharacterGroupBox";
            this.CharacterGroupBox.Size = new System.Drawing.Size(281, 175);
            this.CharacterGroupBox.TabIndex = 9;
            this.CharacterGroupBox.TabStop = false;
            // 
            // BattleButton
            // 
            this.BattleButton.Location = new System.Drawing.Point(392, 183);
            this.BattleButton.Name = "BattleButton";
            this.BattleButton.Size = new System.Drawing.Size(146, 23);
            this.BattleButton.TabIndex = 10;
            this.BattleButton.Text = "битва";
            this.BattleButton.UseVisualStyleBackColor = true;
            this.BattleButton.Click += new System.EventHandler(this.StartBattle_Button_Click);
            // 
            // SkillsButton
            // 
            this.SkillsButton.Location = new System.Drawing.Point(392, 12);
            this.SkillsButton.Name = "SkillsButton";
            this.SkillsButton.Size = new System.Drawing.Size(146, 67);
            this.SkillsButton.TabIndex = 11;
            this.SkillsButton.Text = "умения";
            this.SkillsButton.UseVisualStyleBackColor = true;
            this.SkillsButton.Click += new System.EventHandler(this.ShowSkills_Button_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 240);
            this.Controls.Add(this.SkillsButton);
            this.Controls.Add(this.BattleButton);
            this.Controls.Add(this.CharacterGroupBox);
            this.Controls.Add(this.ToShopButton);
            this.Controls.Add(this.ShowInventoryButton);
            this.Name = "MainForm";
            this.Text = "adventure";
            this.MouseEnter += new System.EventHandler(this.MainForm_MouseEnter);
            this.CharacterGroupBox.ResumeLayout(false);
            this.CharacterGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button ToShopButton;
        private System.Windows.Forms.Label СharacteristicsLabel;
        private System.Windows.Forms.Button ShowInventoryButton;
        private System.Windows.Forms.Label PetLabel;
        private System.Windows.Forms.GroupBox CharacterGroupBox;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button BattleButton;
        private System.Windows.Forms.Button SkillsButton;
    }
}

