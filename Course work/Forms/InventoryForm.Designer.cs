namespace Приключение.Forms
{
    partial class InventoryForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.InventoryListBox = new System.Windows.Forms.ListBox();
            this.ItemsLabel = new System.Windows.Forms.Label();
            this.ItemsPicture = new System.Windows.Forms.PictureBox();
            this.PersonPicture = new System.Windows.Forms.PictureBox();
            this.PetsPicture = new System.Windows.Forms.PictureBox();
            this.PersonLabel = new System.Windows.Forms.Label();
            this.PetsLabel = new System.Windows.Forms.Label();
            this.QuestsContainer = new System.Windows.Forms.SplitContainer();
            this.QuestsListBox = new System.Windows.Forms.ListBox();
            this.QuestsLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ItemsPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PersonPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PetsPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuestsContainer)).BeginInit();
            this.QuestsContainer.Panel1.SuspendLayout();
            this.QuestsContainer.Panel2.SuspendLayout();
            this.QuestsContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Outset;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.InventoryListBox, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.ItemsLabel, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.ItemsPicture, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.PersonPicture, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.PetsPicture, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.PersonLabel, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.PetsLabel, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.QuestsContainer, 3, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(1, 1);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(782, 321);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // InventoryListBox
            // 
            this.InventoryListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InventoryListBox.FormattingEnabled = true;
            this.InventoryListBox.Location = new System.Drawing.Point(395, 164);
            this.InventoryListBox.Name = "InventoryListBox";
            this.InventoryListBox.Size = new System.Drawing.Size(187, 147);
            this.InventoryListBox.TabIndex = 7;
            this.InventoryListBox.SelectedIndexChanged += new System.EventHandler(this.InventoryListBox_SelectedIndexChanged);
            // 
            // ItemsLabel
            // 
            this.ItemsLabel.AutoSize = true;
            this.ItemsLabel.Location = new System.Drawing.Point(590, 2);
            this.ItemsLabel.Name = "ItemsLabel";
            this.ItemsLabel.Size = new System.Drawing.Size(58, 13);
            this.ItemsLabel.TabIndex = 5;
            this.ItemsLabel.Text = "ItemsLabel";
            // 
            // ItemsPicture
            // 
            this.ItemsPicture.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ItemsPicture.Location = new System.Drawing.Point(395, 5);
            this.ItemsPicture.Name = "ItemsPicture";
            this.ItemsPicture.Size = new System.Drawing.Size(187, 151);
            this.ItemsPicture.TabIndex = 4;
            this.ItemsPicture.TabStop = false;
            // 
            // PersonPicture
            // 
            this.PersonPicture.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PersonPicture.Location = new System.Drawing.Point(5, 5);
            this.PersonPicture.Name = "PersonPicture";
            this.PersonPicture.Size = new System.Drawing.Size(187, 151);
            this.PersonPicture.TabIndex = 0;
            this.PersonPicture.TabStop = false;
            // 
            // PetsPicture
            // 
            this.PetsPicture.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PetsPicture.Location = new System.Drawing.Point(5, 164);
            this.PetsPicture.Name = "PetsPicture";
            this.PetsPicture.Size = new System.Drawing.Size(187, 152);
            this.PetsPicture.TabIndex = 1;
            this.PetsPicture.TabStop = false;
            // 
            // PersonLabel
            // 
            this.PersonLabel.AutoSize = true;
            this.PersonLabel.Location = new System.Drawing.Point(200, 2);
            this.PersonLabel.Name = "PersonLabel";
            this.PersonLabel.Size = new System.Drawing.Size(66, 13);
            this.PersonLabel.TabIndex = 2;
            this.PersonLabel.Text = "PersonLabel";
            // 
            // PetsLabel
            // 
            this.PetsLabel.AutoSize = true;
            this.PetsLabel.Location = new System.Drawing.Point(200, 161);
            this.PetsLabel.Name = "PetsLabel";
            this.PetsLabel.Size = new System.Drawing.Size(54, 13);
            this.PetsLabel.TabIndex = 3;
            this.PetsLabel.Text = "PetsLabel";
            // 
            // QuestsContainer
            // 
            this.QuestsContainer.Location = new System.Drawing.Point(590, 164);
            this.QuestsContainer.Name = "QuestsContainer";
            this.QuestsContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // QuestsContainer.Panel1
            // 
            this.QuestsContainer.Panel1.Controls.Add(this.QuestsListBox);
            // 
            // QuestsContainer.Panel2
            // 
            this.QuestsContainer.Panel2.Controls.Add(this.QuestsLabel);
            this.QuestsContainer.Size = new System.Drawing.Size(187, 152);
            this.QuestsContainer.SplitterDistance = 25;
            this.QuestsContainer.TabIndex = 8;
            // 
            // QuestsListBox
            // 
            this.QuestsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.QuestsListBox.FormattingEnabled = true;
            this.QuestsListBox.Location = new System.Drawing.Point(3, 4);
            this.QuestsListBox.Name = "QuestsListBox";
            this.QuestsListBox.Size = new System.Drawing.Size(181, 17);
            this.QuestsListBox.TabIndex = 1;
            // 
            // QuestsLabel
            // 
            this.QuestsLabel.AutoSize = true;
            this.QuestsLabel.Location = new System.Drawing.Point(3, 0);
            this.QuestsLabel.Name = "QuestsLabel";
            this.QuestsLabel.Size = new System.Drawing.Size(50, 13);
            this.QuestsLabel.TabIndex = 4;
            this.QuestsLabel.Text = "Задания";
            // 
            // InventoryForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(783, 322);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Location = new System.Drawing.Point(400, 380);
            this.MinimumSize = new System.Drawing.Size(799, 361);
            this.Name = "InventoryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "InventoryForm";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ItemsPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PersonPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PetsPicture)).EndInit();
            this.QuestsContainer.Panel1.ResumeLayout(false);
            this.QuestsContainer.Panel2.ResumeLayout(false);
            this.QuestsContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QuestsContainer)).EndInit();
            this.QuestsContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label ItemsLabel;
        private System.Windows.Forms.PictureBox ItemsPicture;
        private System.Windows.Forms.PictureBox PersonPicture;
        private System.Windows.Forms.PictureBox PetsPicture;
        private System.Windows.Forms.Label PersonLabel;
        private System.Windows.Forms.Label PetsLabel;
        private System.Windows.Forms.ListBox InventoryListBox;
        private System.Windows.Forms.SplitContainer QuestsContainer;
        private System.Windows.Forms.ListBox QuestsListBox;
        private System.Windows.Forms.Label QuestsLabel;
    }
}