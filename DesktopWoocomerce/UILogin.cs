using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace DesktopWoocomerce
{
    public partial class UILogin : Form
    {
        public UILogin()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnConnectDB_Click(object sender, EventArgs e)
        {
            try
            {
                String str = "server=DESKTOP-8DE68CR\\SQLEXPRESS; database=woocomerce";
                String query = "select *from UserLogin";
                SqlConnection con = new SqlConnection(str);
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                DataSet ds = new DataSet();
                MessageBox.Show("connect with sql server");
                con.Close();
            }
            catch(Exception es)
            {
                MessageBox.Show(es.Message);
            }
        }
    }
}
