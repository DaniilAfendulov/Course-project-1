namespace Adventure.Forms
{
    partial class BattleForm
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
            this.components = new System.ComponentModel.Container();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.EnemyPictureBox = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.YourHPLabel = new System.Windows.Forms.Label();
            this.YourHPProgressBar = new System.Windows.Forms.ProgressBar();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.EnergyLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.LeaveButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.EnemyHPLabel = new System.Windows.Forms.Label();
            this.EnemyHPProgressBar = new System.Windows.Forms.ProgressBar();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Skill3Button = new System.Windows.Forms.Button();
            this.Skill2Button = new System.Windows.Forms.Button();
            this.Skill1Button = new System.Windows.Forms.Button();
            this.Skill4Button = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.EnergyVerticalProgressBar = new Adventure.VerticalProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EnemyPictureBox)).BeginInit();
            this.tableLayoutPanel7.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanel1);
            this.splitContainer1.Size = new System.Drawing.Size(902, 540);
            this.splitContainer1.SplitterDistance = 388;
            this.splitContainer1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.splitContainer2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.12649F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 86.8735F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(902, 388);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(3, 53);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.tableLayoutPanel6);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.tableLayoutPanel3);
            this.splitContainer2.Size = new System.Drawing.Size(896, 332);
            this.splitContainer2.SplitterDistance = 814;
            this.splitContainer2.TabIndex = 0;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 1;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel6.Controls.Add(this.EnemyPictureBox, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.tableLayoutPanel7, 0, 1);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 2;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(814, 332);
            this.tableLayoutPanel6.TabIndex = 0;
            // 
            // EnemyPictureBox
            // 
            this.EnemyPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EnemyPictureBox.Location = new System.Drawing.Point(3, 3);
            this.EnemyPictureBox.Name = "EnemyPictureBox";
            this.EnemyPictureBox.Size = new System.Drawing.Size(808, 276);
            this.EnemyPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.EnemyPictureBox.TabIndex = 2;
            this.EnemyPictureBox.TabStop = false;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 1;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.Controls.Add(this.YourHPLabel, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.YourHPProgressBar, 0, 1);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(3, 285);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 2;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.90909F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 59.09091F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(808, 44);
            this.tableLayoutPanel7.TabIndex = 3;
            // 
            // YourHPLabel
            // 
            this.YourHPLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.YourHPLabel.AutoSize = true;
            this.YourHPLabel.Location = new System.Drawing.Point(3, 0);
            this.YourHPLabel.Name = "YourHPLabel";
            this.YourHPLabel.Size = new System.Drawing.Size(802, 17);
            this.YourHPLabel.TabIndex = 1;
            this.YourHPLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // YourHPProgressBar
            // 
            this.YourHPProgressBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.YourHPProgressBar.Location = new System.Drawing.Point(3, 20);
            this.YourHPProgressBar.Name = "YourHPProgressBar";
            this.YourHPProgressBar.Size = new System.Drawing.Size(802, 21);
            this.YourHPProgressBar.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.EnergyLabel, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.EnergyVerticalProgressBar, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85.40772F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.59227F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(78, 332);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // EnergyLabel
            // 
            this.EnergyLabel.AutoSize = true;
            this.EnergyLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EnergyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EnergyLabel.Location = new System.Drawing.Point(3, 283);
            this.EnergyLabel.Name = "EnergyLabel";
            this.EnergyLabel.Size = new System.Drawing.Size(72, 49);
            this.EnergyLabel.TabIndex = 0;
            this.EnergyLabel.Text = "0/10";
            this.EnergyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90.8558F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.144197F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Controls.Add(this.LeaveButton, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel5, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(896, 44);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // LeaveButton
            // 
            this.LeaveButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LeaveButton.Location = new System.Drawing.Point(817, 3);
            this.LeaveButton.Name = "LeaveButton";
            this.LeaveButton.Size = new System.Drawing.Size(76, 38);
            this.LeaveButton.TabIndex = 0;
            this.LeaveButton.Text = "покинуть битву";
            this.LeaveButton.UseVisualStyleBackColor = true;
            this.LeaveButton.Click += new System.EventHandler(this.LeaveButton_Click_1);
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Controls.Add(this.EnemyHPLabel, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.EnemyHPProgressBar, 0, 1);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(808, 38);
            this.tableLayoutPanel5.TabIndex = 1;
            // 
            // EnemyHPLabel
            // 
            this.EnemyHPLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EnemyHPLabel.AutoSize = true;
            this.EnemyHPLabel.Location = new System.Drawing.Point(3, 0);
            this.EnemyHPLabel.Name = "EnemyHPLabel";
            this.EnemyHPLabel.Size = new System.Drawing.Size(802, 18);
            this.EnemyHPLabel.TabIndex = 0;
            this.EnemyHPLabel.Text = "1000/100";
            this.EnemyHPLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EnemyHPProgressBar
            // 
            this.EnemyHPProgressBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EnemyHPProgressBar.Location = new System.Drawing.Point(3, 21);
            this.EnemyHPProgressBar.Name = "EnemyHPProgressBar";
            this.EnemyHPProgressBar.Size = new System.Drawing.Size(802, 14);
            this.EnemyHPProgressBar.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.Skill3Button, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.Skill2Button, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.Skill1Button, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Skill4Button, 3, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(902, 148);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // Skill3Button
            // 
            this.Skill3Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Skill3Button.Location = new System.Drawing.Point(453, 3);
            this.Skill3Button.Name = "Skill3Button";
            this.Skill3Button.Size = new System.Drawing.Size(219, 142);
            this.Skill3Button.TabIndex = 3;
            this.Skill3Button.UseVisualStyleBackColor = true;
            this.Skill3Button.Click += new System.EventHandler(this.Skill3Button_Click);
            // 
            // Skill2Button
            // 
            this.Skill2Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Skill2Button.Location = new System.Drawing.Point(228, 3);
            this.Skill2Button.Name = "Skill2Button";
            this.Skill2Button.Size = new System.Drawing.Size(219, 142);
            this.Skill2Button.TabIndex = 2;
            this.Skill2Button.UseVisualStyleBackColor = true;
            this.Skill2Button.Click += new System.EventHandler(this.Skill2Button_Click);
            // 
            // Skill1Button
            // 
            this.Skill1Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Skill1Button.Location = new System.Drawing.Point(3, 3);
            this.Skill1Button.Name = "Skill1Button";
            this.Skill1Button.Size = new System.Drawing.Size(219, 142);
            this.Skill1Button.TabIndex = 1;
            this.Skill1Button.UseVisualStyleBackColor = true;
            this.Skill1Button.Click += new System.EventHandler(this.Skill1Button_Click);
            // 
            // Skill4Button
            // 
            this.Skill4Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Skill4Button.Location = new System.Drawing.Point(678, 3);
            this.Skill4Button.Name = "Skill4Button";
            this.Skill4Button.Size = new System.Drawing.Size(221, 142);
            this.Skill4Button.TabIndex = 0;
            this.Skill4Button.UseVisualStyleBackColor = true;
            this.Skill4Button.Click += new System.EventHandler(this.Skill4Button_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // EnergyVerticalProgressBar
            // 
            this.EnergyVerticalProgressBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EnergyVerticalProgressBar.Location = new System.Drawing.Point(3, 3);
            this.EnergyVerticalProgressBar.Maximum = 10;
            this.EnergyVerticalProgressBar.Name = "EnergyVerticalProgressBar";
            this.EnergyVerticalProgressBar.Size = new System.Drawing.Size(72, 277);
            this.EnergyVerticalProgressBar.Step = 1;
            this.EnergyVerticalProgressBar.TabIndex = 1;
            // 
            // BattleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 540);
            this.Controls.Add(this.splitContainer1);
            this.MinimumSize = new System.Drawing.Size(776, 443);
            this.Name = "BattleForm";
            this.Text = "BattleForm";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.EnemyPictureBox)).EndInit();
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button Skill3Button;
        private System.Windows.Forms.Button Skill2Button;
        private System.Windows.Forms.Button Skill1Button;
        private System.Windows.Forms.Button Skill4Button;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label EnergyLabel;
        private VerticalProgressBar EnergyVerticalProgressBar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button LeaveButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.PictureBox EnemyPictureBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.ProgressBar YourHPProgressBar;
        private System.Windows.Forms.Label YourHPLabel;
        private System.Windows.Forms.Label EnemyHPLabel;
        private System.Windows.Forms.ProgressBar EnemyHPProgressBar;
        private System.Windows.Forms.Timer timer1;
    }
}