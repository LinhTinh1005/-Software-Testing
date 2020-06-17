using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DesktopWoocomerce
{
    public partial class Register : Form
    {

        public Register()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void lbLinkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            UILogin Lg = new UILogin();
            Lg.ShowDialog();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Cake cake = new Cake();
            cake.Show();
            this.Close();
        }

        private void btnRegisterUI_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text == "" || txtPassWord.Text == "" || txtPhone.Text == "" || txtAddress.Text == "")
            {
                MessageBox.Show("Vui lòng điền đủ các trường");
            }
            else
            {
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-8DE68CR\SQLEXPRESS;Initial Catalog=DestopApp;Integrated Security=True");
                SqlCommand cmd = new SqlCommand("insert into USER1 values ('" + txtUserName.Text.Trim() + "','" + txtPassWord.Text.Trim() + "','" + txtPhone.Text.Trim() + "','" + txtAddress.Text.Trim() + "')", con);
                con.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Đăng ký thành công");
                }
                else
                {
                    MessageBox.Show("Đăng ký thất bại");
                }
            }

        }
    }
}
