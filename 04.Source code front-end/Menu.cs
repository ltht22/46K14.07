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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Quanlybanan f = new Quanlybanan();
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Quanlydanhmucmonan f = new Quanlydanhmucmonan();
            f.Show();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Quanlydoanhthu f = new Quanlydoanhthu();
            f.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Quanlynhanvien f = new Quanlynhanvien();
            f.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Quanlykho f = new Quanlykho();
            f.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Taodonhang f = new Taodonhang();
            f.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Caidat f = new Caidat();
            f.Show();
        }
    }
}
