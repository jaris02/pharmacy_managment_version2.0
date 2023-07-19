using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy_Managment_System.AdminstratorUC
{
    public partial class UC_adduser : UserControl
    {

        public UC_adduser()
        {
            InitializeComponent();
        }
        function fn = new function();
        string query;

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UC_adduser_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
        public void clearall()
        {
            userrolecb.SelectedIndex = -1;
            unametb.Clear();
            passwordtb.Clear();
            nametb.Clear();
            mobilenumtb.Clear();
            emailtb.Clear();
        }
        private void guna2Button3_Click(object sender, EventArgs e)
        {
          clearall();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

            string role = userrolecb.Text;
            string name = nametb.Text;
            string dob = dobselector.Text;
            Int64 mobile = Int64.Parse(mobilenumtb.Text);
            string email = emailtb.Text;
            string username = unametb.Text;
            string pass = passwordtb.Text;

            if (role=="" || name=="" || dob=="" || mobilenumtb.Text=="" || email=="" || username==""||pass==""){

                MessageBox.Show("Please Insert Above Information Correctly","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else {
                try
                {
                    query = "insert into users (userRole,name,dob,mobile,username,pass,email) values ('" + role + "','" + name + "','" + dob + "','" + mobile + "','" + username + "','" + pass + "','" + email + "')";
                    fn.setData(query, "Sign Up Succesfuly");
                }

                catch
                {
                    MessageBox.Show("Username Already Exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            
        }

        private void unametb_TextChanged(object sender, EventArgs e)
        {
            query = "select * from users where username='"+unametb.Text+"'";
            DataSet ds = fn.getdata(query);
            if (ds.Tables[0].Rows.Count == 0)
            {
                pictureBox1.ImageLocation = @"C:\\Users\\PAVILION\\OneDrive\\Desktop\\Pharmacy Management System icon in C#\yes.png";
            }
            else
            {
                pictureBox1.ImageLocation = @"C:\Users\PAVILION\OneDrive\Desktop\Pharmacy Management System icon in C#\no.png";
            }
        }
    } 
}

