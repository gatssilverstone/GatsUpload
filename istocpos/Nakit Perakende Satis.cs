using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace istocpos
{
    public partial class Nakit_Perakende_Satis : Form
    {
        public Nakit_Perakende_Satis()
        {
            InitializeComponent();
        }

        private void button5tl_Click(object sender, EventArgs e)
        {
            textBox1.Text = "5";
        }

        private void button10tl_Click(object sender, EventArgs e)
        {
            textBox1.Text = "10";
        }

        private void button20tl_Click(object sender, EventArgs e)
        {
            textBox1.Text = "20";
        }

        private void button50tl_Click(object sender, EventArgs e)
        {
            textBox1.Text = "50";
        }

        private void button100tl_Click(object sender, EventArgs e)
        {
            textBox1.Text= "100";
        }

        private void button200tl_Click(object sender, EventArgs e)
        {
            textBox1.Text = "200";
        }
    }
}
