using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeManagement.UserCommands
{
    public partial class OrdersUC : UserControl
    {
        DBclass db = new DBclass();
        String query1,query2;

        public OrdersUC()
        {
            InitializeComponent();
        }

        private void OrdersUC_Load(object sender, EventArgs e)
        {
            loadData();
            
        }

        public void loadData(String query = "select ID from TotalOrders")
        {
            OrdersIDBox.Items.Clear();
            DataSet ds = db.getData(query);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                OrdersIDBox.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }
        }

        private void OrdersIDBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();

            if (OrdersIDBox.SelectedItem != null)
            {
                
                String ID = OrdersIDBox.GetItemText(OrdersIDBox.SelectedItem);
                query1 = "select * from SingleOrder where ID = '" + ID + "'";
                DataSet ds = db.getData(query1);

                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    dataGridView1.Rows.Add();
                }

                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    dataGridView1.Rows[i].Cells[0].Value = ds.Tables[0].Rows[i][0].ToString();
                    dataGridView1.Rows[i].Cells[1].Value = ds.Tables[0].Rows[i][1].ToString() + "€";
                    dataGridView1.Rows[i].Cells[2].Value = ds.Tables[0].Rows[i][2].ToString();
                    dataGridView1.Rows[i].Cells[3].Value = ds.Tables[0].Rows[i][3].ToString() + "€";
                    dataGridView1.Rows[i].Cells[4].Value = ds.Tables[0].Rows[i][4].ToString();
                }
                dataGridView1.ClearSelection();

                query1 = "select TotalCost from TotalOrders where ID = '" + ID + "'";
                ds = db.getData(query1);
                ValueLb.Text = ds.Tables[0].Rows[0][0].ToString() + "€";


            }
        }

        private void OrdersUC_Enter(object sender, EventArgs e)
        {
            loadData();
        }

        private void OrdersUC_Leave(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
            OrdersIDBox.ClearSelected();
            ValueLb.Text = "0€";

        }
    }
}
