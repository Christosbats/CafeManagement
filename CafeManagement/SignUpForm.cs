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
    //Each new account you create is registered into the database
    public partial class SignUpForm : Form
    {
        DBclass db = new DBclass();
        String query;
        public SignUpForm()
        {
            InitializeComponent();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            Form1 fm1 = new Form1();
            this.Hide();
            fm1.Show();
        }

        private void signUpBtn_Click(object sender, EventArgs e)
        {
            String querycheck = "select username from accounts";
            DataSet ds = db.getData(querycheck);
            bool check = false;
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                if (ds.Tables[0].Rows[i][0].ToString() == usernameTxt.Text)
                {
                    MessageBox.Show("This username exists already", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    check = true;
                    break;
                }
            }
            if (check == false)
            {
                query = "insert into accounts (username,password) values('" + usernameTxt.Text + "','" + passwordTxt.Text + "')";
                if (usernameTxt.Text == "" || passwordTxt.Text == "")
                {
                    MessageBox.Show("Add more data", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    db.setData(query);
                    MessageBox.Show("Data Processed Succesfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            clear();
        }
        public void clear()
        {
            usernameTxt.Clear();
            passwordTxt.Clear();
        }

        private void SignUpForm_Load(object sender, EventArgs e)
        {

        }
    }
}
