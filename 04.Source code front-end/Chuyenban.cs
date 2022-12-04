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
    public partial class Chuyenban : Form
    {
        public Chuyenban()
        {
            InitializeComponent();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn có thực sự muốn chuyển bàn 3 qua bàn 7", "Thông báo");
            Thongtinbanan f = new Thongtinbanan();
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
