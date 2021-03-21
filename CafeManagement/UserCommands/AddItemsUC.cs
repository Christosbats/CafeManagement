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
    public partial class AddItemsUC : UserControl
    {
        DBclass db = new DBclass();
        String query;
        public AddItemsUC()
        {
            InitializeComponent();
        }
        private void AddItemsUC_Load(object sender, EventArgs e)
        {
            

            query = "select distinct category from items";
            DataSet ds = db.getData(query);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                CategoryBox.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }

            CategoryBox.SelectedIndex = -1;
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            String querycheck = "select name from items";
            DataSet ds = db.getData(querycheck);
            bool check = false;
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                if (ds.Tables[0].Rows[i][0].ToString() == ItemTextBox.Text)
                {
                    MessageBox.Show("This item exists already", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    check = true;
                    break;
                }
            }

            if (check == false)
            {
                query = "insert into items (name,category,price) values('" + ItemTextBox.Text + "','" + CategoryBox.Text + "','" + PriceTextBox.Text + "')";
                if (ItemTextBox.Text == "" || PriceTextBox.Text == "" || CategoryBox.Text == "")
                {
                    MessageBox.Show("Add more data", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    db.setData(query);
                    MessageBox.Show("Data Processed Succesfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (!CategoryBox.Items.Contains(CategoryBox.Text))
                    {
                        CategoryBox.Items.Add(CategoryBox.Text);
                    }
                    
                }
            }

            clear();
        }
        public void clear()
        {
            ItemTextBox.Clear();
            PriceTextBox.Clear();
            CategoryBox.Text = "";
        }

        private void AddItemsUC_Leave(object sender, EventArgs e)
        {
            clear();
        }

        private void PriceTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
