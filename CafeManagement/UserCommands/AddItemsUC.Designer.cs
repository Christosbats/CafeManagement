
namespace CafeManagement.UserCommands
{
    partial class AddItemsUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.AddNewItemLb = new System.Windows.Forms.Label();
            this.AddBtn = new System.Windows.Forms.Button();
            this.ItemLb = new System.Windows.Forms.Label();
            this.CategoryLb = new System.Windows.Forms.Label();
            this.PriceLb = new System.Windows.Forms.Label();
            this.CategoryBox = new System.Windows.Forms.ComboBox();
            this.ItemTextBox = new System.Windows.Forms.TextBox();
            this.PriceTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // AddNewItemLb
            // 
            this.AddNewItemLb.AutoSize = true;
            this.AddNewItemLb.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.AddNewItemLb.Location = new System.Drawing.Point(442, 14);
            this.AddNewItemLb.Name = "AddNewItemLb";
            this.AddNewItemLb.Size = new System.Drawing.Size(217, 40);
            this.AddNewItemLb.TabIndex = 0;
            this.AddNewItemLb.Text = "Add New Item";
            // 
            // AddBtn
            // 
            this.AddBtn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.AddBtn.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F);
            this.AddBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AddBtn.Location = new System.Drawing.Point(481, 399);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(157, 40);
            this.AddBtn.TabIndex = 1;
            this.AddBtn.Text = "Add";
            this.AddBtn.UseVisualStyleBackColor = false;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // ItemLb
            // 
            this.ItemLb.AutoSize = true;
            this.ItemLb.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.ItemLb.Location = new System.Drawing.Point(396, 222);
            this.ItemLb.Name = "ItemLb";
            this.ItemLb.Size = new System.Drawing.Size(60, 29);
            this.ItemLb.TabIndex = 3;
            this.ItemLb.Text = "Item";
            // 
            // CategoryLb
            // 
            this.CategoryLb.AutoSize = true;
            this.CategoryLb.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.CategoryLb.Location = new System.Drawing.Point(357, 135);
            this.CategoryLb.Name = "CategoryLb";
            this.CategoryLb.Size = new System.Drawing.Size(99, 29);
            this.CategoryLb.TabIndex = 4;
            this.CategoryLb.Text = "Category";
            // 
            // PriceLb
            // 
            this.PriceLb.AutoSize = true;
            this.PriceLb.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.PriceLb.Location = new System.Drawing.Point(395, 297);
            this.PriceLb.Name = "PriceLb";
            this.PriceLb.Size = new System.Drawing.Size(61, 29);
            this.PriceLb.TabIndex = 5;
            this.PriceLb.Text = "Price";
            // 
            // CategoryBox
            // 
            this.CategoryBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.CategoryBox.FormattingEnabled = true;
            this.CategoryBox.Location = new System.Drawing.Point(462, 139);
            this.CategoryBox.Name = "CategoryBox";
            this.CategoryBox.Size = new System.Drawing.Size(255, 28);
            this.CategoryBox.TabIndex = 6;
            // 
            // ItemTextBox
            // 
            this.ItemTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.ItemTextBox.Location = new System.Drawing.Point(462, 226);
            this.ItemTextBox.Name = "ItemTextBox";
            this.ItemTextBox.Size = new System.Drawing.Size(255, 27);
            this.ItemTextBox.TabIndex = 7;
            // 
            // PriceTextBox
            // 
            this.PriceTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.PriceTextBox.Location = new System.Drawing.Point(462, 301);
            this.PriceTextBox.Name = "PriceTextBox";
            this.PriceTextBox.Size = new System.Drawing.Size(255, 27);
            this.PriceTextBox.TabIndex = 8;
            this.PriceTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PriceTextBox_KeyPress);
            // 
            // AddItemsUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PriceTextBox);
            this.Controls.Add(this.ItemTextBox);
            this.Controls.Add(this.CategoryBox);
            this.Controls.Add(this.PriceLb);
            this.Controls.Add(this.CategoryLb);
            this.Controls.Add(this.ItemLb);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.AddNewItemLb);
            this.Name = "AddItemsUC";
            this.Size = new System.Drawing.Size(1072, 515);
            this.Load += new System.EventHandler(this.AddItemsUC_Load);
            this.Leave += new System.EventHandler(this.AddItemsUC_Leave);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AddNewItemLb;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Label ItemLb;
        private System.Windows.Forms.Label CategoryLb;
        private System.Windows.Forms.Label PriceLb;
        private System.Windows.Forms.ComboBox CategoryBox;
        private System.Windows.Forms.TextBox ItemTextBox;
        private System.Windows.Forms.TextBox PriceTextBox;
    }
}
