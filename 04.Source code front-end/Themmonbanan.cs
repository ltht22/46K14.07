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
    public partial class Themmonbanan : Form
    {
        public Themmonbanan()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn có thực sự muốn lưu thông tin bàn số 7", "Thông báo");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Menu f = new Menu();
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
