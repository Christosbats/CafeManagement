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
    public partial class PlaceOrderUC : UserControl
    {
        DBclass db = new DBclass();
        String query;
        int totalprice;
        int orderID = 1;

        public PlaceOrderUC()
        {
            InitializeComponent();
            
        }
        private void PlaceOrderUC_Load(object sender, EventArgs e)
        {
            ItemTxtLb.Hide();
            TotalPriceTxtLb.Hide();
            TotalPriceTxtLb.Text = "";
            UnitPriceTxtLb.Hide();
            QuantityUpDown.Hide();
            


            query = "select distinct category from items";
            DataSet ds = db.getData(query);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                CategoryBox.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }


        }

        private void SearchTextBox_Enter(object sender, EventArgs e)
        {
            if(SearchTextBox.Text == "Search")
            {
                SearchTextBox.Text = "";
                SearchTextBox.ForeColor = Color.Black;
            }
        }

        private void SearchTextBox_Leave(object sender, EventArgs e)
        {
            if (SearchTextBox.Text == "")
            {
                SearchTextBox.Text = "Search";
                SearchTextBox.ForeColor = Color.Silver;
            }
        }

        private void CategoryBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            String category = CategoryBox.Text;
            query = "select name from items where category  = '" + category + "'";
            ShowItems(query);
        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            
            String category = CategoryBox.Text;
            String searchtext = SearchTextBox.Text;
            if(searchtext == "" || searchtext == "Search")
            {
                query = "select name from items where category  = '" + category + "'";
            }
            else
            {
                query = "select name from items where category  = '" + category + "' and (name like '% " + searchtext + "%') or (name like '" + searchtext + "%')";
            }
            
            ShowItems(query);

            
            
        }
        private void ShowItems(String query)
        {
            listBox.Items.Clear();

            DataSet ds = db.getData(query);

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                listBox.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }
        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            QuantityUpDown.Value = 0;
            TotalPriceTxtLb.ResetText();
            

            

            ItemTxtLb.Show();
            UnitPriceTxtLb.Show();
            String text = listBox.GetItemText(listBox.SelectedItem);
            ItemTxtLb.Text = text;
            query = "select price from items where name = '"+text+"'";

            DataSet ds = db.getData(query);

            try
            {
                UnitPriceTxtLb.Text = ds.Tables[0].Rows[0][0].ToString() + "€";
                QuantityUpDown.Show();
            }
            catch { UnitPriceTxtLb.Hide(); }
        }

        private void QuantityUpDown_ValueChanged(object sender, EventArgs e)
        {
            TotalPriceTxtLb.Show();
            int quant = Convert.ToInt32(QuantityUpDown.Value);
            String UPtxt = UnitPriceTxtLb.Text.Replace("€","");
            int quantprice = Convert.ToInt32(UPtxt);
            TotalPriceTxtLb.Text = (quantprice * quant).ToString() + "€";
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            if(QuantityUpDown.Value != 0)
            {
                bool sameItem = false;
                
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    string item = row.Cells[0].Value.ToString();
                    if (item == ItemTxtLb.Text)
                    {
                        sameItem = true;
                    }
                }


                if(sameItem == false)
                {
                    var index = dataGridView1.Rows.Add();

                    dataGridView1.Rows[index].Cells[0].Value = ItemTxtLb.Text;
                    dataGridView1.Rows[index].Cells[1].Value = UnitPriceTxtLb.Text;
                    dataGridView1.Rows[index].Cells[2].Value = QuantityUpDown.Value;
                    dataGridView1.Rows[index].Cells[3].Value = TotalPriceTxtLb.Text;
                    dataGridView1.Rows[index].Cells[4].Value = orderID;

                    dataGridView1.ClearSelection();

                    string TPtxt = TotalPriceTxtLb.Text.Replace("€", "");
                    totalprice += Convert.ToInt32(TPtxt);
                    ValueLb.Text = totalprice.ToString() + "€";

                    QuantityUpDown.Value = 0;
                    UnitPriceTxtLb.ResetText();
                    TotalPriceTxtLb.ResetText();
                    ItemTxtLb.ResetText();
                    QuantityUpDown.Hide();
                    listBox.ClearSelected();
                }
                else
                {
                    MessageBox.Show("You cant add the same item", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
            }
            else
            {
                MessageBox.Show("You cant add 0 items", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void RemoveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Object obCellPrice = dataGridView1.SelectedRows[0].Cells[3].Value;
                String strCellPrice1 = Convert.ToString(obCellPrice);
                strCellPrice1 = strCellPrice1.Replace("€", "");
                int minusprice = Convert.ToInt32(strCellPrice1);
                dataGridView1.Rows.RemoveAt(this.dataGridView1.SelectedRows[0].Index);
                
                totalprice -= minusprice;
                ValueLb.Text = totalprice.ToString() + "€";
            }
            catch { }
            
        }

        private void SubmitOrderBtn_Click(object sender, EventArgs e)
        {
            if(dataGridView1.Rows.Count <=0)
            {
                MessageBox.Show("No items submitted", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    int uplength = row.Cells[1].Value.ToString().Length;
                    String upstr = row.Cells[1].Value.ToString().Remove(uplength - 1);
                    int uprice = Convert.ToInt32(upstr);

                    int tplength = row.Cells[3].Value.ToString().Length;
                    String tpstr = row.Cells[3].Value.ToString().Remove(tplength - 1);
                    int tprice = Convert.ToInt32(upstr);


                
                    query = "insert into SingleOrder (Item,UnitPrice,Quantity,TotalPrice,ID) values('" + row.Cells[0].Value + "','" + uprice + "','" + row.Cells[2].Value + "','" + tprice + "','" + row.Cells[4].Value + "')";
                    db.setData(query);
                }
                
                query = "insert into TotalOrders (ID,TotalCost) values('" + orderID + "','" + totalprice + "')";
                db.setData(query);

                MessageBox.Show("Data Processed Succesfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView1.Rows.Clear();
                orderID += 1;
                ValueLb.Text = "0€";
            }
        }
    }
}
