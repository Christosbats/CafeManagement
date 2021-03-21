
namespace CafeManagement
{
    partial class AppMenu
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.OrdersButton = new System.Windows.Forms.Button();
            this.LogoutButton = new System.Windows.Forms.Button();
            this.RemoveItemsButton = new System.Windows.Forms.Button();
            this.UpdateItemsButton = new System.Windows.Forms.Button();
            this.AddItemsButton = new System.Windows.Forms.Button();
            this.PlaceOrderButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.addItemsUC1 = new CafeManagement.UserCommands.AddItemsUC();
            this.ordersUC1 = new CafeManagement.UserCommands.OrdersUC();
            this.removeItemsUC1 = new CafeManagement.UserCommands.RemoveItemsUC();
            this.updateItemsUC1 = new CafeManagement.UserCommands.UpdateItemsUC();
            this.placeOrderUC1 = new CafeManagement.UserCommands.PlaceOrderUC();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.OrdersButton);
            this.panel1.Controls.Add(this.LogoutButton);
            this.panel1.Controls.Add(this.RemoveItemsButton);
            this.panel1.Controls.Add(this.UpdateItemsButton);
            this.panel1.Controls.Add(this.AddItemsButton);
            this.panel1.Controls.Add(this.PlaceOrderButton);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 515);
            this.panel1.TabIndex = 0;
            // 
            // OrdersButton
            // 
            this.OrdersButton.BackColor = System.Drawing.SystemColors.HotTrack;
            this.OrdersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OrdersButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.OrdersButton.Location = new System.Drawing.Point(0, 67);
            this.OrdersButton.Name = "OrdersButton";
            this.OrdersButton.Size = new System.Drawing.Size(200, 58);
            this.OrdersButton.TabIndex = 12;
            this.OrdersButton.Text = "Orders";
            this.OrdersButton.UseVisualStyleBackColor = false;
            this.OrdersButton.Click += new System.EventHandler(this.OrdersButton_Click);
            // 
            // LogoutButton
            // 
            this.LogoutButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.LogoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogoutButton.Location = new System.Drawing.Point(56, 480);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(75, 32);
            this.LogoutButton.TabIndex = 11;
            this.LogoutButton.Text = "Logout";
            this.LogoutButton.UseVisualStyleBackColor = false;
            this.LogoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // RemoveItemsButton
            // 
            this.RemoveItemsButton.BackColor = System.Drawing.SystemColors.HotTrack;
            this.RemoveItemsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveItemsButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.RemoveItemsButton.Location = new System.Drawing.Point(0, 259);
            this.RemoveItemsButton.Name = "RemoveItemsButton";
            this.RemoveItemsButton.Size = new System.Drawing.Size(200, 58);
            this.RemoveItemsButton.TabIndex = 10;
            this.RemoveItemsButton.Text = "Remove Items";
            this.RemoveItemsButton.UseVisualStyleBackColor = false;
            this.RemoveItemsButton.Click += new System.EventHandler(this.RemoveItemsButton_Click);
            // 
            // UpdateItemsButton
            // 
            this.UpdateItemsButton.BackColor = System.Drawing.SystemColors.HotTrack;
            this.UpdateItemsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateItemsButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateItemsButton.Location = new System.Drawing.Point(0, 195);
            this.UpdateItemsButton.Name = "UpdateItemsButton";
            this.UpdateItemsButton.Size = new System.Drawing.Size(200, 58);
            this.UpdateItemsButton.TabIndex = 9;
            this.UpdateItemsButton.Text = "Update Items";
            this.UpdateItemsButton.UseVisualStyleBackColor = false;
            this.UpdateItemsButton.Click += new System.EventHandler(this.UpdateItemsButton_Click);
            // 
            // AddItemsButton
            // 
            this.AddItemsButton.BackColor = System.Drawing.SystemColors.HotTrack;
            this.AddItemsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddItemsButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.AddItemsButton.Location = new System.Drawing.Point(0, 131);
            this.AddItemsButton.Name = "AddItemsButton";
            this.AddItemsButton.Size = new System.Drawing.Size(200, 58);
            this.AddItemsButton.TabIndex = 8;
            this.AddItemsButton.Text = "Add Items";
            this.AddItemsButton.UseVisualStyleBackColor = false;
            this.AddItemsButton.Click += new System.EventHandler(this.AddItemsButton_Click);
            // 
            // PlaceOrderButton
            // 
            this.PlaceOrderButton.BackColor = System.Drawing.SystemColors.HotTrack;
            this.PlaceOrderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PlaceOrderButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.PlaceOrderButton.Location = new System.Drawing.Point(0, 3);
            this.PlaceOrderButton.Name = "PlaceOrderButton";
            this.PlaceOrderButton.Size = new System.Drawing.Size(200, 58);
            this.PlaceOrderButton.TabIndex = 7;
            this.PlaceOrderButton.Text = "Place Order";
            this.PlaceOrderButton.UseVisualStyleBackColor = false;
            this.PlaceOrderButton.Click += new System.EventHandler(this.PlaceOrderButton_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel2.Controls.Add(this.addItemsUC1);
            this.panel2.Controls.Add(this.ordersUC1);
            this.panel2.Controls.Add(this.removeItemsUC1);
            this.panel2.Controls.Add(this.updateItemsUC1);
            this.panel2.Controls.Add(this.placeOrderUC1);
            this.panel2.Location = new System.Drawing.Point(218, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1072, 515);
            this.panel2.TabIndex = 1;
            // 
            // addItemsUC1
            // 
            this.addItemsUC1.Location = new System.Drawing.Point(0, 0);
            this.addItemsUC1.Name = "addItemsUC1";
            this.addItemsUC1.Size = new System.Drawing.Size(1072, 515);
            this.addItemsUC1.TabIndex = 5;
            // 
            // ordersUC1
            // 
            this.ordersUC1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ordersUC1.Location = new System.Drawing.Point(0, 0);
            this.ordersUC1.Name = "ordersUC1";
            this.ordersUC1.Size = new System.Drawing.Size(1072, 515);
            this.ordersUC1.TabIndex = 4;
            // 
            // removeItemsUC1
            // 
            this.removeItemsUC1.Location = new System.Drawing.Point(0, 0);
            this.removeItemsUC1.Name = "removeItemsUC1";
            this.removeItemsUC1.Size = new System.Drawing.Size(1072, 515);
            this.removeItemsUC1.TabIndex = 3;
            // 
            // updateItemsUC1
            // 
            this.updateItemsUC1.Location = new System.Drawing.Point(0, 0);
            this.updateItemsUC1.Name = "updateItemsUC1";
            this.updateItemsUC1.Size = new System.Drawing.Size(1072, 515);
            this.updateItemsUC1.TabIndex = 2;
            // 
            // placeOrderUC1
            // 
            this.placeOrderUC1.Location = new System.Drawing.Point(0, 0);
            this.placeOrderUC1.Name = "placeOrderUC1";
            this.placeOrderUC1.Size = new System.Drawing.Size(1072, 515);
            this.placeOrderUC1.TabIndex = 1;
            // 
            // AppMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1302, 539);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "AppMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AppMenu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AppMenu_FormClosing);
            this.Load += new System.EventHandler(this.AppMenu_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button UpdateItemsButton;
        private System.Windows.Forms.Button AddItemsButton;
        private System.Windows.Forms.Button PlaceOrderButton;
        private System.Windows.Forms.Button RemoveItemsButton;
        private System.Windows.Forms.Button LogoutButton;
        private UserCommands.PlaceOrderUC placeOrderUC1;
        private UserCommands.UpdateItemsUC updateItemsUC1;
        private UserCommands.RemoveItemsUC removeItemsUC1;
        private System.Windows.Forms.Button OrdersButton;
        private UserCommands.OrdersUC ordersUC1;
        private UserCommands.AddItemsUC addItemsUC1;
    }
}