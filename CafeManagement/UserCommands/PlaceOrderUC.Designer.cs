
namespace CafeManagement.UserCommands
{
    partial class PlaceOrderUC
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
            this.CategoryBox = new System.Windows.Forms.ComboBox();
            this.PlaceOrderLb = new System.Windows.Forms.Label();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.CategoryLb = new System.Windows.Forms.Label();
            this.ItemLb = new System.Windows.Forms.Label();
            this.UnitPriceLb = new System.Windows.Forms.Label();
            this.TotalPriceLb = new System.Windows.Forms.Label();
            this.QuantityLb = new System.Windows.Forms.Label();
            this.QuantityUpDown = new System.Windows.Forms.NumericUpDown();
            this.AddBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RemoveBtn = new System.Windows.Forms.Button();
            this.SubmitOrderBtn = new System.Windows.Forms.Button();
            this.TotalCostLb = new System.Windows.Forms.Label();
            this.ValueLb = new System.Windows.Forms.Label();
            this.listBox = new System.Windows.Forms.ListBox();
            this.ItemTxtLb = new System.Windows.Forms.Label();
            this.UnitPriceTxtLb = new System.Windows.Forms.Label();
            this.TotalPriceTxtLb = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.QuantityUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // CategoryBox
            // 
            this.CategoryBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.CategoryBox.FormattingEnabled = true;
            this.CategoryBox.Location = new System.Drawing.Point(3, 125);
            this.CategoryBox.Name = "CategoryBox";
            this.CategoryBox.Size = new System.Drawing.Size(133, 28);
            this.CategoryBox.TabIndex = 3;
            this.CategoryBox.SelectedIndexChanged += new System.EventHandler(this.CategoryBox_SelectedIndexChanged);
            // 
            // PlaceOrderLb
            // 
            this.PlaceOrderLb.AutoSize = true;
            this.PlaceOrderLb.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.PlaceOrderLb.Location = new System.Drawing.Point(486, 19);
            this.PlaceOrderLb.Name = "PlaceOrderLb";
            this.PlaceOrderLb.Size = new System.Drawing.Size(178, 40);
            this.PlaceOrderLb.TabIndex = 5;
            this.PlaceOrderLb.Text = "Place Order";
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.SearchTextBox.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.SearchTextBox.Location = new System.Drawing.Point(3, 159);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(133, 27);
            this.SearchTextBox.TabIndex = 6;
            this.SearchTextBox.Text = "Search";
            this.SearchTextBox.TextChanged += new System.EventHandler(this.SearchTextBox_TextChanged);
            this.SearchTextBox.Enter += new System.EventHandler(this.SearchTextBox_Enter);
            this.SearchTextBox.Leave += new System.EventHandler(this.SearchTextBox_Leave);
            // 
            // CategoryLb
            // 
            this.CategoryLb.AutoSize = true;
            this.CategoryLb.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.CategoryLb.Location = new System.Drawing.Point(3, 93);
            this.CategoryLb.Name = "CategoryLb";
            this.CategoryLb.Size = new System.Drawing.Size(99, 29);
            this.CategoryLb.TabIndex = 7;
            this.CategoryLb.Text = "Category";
            // 
            // ItemLb
            // 
            this.ItemLb.AutoSize = true;
            this.ItemLb.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.ItemLb.Location = new System.Drawing.Point(291, 93);
            this.ItemLb.Name = "ItemLb";
            this.ItemLb.Size = new System.Drawing.Size(60, 29);
            this.ItemLb.TabIndex = 8;
            this.ItemLb.Text = "Item";
            // 
            // UnitPriceLb
            // 
            this.UnitPriceLb.AutoSize = true;
            this.UnitPriceLb.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.UnitPriceLb.Location = new System.Drawing.Point(291, 192);
            this.UnitPriceLb.Name = "UnitPriceLb";
            this.UnitPriceLb.Size = new System.Drawing.Size(110, 29);
            this.UnitPriceLb.TabIndex = 9;
            this.UnitPriceLb.Text = "Unit Price";
            // 
            // TotalPriceLb
            // 
            this.TotalPriceLb.AutoSize = true;
            this.TotalPriceLb.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.TotalPriceLb.Location = new System.Drawing.Point(728, 192);
            this.TotalPriceLb.Name = "TotalPriceLb";
            this.TotalPriceLb.Size = new System.Drawing.Size(120, 29);
            this.TotalPriceLb.TabIndex = 10;
            this.TotalPriceLb.Text = "Total Price";
            // 
            // QuantityLb
            // 
            this.QuantityLb.AutoSize = true;
            this.QuantityLb.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.QuantityLb.Location = new System.Drawing.Point(728, 93);
            this.QuantityLb.Name = "QuantityLb";
            this.QuantityLb.Size = new System.Drawing.Size(97, 29);
            this.QuantityLb.TabIndex = 11;
            this.QuantityLb.Text = "Quantity";
            // 
            // QuantityUpDown
            // 
            this.QuantityUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.QuantityUpDown.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.QuantityUpDown.Location = new System.Drawing.Point(733, 125);
            this.QuantityUpDown.Name = "QuantityUpDown";
            this.QuantityUpDown.Size = new System.Drawing.Size(157, 34);
            this.QuantityUpDown.TabIndex = 15;
            this.QuantityUpDown.ValueChanged += new System.EventHandler(this.QuantityUpDown_ValueChanged);
            // 
            // AddBtn
            // 
            this.AddBtn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.AddBtn.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.AddBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AddBtn.Location = new System.Drawing.Point(507, 284);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(157, 40);
            this.AddBtn.TabIndex = 16;
            this.AddBtn.Text = "Add";
            this.AddBtn.UseVisualStyleBackColor = false;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridView1.Location = new System.Drawing.Point(227, 338);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(671, 116);
            this.dataGridView1.TabIndex = 17;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Item";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Unit Price";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Quantity";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Total Price";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Order ID";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            // 
            // RemoveBtn
            // 
            this.RemoveBtn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.RemoveBtn.Font = new System.Drawing.Font("Segoe UI Emoji", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.RemoveBtn.Location = new System.Drawing.Point(227, 460);
            this.RemoveBtn.Name = "RemoveBtn";
            this.RemoveBtn.Size = new System.Drawing.Size(157, 40);
            this.RemoveBtn.TabIndex = 18;
            this.RemoveBtn.Text = "Remove Item";
            this.RemoveBtn.UseVisualStyleBackColor = false;
            this.RemoveBtn.Click += new System.EventHandler(this.RemoveBtn_Click);
            // 
            // SubmitOrderBtn
            // 
            this.SubmitOrderBtn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.SubmitOrderBtn.Font = new System.Drawing.Font("Segoe UI Emoji", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubmitOrderBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SubmitOrderBtn.Location = new System.Drawing.Point(807, 460);
            this.SubmitOrderBtn.Name = "SubmitOrderBtn";
            this.SubmitOrderBtn.Size = new System.Drawing.Size(157, 40);
            this.SubmitOrderBtn.TabIndex = 19;
            this.SubmitOrderBtn.Text = "Submit Order";
            this.SubmitOrderBtn.UseVisualStyleBackColor = false;
            this.SubmitOrderBtn.Click += new System.EventHandler(this.SubmitOrderBtn_Click);
            // 
            // TotalCostLb
            // 
            this.TotalCostLb.AutoSize = true;
            this.TotalCostLb.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.TotalCostLb.Location = new System.Drawing.Point(488, 471);
            this.TotalCostLb.Name = "TotalCostLb";
            this.TotalCostLb.Size = new System.Drawing.Size(114, 29);
            this.TotalCostLb.TabIndex = 20;
            this.TotalCostLb.Text = "Total Cost";
            // 
            // ValueLb
            // 
            this.ValueLb.BackColor = System.Drawing.Color.LightGreen;
            this.ValueLb.Font = new System.Drawing.Font("Constantia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ValueLb.Location = new System.Drawing.Point(608, 472);
            this.ValueLb.Name = "ValueLb";
            this.ValueLb.Size = new System.Drawing.Size(100, 32);
            this.ValueLb.TabIndex = 21;
            this.ValueLb.Text = "0€";
            this.ValueLb.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // listBox
            // 
            this.listBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 20;
            this.listBox.Location = new System.Drawing.Point(3, 192);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(133, 304);
            this.listBox.TabIndex = 22;
            this.listBox.SelectedIndexChanged += new System.EventHandler(this.listBox_SelectedIndexChanged);
            // 
            // ItemTxtLb
            // 
            this.ItemTxtLb.AutoSize = true;
            this.ItemTxtLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.ItemTxtLb.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.ItemTxtLb.Location = new System.Drawing.Point(291, 130);
            this.ItemTxtLb.Name = "ItemTxtLb";
            this.ItemTxtLb.Size = new System.Drawing.Size(86, 29);
            this.ItemTxtLb.TabIndex = 24;
            this.ItemTxtLb.Text = "Label1";
            // 
            // UnitPriceTxtLb
            // 
            this.UnitPriceTxtLb.AutoSize = true;
            this.UnitPriceTxtLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.UnitPriceTxtLb.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.UnitPriceTxtLb.Location = new System.Drawing.Point(291, 221);
            this.UnitPriceTxtLb.Name = "UnitPriceTxtLb";
            this.UnitPriceTxtLb.Size = new System.Drawing.Size(86, 29);
            this.UnitPriceTxtLb.TabIndex = 25;
            this.UnitPriceTxtLb.Text = "Label3";
            // 
            // TotalPriceTxtLb
            // 
            this.TotalPriceTxtLb.AutoSize = true;
            this.TotalPriceTxtLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.TotalPriceTxtLb.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.TotalPriceTxtLb.Location = new System.Drawing.Point(728, 221);
            this.TotalPriceTxtLb.Name = "TotalPriceTxtLb";
            this.TotalPriceTxtLb.Size = new System.Drawing.Size(86, 29);
            this.TotalPriceTxtLb.TabIndex = 26;
            this.TotalPriceTxtLb.Text = "Label3";
            // 
            // PlaceOrderUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TotalPriceTxtLb);
            this.Controls.Add(this.UnitPriceTxtLb);
            this.Controls.Add(this.ItemTxtLb);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.ValueLb);
            this.Controls.Add(this.TotalCostLb);
            this.Controls.Add(this.SubmitOrderBtn);
            this.Controls.Add(this.RemoveBtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.QuantityUpDown);
            this.Controls.Add(this.QuantityLb);
            this.Controls.Add(this.TotalPriceLb);
            this.Controls.Add(this.UnitPriceLb);
            this.Controls.Add(this.ItemLb);
            this.Controls.Add(this.CategoryLb);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.PlaceOrderLb);
            this.Controls.Add(this.CategoryBox);
            this.Name = "PlaceOrderUC";
            this.Size = new System.Drawing.Size(1072, 515);
            this.Load += new System.EventHandler(this.PlaceOrderUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.QuantityUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox CategoryBox;
        private System.Windows.Forms.Label PlaceOrderLb;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.Label CategoryLb;
        private System.Windows.Forms.Label ItemLb;
        private System.Windows.Forms.Label UnitPriceLb;
        private System.Windows.Forms.Label TotalPriceLb;
        private System.Windows.Forms.Label QuantityLb;
        private System.Windows.Forms.NumericUpDown QuantityUpDown;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button RemoveBtn;
        private System.Windows.Forms.Button SubmitOrderBtn;
        private System.Windows.Forms.Label TotalCostLb;
        private System.Windows.Forms.Label ValueLb;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Label ItemTxtLb;
        private System.Windows.Forms.Label UnitPriceTxtLb;
        private System.Windows.Forms.Label TotalPriceTxtLb;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}
