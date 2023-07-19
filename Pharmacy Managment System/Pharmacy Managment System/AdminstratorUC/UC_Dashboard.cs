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
    public partial class UC_Dashboard : UserControl
    {
        public UC_Dashboard()
        {
            InitializeComponent();
        }
        function fn = new function();
        DataSet ds;
        string query;

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
        }

        private void UC_Dashboard_Load(object sender, EventArgs e)
        {
            query = "select count(userRole) from users where userRole='Adminstrator'";
            ds = fn.getdata(query);
            setlbl(ds, admincount);

            query = "select  count(userRole) from users where userRole='Pharmacist'";
            ds = fn.getdata(query);
            setlbl(ds, Pharmacount);

        }

        private void setlbl(DataSet ds,Label lbl) {
            if (ds.Tables[0].Rows.Count != 0)
            {
                lbl.Text = ds.Tables[0].Rows[0][0].ToString();
            }
            else {
                lbl.Text = "0";
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            UC_Dashboard_Load(this,null);
        }
    }
}
