
namespace CafeManagement.UserCommands
{
    partial class UpdateItemsUC
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
            this.UpdateItemsLb = new System.Windows.Forms.Label();
            this.CategoryLb = new System.Windows.Forms.Label();
            this.ItemLb = new System.Windows.Forms.Label();
            this.PriceLb = new System.Windows.Forms.Label();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.PriceTB = new System.Windows.Forms.TextBox();
            this.CategoryTB = new System.Windows.Forms.TextBox();
            this.ItemTxtLb = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // UpdateItemsLb
            // 
            this.UpdateItemsLb.AutoSize = true;
            this.UpdateItemsLb.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.UpdateItemsLb.Location = new System.Drawing.Point(426, 19);
            this.UpdateItemsLb.Name = "UpdateItemsLb";
            this.UpdateItemsLb.Size = new System.Drawing.Size(206, 40);
            this.UpdateItemsLb.TabIndex = 6;
            this.UpdateItemsLb.Text = "Update Items";
            // 
            // CategoryLb
            // 
            this.CategoryLb.AutoSize = true;
            this.CategoryLb.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.CategoryLb.Location = new System.Drawing.Point(200, 433);
            this.CategoryLb.Name = "CategoryLb";
            this.CategoryLb.Size = new System.Drawing.Size(99, 29);
            this.CategoryLb.TabIndex = 10;
            this.CategoryLb.Text = "Category";
            // 
            // ItemLb
            // 
            this.ItemLb.AutoSize = true;
            this.ItemLb.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.ItemLb.Location = new System.Drawing.Point(200, 370);
            this.ItemLb.Name = "ItemLb";
            this.ItemLb.Size = new System.Drawing.Size(60, 29);
            this.ItemLb.TabIndex = 25;
            this.ItemLb.Text = "Item";
            // 
            // PriceLb
            // 
            this.PriceLb.AutoSize = true;
            this.PriceLb.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.PriceLb.Location = new System.Drawing.Point(559, 370);
            this.PriceLb.Name = "PriceLb";
            this.PriceLb.Size = new System.Drawing.Size(61, 29);
            this.PriceLb.TabIndex = 27;
            this.PriceLb.Text = "Price";
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.SearchTextBox.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.SearchTextBox.Location = new System.Drawing.Point(95, 86);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(133, 27);
            this.SearchTextBox.TabIndex = 30;
            this.SearchTextBox.Text = "Search Item";
            this.SearchTextBox.TextChanged += new System.EventHandler(this.SearchTextBox_TextChanged);
            this.SearchTextBox.Enter += new System.EventHandler(this.SearchTextBox_Enter);
            this.SearchTextBox.Leave += new System.EventHandler(this.SearchTextBox_Leave);
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.UpdateBtn.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F);
            this.UpdateBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.UpdateBtn.Location = new System.Drawing.Point(730, 448);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(157, 40);
            this.UpdateBtn.TabIndex = 31;
            this.UpdateBtn.Text = "Update";
            this.UpdateBtn.UseVisualStyleBackColor = false;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeight = 25;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(95, 119);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(873, 248);
            this.dataGridView1.TabIndex = 32;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridView1_DataBindingComplete);
            // 
            // PriceTB
            // 
            this.PriceTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.PriceTB.Location = new System.Drawing.Point(564, 402);
            this.PriceTB.Name = "PriceTB";
            this.PriceTB.Size = new System.Drawing.Size(203, 27);
            this.PriceTB.TabIndex = 35;
            this.PriceTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PriceTB_KeyPress);
            // 
            // CategoryTB
            // 
            this.CategoryTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.CategoryTB.Location = new System.Drawing.Point(205, 465);
            this.CategoryTB.Name = "CategoryTB";
            this.CategoryTB.Size = new System.Drawing.Size(203, 27);
            this.CategoryTB.TabIndex = 37;
            // 
            // ItemTxtLb
            // 
            this.ItemTxtLb.AutoSize = true;
            this.ItemTxtLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.ItemTxtLb.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.ItemTxtLb.Location = new System.Drawing.Point(200, 398);
            this.ItemTxtLb.Name = "ItemTxtLb";
            this.ItemTxtLb.Size = new System.Drawing.Size(86, 29);
            this.ItemTxtLb.TabIndex = 38;
            this.ItemTxtLb.Text = "Label1";
            // 
            // UpdateItemsUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ItemTxtLb);
            this.Controls.Add(this.CategoryTB);
            this.Controls.Add(this.PriceTB);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.PriceLb);
            this.Controls.Add(this.ItemLb);
            this.Controls.Add(this.CategoryLb);
            this.Controls.Add(this.UpdateItemsLb);
            this.Name = "UpdateItemsUC";
            this.Size = new System.Drawing.Size(1072, 515);
            this.Load += new System.EventHandler(this.UpdateItemsUC_Load);
            this.Enter += new System.EventHandler(this.UpdateItemsUC_Enter);
            this.Leave += new System.EventHandler(this.UpdateItemsUC_Leave);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UpdateItemsLb;
        private System.Windows.Forms.Label CategoryLb;
        private System.Windows.Forms.Label ItemLb;
        private System.Windows.Forms.Label PriceLb;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox PriceTB;
        private System.Windows.Forms.TextBox CategoryTB;
        private System.Windows.Forms.Label ItemTxtLb;
    }
}
