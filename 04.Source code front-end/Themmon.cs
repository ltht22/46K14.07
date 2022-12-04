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
    public partial class Themmon : Form
    {
        public Themmon()
        {
            InitializeComponent();
        }

        private void richTextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Món này đã tồn tại");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Menu f = new Menu();
            f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sửa món thành công");
            Suamon f = new Suamon();
            f.Show();
        }
    }
}
