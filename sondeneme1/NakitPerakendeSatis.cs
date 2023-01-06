using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace sondeneme1
{
    public partial class NakitPerakendeSatis : Form
    {
        public NakitPerakendeSatis()
        {
            InitializeComponent();
        }

        


        double paraUstu = 0;

            

            Form1 sts = new Form1();
            
                
            

           

            private void NakitPerakendeSatis_Load(object sender, EventArgs e)
            {
                label2.Text = Convert.ToString(Form1.topla);
            }
        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                paraUstu = Convert.ToDouble(textBox1.Text) - Convert.ToDouble(Form1.topla);
                if (paraUstu > 0)
                    label5.Text = Convert.ToString(paraUstu);
                else
                    label5.Text = "0";
            }
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
             if (paraUstu >= 0)
            {

                var clr = (Form1)Application.OpenForms["Form1"];
                clr.clearListWiew();

                Form1 frm1=new Form1();
                frm1.StoktanDus();

               // var dus = (Form1)Application.OpenForms["Form1"];
              //  dus.StoktanDus();

                this.Close();
            }
            else
                MessageBox.Show("eksik para verdi bu hıyar");
        }
    }
}
