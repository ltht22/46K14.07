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
    public partial class Xoamon : Form
    {
        public Xoamon()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Menu f = new Menu();
            f.Show();
        }

        private void richTextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Tracuumon f = new Tracuumon();
            f.Show();
        }
    }
}
