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
    public partial class Form1 : Form
    {
        DBclass db = new DBclass();
        String query;

        public Form1()
        {
            InitializeComponent();
            
        }

        private void Login_Click(object sender, EventArgs e)
        {
            AppMenu am1 = new AppMenu();
            AppMenu am2 = new AppMenu("Waiter");
            String query = "select * from accounts";
            DataSet ds = db.getData(query);
            bool userexist = false; 
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                if (ds.Tables[0].Rows[i][0].ToString() == UsernameTextBox.Text && ds.Tables[0].Rows[i][1].ToString() == PasswordTextBox.Text && UsernameTextBox.Text != "christos")
                {
                    userexist = true;
                    break;
                }
            }
            if (UsernameTextBox.Text == "admin" && PasswordTextBox.Text == "12345" && userexist == true) //set your username and password for admin user after you sing up
            {
                Login.BackColor = Color.White;
                am1.Show();
                this.Hide();
            }
            else if (userexist == true){
                Login.BackColor = Color.White;
                am2.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong Username or Password", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        

        private void UsernameTextBox_KeyDown(object sender, KeyEventArgs e)
        {
                enterLogin(e);
        }

        private void PasswordTextBox_KeyDown(object sender, KeyEventArgs e)
        {
                enterLogin(e);

        }

        private void enterLogin(KeyEventArgs e)
        {
            AppMenu am = new AppMenu();

            if (e.KeyCode == Keys.Enter)
            {
                if (UsernameTextBox.Text == "christos" && PasswordTextBox.Text == "12345")
                {
                    Login.BackColor = Color.White;
                    e.SuppressKeyPress = true;
                    am.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Wrong Username or Password", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            
        }

        private void singUpLinkLb_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUpForm suf = new SignUpForm();
            suf.Show();
            this.Hide();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            query = "Delete from SingleOrder; Delete from TotalOrders";
            db.setData(query);
            Application.Exit();
        }
    }
}
