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
    public partial class Suamon : Form
    {
        public Suamon()
        {
            InitializeComponent();
        }

        private void richTextBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Menu f = new Menu();
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn có thực sự muốn xóa món Nghêu hấp sả");
            MessageBox.Show("Xóa món thành công");
            Xoamon f = new Xoamon();
            f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
        }
    }
}
