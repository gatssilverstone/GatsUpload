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
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
            MiktarTextbox.Text = Convert.ToString(1);
        }
        
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            
        }     

        private void BarkodTextbox_TextChanged(object sender, EventArgs e)
        {
            
        }
        istocposDBEntities db = new istocposDBEntities();

        
        private void BarkodTextbox_KeyDown(object sender, KeyEventArgs e)
        {
            
            if (e.KeyValue == (char)Keys.Multiply)
            {
                String barkodB = BarkodTextbox.Text;
                MiktarTextbox.Text = barkodB;
                BarkodTextbox.Clear();
            }


            if (e.KeyCode == Keys.Enter)
            {
                String barkod = BarkodTextbox.Text.Trim();


                if (db.UrunBilgisi.Any(a=> a.Urunbarkod == barkod))
                {
                    
                    var urun = db.UrunBilgisi.Where(a=> a.Urunbarkod == barkod).FirstOrDefault();
                    int SatirSayisi = dataGridView1.Rows.Count;
                    double miktar = Convert.ToDouble(MiktarTextbox.Text);
                    bool eklnmismi = false;
                    if (SatirSayisi > 0)
                    {
                        for (int i=0; i<SatirSayisi;i++)
                        {
                            if (dataGridView1.Rows[i].Cells["Barkod"].Value.ToString()==barkod)
                            {
                                dataGridView1.Rows[i].Cells["Miktar"].Value = miktar + Convert.ToDouble(dataGridView1.Rows[i].Cells["Miktar"].Value);
                                dataGridView1.Rows[i].Cells["Tutar"].Value = Math.Round ( Convert.ToDouble(dataGridView1.Rows[i].Cells["Miktar"].Value) * Convert.ToDouble(dataGridView1.Rows[i].Cells["Fiyat"].Value),2);
                                eklnmismi = true;
                            }
                        }
                    }
                     if (!eklnmismi)
                    {
                        dataGridView1.Rows.Add();
                        dataGridView1.Rows[SatirSayisi].Cells["Barkod"].Value = barkod;
                        dataGridView1.Rows[SatirSayisi].Cells["UrunAdi"].Value = urun.UrunAdi;
                        dataGridView1.Rows[SatirSayisi].Cells["Miktar"].Value = miktar;
                        dataGridView1.Rows[SatirSayisi].Cells["Fiyat"].Value = urun.SatisFiyati1;
                        dataGridView1.Rows[SatirSayisi].Cells["Tutar"].Value = Math.Round(miktar*(double)urun.SatisFiyati1,2);
                    }
                    dataGridView1.ClearSelection();
                    GenelToplam();
                    BarkodTextbox.Focus();


                }

                

            }

            

        }

        private void BarkodTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            

        }

        private void GenelToplam()
        {

            if (dataGridView1.Rows.Count > 0)
            {
                double toplam = 0;
                for (int i = 0; i < dataGridView1.Rows.Count ;i++)
                {
                    toplam += Convert.ToDouble(dataGridView1.Rows[i].Cells["Tutar"].Value);
                }
                ToplamTextbox.Text = toplam.ToString("C2");
                BarkodTextbox.Clear();
                MiktarTextbox.Text = "1";
            }


        }

        private void MiktarTextbox_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void BarkodTextbox_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar)&& e.KeyChar !=8)
            {
                e.Handled = true;
            }
        }
    }
}
