using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy_Managment_System
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }
        function fn = new function();
        function fn2 = new function();
        string query , query2;
        DataSet ds = new DataSet();

        public string uname; 

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            login login=new login();    
            this.Close();
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
           unametext.Clear();
            passwordtext.Clear();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

            query = "select * from users where userRole='Adminstrator'";
            ds = fn.getdata(query);
            if (ds.Tables[0].Rows.Count==0)
            {
                if(unametext.Text=="root" && passwordtext.Text == "root")
                {
                    Admin admin = new Admin();
                    admin.Show();
                    this.Hide();
                }
               
            }
            else { query = "select * from users where username='" + unametext.Text + "' and pass='" + passwordtext.Text + "'";
                //  query2 = "select * from users where userRolr='Adminstrator'";
                 ds = fn.getdata(query);
                // DataSet ds2 = fn2.getdata(query2);

                if (unametext.Text == "" || passwordtext.Text == "")
                {
                    MessageBox.Show("Insert The Information Above Correctly", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (ds.Tables[0].Rows.Count == 1)
                { string role = ds.Tables[0].Rows[0][1].ToString();
                    if (role == "Adminstrator")
                    {
                        Admin admin = new Admin(unametext.Text);
                        admin.Show();
                        this.Hide();
                    } else if (role == "Pharmacist")
                    {
                        Pharmacist pharmacist = new Pharmacist();
                        pharmacist.Show();
                        this.Hide();

                    }
                    uname = unametext.Text;
                }
                else
                {
                    MessageBox.Show("Wrong Username Or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } }
    }
}
