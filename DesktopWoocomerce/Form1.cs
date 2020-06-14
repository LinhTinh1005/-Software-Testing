using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopWoocomerce
{
    public partial class Cake : Form
    {
        public Cake()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            UILogin Login = new UILogin();
            Login.Show();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {

        }
    }
}
