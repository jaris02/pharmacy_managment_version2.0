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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }
        string userr = "";

        public string ID
        {
            get { return userr.ToString(); }
        }
        public Admin(string user)
        {
            InitializeComponent();
            adminnamelbl.Text = user;

            userr = user;

            uC_View_user1.ID = ID;
        }
        

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void logoutbtn_Click(object sender, EventArgs e)
        {
            login login=new login();
            login.Show();
            this.Hide();
           

        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            uC_Dashboard1.Visible = true;
            uC_Dashboard1.BringToFront();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            
        }
        
        private void Admin_Load_1(object sender, EventArgs e)
        {
            uC_Dashboard1.Visible = false;
            uC_adduser1.Visible = false;    
            dashboardbtn.PerformClick();
           // adminnamelbl.Text = login.uname;
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            uC_adduser1.Visible = true;
            uC_adduser1.BringToFront();
        }

        private void uC_adduser1_Load(object sender, EventArgs e)
        {

        }

        private void viewuserbtn_Click(object sender, EventArgs e)
        {
            uC_View_user1.Visible = true;
            uC_View_user1.BringToFront();
        }
    }
}
