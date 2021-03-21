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
    public partial class UpdateItemsUC : UserControl
    {
        DBclass db = new DBclass();
        String query;

        public UpdateItemsUC()
        {
            InitializeComponent();
            

        }
        private void UpdateItemsUC_Load(object sender, EventArgs e)
        {
            
            loadData();
            ItemTxtLb.Text = "";
            PriceTB.Hide();
            CategoryTB.Hide();

        }

        public void loadData(String query = "select * from items")
        {
            
            DataSet ds = db.getData(query);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void SearchTextBox_Enter(object sender, EventArgs e)
        {
            
            if (SearchTextBox.Text == "Search Item")
            {
                SearchTextBox.Text = "";
                SearchTextBox.ForeColor = Color.Black;
            }
        }

        private void SearchTextBox_Leave(object sender, EventArgs e)
        {
            if (SearchTextBox.Text == "")
            {
                SearchTextBox.Text = "Search Item";
                SearchTextBox.ForeColor = Color.Silver;
            }
        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            String searchtext = SearchTextBox.Text;
            if (searchtext != null && searchtext != "Search Item" )
            {
                query = "select * from items where (name like '% " + searchtext + "%') or (name like '" + searchtext + "%')";
            }
            loadData(query);

        }
        
        
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                String name = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                String category = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                int price = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString());

                ItemTxtLb.Text = name;
                CategoryTB.Text = category;
                PriceTB.Text = price.ToString();

                PriceTB.Show();
                CategoryTB.Show();
            }
            catch { }

        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            if(ItemTxtLb.Text == "")
            {
                MessageBox.Show("Choose an item to update", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if(CategoryTB.Text == "" || PriceTB.Text == "")
            {
                MessageBox.Show("Complete all the values", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                query = "update items set category = '" + CategoryTB.Text + "', price = '" + PriceTB.Text + "' where name = '" + ItemTxtLb.Text + "'";
                db.setData(query);
                MessageBox.Show("Data Processed Succesfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadData();

                SearchTextBox.Text = "Search Item";
                ItemTxtLb.Text = "";
                CategoryTB.Clear();
                PriceTB.Clear();
            }
            
            

        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            
            dataGridView1.ClearSelection();
        }

        private void UpdateItemsUC_Leave(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
            PriceTB.Clear();
            CategoryTB.Clear();
            ItemTxtLb.Text = "";
            PriceTB.Hide();
            CategoryTB.Hide();
        }

        private void PriceTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void UpdateItemsUC_Enter(object sender, EventArgs e)
        {
            
            loadData();
        }
    }
}
