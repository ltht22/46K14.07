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
    public partial class Thongtinnhanvien : Form
    {
        public Thongtinnhanvien()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Menu f = new Menu();
            f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Quanlynhanvien f = new Quanlynhanvien();
            f.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Quanlynhanvien f = new Quanlynhanvien();
            f.Show();
        }
    }
}
