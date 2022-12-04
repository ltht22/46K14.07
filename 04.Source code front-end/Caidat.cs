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
    public partial class Caidat : Form
    {
        public Caidat()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Menu f = new Menu();
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn có muốn đăng xuất khỏi web", "Xác nhận");
            Application.Exit();
        }
    }
}
