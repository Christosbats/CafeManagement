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
    public partial class RemoveItemsUC : UserControl
    {
        DBclass db = new DBclass();
        String query;
        

        public RemoveItemsUC()
        {
            InitializeComponent();
        }

        private void RemoveItemsUC_Load(object sender, EventArgs e)
        {
            loadData();
        }

        public void loadData(String query = "select * from items")
        {

            DataSet ds = db.getData(query);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void SearchTextBox_Enter_1(object sender, EventArgs e)
        {
            if (SearchTextBox.Text == "Search Item")
            {
                SearchTextBox.Text = "";
                SearchTextBox.ForeColor = Color.Black;
            }
        }

        private void SearchTextBox_Leave_1(object sender, EventArgs e)
        {
            if (SearchTextBox.Text == "")
            {
                SearchTextBox.Text = "Search Item";
                SearchTextBox.ForeColor = Color.Silver;
            }
        }

        String name;
        String category;
        int price;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                
                name = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                category = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                price = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString());
            }
            catch { }
        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            String searchtext = SearchTextBox.Text;
            if (searchtext != null && searchtext != "Search Item")
            {
                query = "select * from items where (name like '% " + searchtext + "%') or (name like '" + searchtext + "%')";
            }
            loadData(query);
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {   if (dataGridView1.SelectedRows.Count == 1)
            {
                query = "delete from items where name = '" + name + "'";
                db.setData(query);
                MessageBox.Show("Data Processed Succesfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadData();

                SearchTextBox.Text = "Search Item";
                
            }
            else
            {
                MessageBox.Show("No item is selected", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridView1.ClearSelection();
        }

        private void RemoveItemsUC_Leave(object sender, EventArgs e)
        {
            
            dataGridView1.ClearSelection();

        }

        private void RemoveItemsUC_Enter(object sender, EventArgs e)
        {
            loadData();
        }
    }
}
