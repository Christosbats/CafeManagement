using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeManagement
{
    public partial class AppMenu : Form
    {
        DBclass db = new DBclass();
        String query;
        public AppMenu()
        {
            InitializeComponent();
        }
        public AppMenu(String user)
        {
            InitializeComponent();
            //Any other user than admin has less permissions
            if(user == "Waiter")
            {
                AddItemsButton.Hide();
                UpdateItemsButton.Hide();
                RemoveItemsButton.Hide();
            }
        }
        private void AppMenu_Load(object sender, EventArgs e)
        {
            addItemsUC1.Hide();
            updateItemsUC1.Hide();
            removeItemsUC1.Hide();
            ordersUC1.Hide();
            placeOrderUC1.BringToFront();

        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            Form1 fm1 = new Form1();
            this.Hide();
            fm1.Show();
            query = "Delete from SingleOrder; Delete from TotalOrders";
            db.setData(query);
        }

        private void PlaceOrderButton_Click(object sender, EventArgs e)
        {
            placeOrderUC1.Show();
            placeOrderUC1.BringToFront();
        }

        private void OrdersButton_Click(object sender, EventArgs e)
        {
            ordersUC1.Show();
            ordersUC1.BringToFront();
            ordersUC1.Select();
        }

        private void AddItemsButton_Click(object sender, EventArgs e)
        {
            addItemsUC1.Show();
            addItemsUC1.BringToFront();
        }

        private void UpdateItemsButton_Click(object sender, EventArgs e)
        {
            updateItemsUC1.Show();
            updateItemsUC1.BringToFront();
            updateItemsUC1.Select();
        }

        private void RemoveItemsButton_Click(object sender, EventArgs e)
        {
            removeItemsUC1.Show();
            removeItemsUC1.BringToFront();
            removeItemsUC1.Select();
        }

        private void AppMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            query = "Delete from SingleOrder; Delete from TotalOrders";
            db.setData(query);
            Application.Exit();
        }
    }
}
