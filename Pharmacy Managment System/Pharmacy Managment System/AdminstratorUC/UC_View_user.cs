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
    public partial class UC_View_user : UserControl
    {
        public UC_View_user()
        {
            InitializeComponent();
        }
        function fn = new function();
        string query;

        string currentuser= "";
        public string ID
        {
            set { currentuser = value; }
        }
        private void UC_View_user_Load(object sender, EventArgs e)
        {
            query = "select * from users";
            DataSet da=fn.getdata(query);
            guna2DataGridView2.DataSource = da.Tables[0];
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            query = "select * from users where username like '" + searchtext.Text + "%'";
            DataSet ds =fn.getdata(query);
            guna2DataGridView2.DataSource = ds.Tables[0];
        }
        
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            UC_View_user_Load(this,null);
        }
        string username;
        private void guna2DataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try {
                username =guna2DataGridView2.Rows[e.RowIndex].Cells[5].Value.ToString(); 
            }
            catch { 
            
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure You Want To Delete User '"+username+"' ?", "Delete Confirmation !!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (currentuser != username)
                {
                    query = "delete * from users where username='" + username + "'";
                    fn.setData(query,"User Record Deleted Successfully");
                }
                else
                {
                    MessageBox.Show("You're Trying To Delete Your Own Profile", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);


                }
            }
        }
    }
}
