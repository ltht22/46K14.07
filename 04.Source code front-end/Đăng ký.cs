using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTN
{
    public partial class Đăng_ký : Form
    {
        public Đăng_ký()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đăng ký tài khoản thành công");
            Formdangnhap f = new Formdangnhap();
            f.Show();
        }
      

    private void Đăng_ký_Load(object sender, EventArgs e)
        {

        }
    }
}
