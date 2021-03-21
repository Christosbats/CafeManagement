
namespace CafeManagement.UserCommands
{
    partial class OrdersUC
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
            this.OrdersLb = new System.Windows.Forms.Label();
            this.OrdersIDBox = new System.Windows.Forms.ListBox();
            this.OrderIDLb = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValueLb = new System.Windows.Forms.Label();
            this.TotalCostLb = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // OrdersLb
            // 
            this.OrdersLb.AutoSize = true;
            this.OrdersLb.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.OrdersLb.Location = new System.Drawing.Point(466, 19);
            this.OrdersLb.Name = "OrdersLb";
            this.OrdersLb.Size = new System.Drawing.Size(111, 40);
            this.OrdersLb.TabIndex = 6;
            this.OrdersLb.Text = "Orders";
            // 
            // OrdersIDBox
            // 
            this.OrdersIDBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.OrdersIDBox.FormattingEnabled = true;
            this.OrdersIDBox.ItemHeight = 20;
            this.OrdersIDBox.Location = new System.Drawing.Point(3, 93);
            this.OrdersIDBox.Name = "OrdersIDBox";
            this.OrdersIDBox.Size = new System.Drawing.Size(82, 304);
            this.OrdersIDBox.TabIndex = 23;
            this.OrdersIDBox.SelectedIndexChanged += new System.EventHandler(this.OrdersIDBox_SelectedIndexChanged);
            // 
            // OrderIDLb
            // 
            this.OrderIDLb.AutoSize = true;
            this.OrderIDLb.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.OrderIDLb.Location = new System.Drawing.Point(-2, 61);
            this.OrderIDLb.Name = "OrderIDLb";
            this.OrderIDLb.Size = new System.Drawing.Size(106, 29);
            this.OrderIDLb.TabIndex = 24;
            this.OrderIDLb.Text = "Order ID";
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
            this.OrderID});
            this.dataGridView1.Enabled = false;
            this.dataGridView1.Location = new System.Drawing.Point(180, 93);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(701, 304);
            this.dataGridView1.TabIndex = 34;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Item";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Unit Price";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Quantity";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Total Price";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // OrderID
            // 
            this.OrderID.HeaderText = "Order ID";
            this.OrderID.MinimumWidth = 6;
            this.OrderID.Name = "OrderID";
            this.OrderID.ReadOnly = true;
            // 
            // ValueLb
            // 
            this.ValueLb.BackColor = System.Drawing.Color.LightGreen;
            this.ValueLb.Font = new System.Drawing.Font("Constantia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ValueLb.Location = new System.Drawing.Point(528, 411);
            this.ValueLb.Name = "ValueLb";
            this.ValueLb.Size = new System.Drawing.Size(100, 32);
            this.ValueLb.TabIndex = 36;
            this.ValueLb.Text = "0€";
            this.ValueLb.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // TotalCostLb
            // 
            this.TotalCostLb.AutoSize = true;
            this.TotalCostLb.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.TotalCostLb.Location = new System.Drawing.Point(408, 410);
            this.TotalCostLb.Name = "TotalCostLb";
            this.TotalCostLb.Size = new System.Drawing.Size(114, 29);
            this.TotalCostLb.TabIndex = 35;
            this.TotalCostLb.Text = "Total Cost";
            // 
            // OrdersUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.ValueLb);
            this.Controls.Add(this.TotalCostLb);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.OrderIDLb);
            this.Controls.Add(this.OrdersIDBox);
            this.Controls.Add(this.OrdersLb);
            this.Name = "OrdersUC";
            this.Size = new System.Drawing.Size(1072, 515);
            this.Load += new System.EventHandler(this.OrdersUC_Load);
            this.Enter += new System.EventHandler(this.OrdersUC_Enter);
            this.Leave += new System.EventHandler(this.OrdersUC_Leave);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label OrdersLb;
        private System.Windows.Forms.ListBox OrdersIDBox;
        private System.Windows.Forms.Label OrderIDLb;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderID;
        private System.Windows.Forms.Label ValueLb;
        private System.Windows.Forms.Label TotalCostLb;
    }
}
