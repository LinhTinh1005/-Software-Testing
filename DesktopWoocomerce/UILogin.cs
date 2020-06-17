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
            //try
            //{
            //    String str = "server=DESKTOP-8DE68CR\\SQLEXPRESS; database=DestopApp";
            //    String query = "select *from LoginUS1";
            //    SqlConnection con = new SqlConnection(str);
            //    //SqlCommand cmd = new SqlCommand(query, con);
            //    con.Open();
            //    DataSet ds = new DataSet();
            //    MessageBox.Show("connect to database successfully");
            //    con.Close();
            //}
            //catch(Exception es)
            //{
            //    MessageBox.Show(es.Message);
            //}
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Cake cake = new Cake();
            cake.ShowDialog();
        }

        private void btnLoginUI_Click(object sender, EventArgs e)
        {
            if (tbxLoginName.Text == "" || tbxPass.Text == "" || txtPhone.Text == "" || txtAddress.Text == "")
            {
                MessageBox.Show("Vui lòng điền đủ các trường");
                return;
            }
            else
            {
                string str = "Data Source=DESKTOP-8DE68CR\\SQLEXPRESS;Initial Catalog=DestopApp;Integrated Security=True";
                SqlConnection con = new SqlConnection(str);
                string query = "select * from USER1 where UserName = '" + tbxLoginName.Text.Trim() + "' and PassWord ='" + tbxPass.Text.Trim() + "' and Phone ='" + txtPhone.Text.Trim() + "'and Address='" + txtAddress.Text.Trim() + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                DataTable dttb = new DataTable();
                sda.Fill(dttb);
                if (dttb.Rows.Count > 0)
                {
                    Ebook ebook = new Ebook();
                    this.Hide();
                    ebook.Show();

                }
                else
                {
                    MessageBox.Show("Kiểm tra lại Thông tin");
                }
            }

        }

        private void UserName_Login_Validation(object sender, EventArgs e)
        {
            //if (string.IsNullOrEmpty(tbxLoginName.Text))
            //{
            //    tbxLoginName.Focus();
            //    ErrorProvider.SetError(
            //        this.tbxLoginName,"Vui lòng nhập tên");
            //}
        }
    }
}