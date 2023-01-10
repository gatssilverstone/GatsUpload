using System;
using System.CodeDom;
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
            MiktarTextBox1.Text = Convert.ToString(1);
        }
 

        istocposDBEntities db = new istocposDBEntities();
        private void GenelToplam()
        {

                double toplam = 0;
                for (int i = 0; i < dataGridView1.Rows.Count ;i++)
                {
                    toplam += Convert.ToDouble(dataGridView1.Rows[i].Cells["Tutar"].Value);
                }
                ToplamtextBox1.Text = toplam.ToString("C2");
                BarkodTextBox1.Clear();
                MiktarTextBox1.Text = "1";

        }

        private void ToplamtextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BarkodTextBox1_KeyDown_1(object sender, KeyEventArgs e)
        {
            // double miktar = Convert.ToDouble(MiktarTextBox1.Text);

            if (e.KeyValue == (char)Keys.Multiply)
            {
                String barkodB = BarkodTextBox1.Text;
                MiktarTextBox1.Text = barkodB;
                BarkodTextBox1.Clear();
            }


            if (e.KeyCode == Keys.Enter)
            {
                String barkod = BarkodTextBox1.Text.Trim();


                if (db.UrunBilgisi.Any(a => a.Urunbarkod == barkod))
                {

                    var urun = db.UrunBilgisi.Where(a => a.Urunbarkod == barkod).FirstOrDefault();

                    UrunGetirListeye(urun,barkod,Convert.ToDouble(MiktarTextBox1.Text));


                }
                else
                {
                    Console.Beep(900, 1000);
                    MessageBox.Show("Tanımlanmamış Ürün");
                }



            }


        }

        private void UrunGetirListeye(UrunBilgisi urun, string barkod, double miktar)
        {
            int SatirSayisi = dataGridView1.Rows.Count;
            
            bool eklnmismi = false;
            if (SatirSayisi > 0)
            {
                for (int i = 0; i < SatirSayisi; i++)
                {
                    if (dataGridView1.Rows[i].Cells["Barkod"].Value.ToString() == barkod)
                    {
                        dataGridView1.Rows[i].Cells["Miktar"].Value = miktar + Convert.ToDouble(dataGridView1.Rows[i].Cells["Miktar"].Value);
                        dataGridView1.Rows[i].Cells["Tutar"].Value = Math.Round(Convert.ToDouble(dataGridView1.Rows[i].Cells["Miktar"].Value) * Convert.ToDouble(dataGridView1.Rows[i].Cells["Fiyat"].Value), 2);
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
                dataGridView1.Rows[SatirSayisi].Cells["Tutar"].Value = Math.Round(miktar * (double)urun.SatisFiyati1, 2);
            }
            dataGridView1.ClearSelection();
            GenelToplam();
            BarkodTextBox1.Focus();
        }

                    

        private void MiktarTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
                dataGridView1.ClearSelection();
                GenelToplam();
                BarkodTextBox1.Focus();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            HizliButonDoldur();
        }
        private void HizliButonClick(object sender, EventArgs e)
        {
            Button Hb = (Button)sender;
            int buttonid = Convert.ToInt16(Hb.Name.ToString().Substring(7, Hb.Name.Length - 7));

            if (Hb.Text.ToString().StartsWith("-"))
            {
                HizliButonUrunEkle f = new HizliButonUrunEkle();
                f.BNolabel.Text = buttonid.ToString();
                f.ShowDialog();
            }
            else
            {
                
                var urunbarkod = db.HizliUrun.Where(a => a.Id == buttonid).Select(a => a.Barkod).FirstOrDefault();
                var urun = db.UrunBilgisi.Where(a => a.Urunbarkod == urunbarkod).FirstOrDefault();
                UrunGetirListeye(urun, urunbarkod, 1);
                GenelToplam();
            }

        }
        private void HizliButonDoldur()
        {
            var hizliurun = db.HizliUrun.ToList();
            foreach (var item in hizliurun)
            {
                Button Hbutton = this.Controls.Find("Hbutton" + item.Id, true).FirstOrDefault() as Button;
                if (Hbutton != null)
                {
                    double fiyat = islemler.DoubleYap(item.Fiyat1.ToString());
                    Hbutton.Text = item.UrunAdi + "\n" + fiyat.ToString("C2");
                }

            }
        }

        private void hizliButonSil (Object sender ,MouseEventArgs e)
        {
            if ( e.Button == MouseButtons.Right)
            {
               
                Button b = (Button)sender;
                if( !b.Text.StartsWith("-"))
                {
                    int butonid = Convert.ToInt16(b.Name.ToString().Substring(7, b.Name.ToString().Length - 7));
                    ContextMenuStrip s = new ContextMenuStrip();
                    ToolStripMenuItem sil = new ToolStripMenuItem();
                    sil.Text = "Temizle - Buton No:" + butonid.ToString();
                    sil.Click += Sil_Click;
                    s.Items.Add(sil);
                    this.ContextMenuStrip = s;

                }
            }
        }

        private void Sil_Click(object sender, EventArgs e)
        {
            int butonid = Convert.ToInt16(sender.ToString().Substring(19, sender.ToString().Length - 19));
            var guncelle = db.HizliUrun.Find(butonid);
            guncelle.Barkod = "-";
            guncelle.UrunAdi = "-";
            guncelle.Fiyat1 = 0;
            db.SaveChanges();
            Button b = this.Controls.Find("Hbutton" + butonid, true).FirstOrDefault() as Button;
            b.Text = "-" + "\n" + "0";

        }

        private void buttonMuhtelif_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "") {
                int satirSayisi = dataGridView1.Rows.Count;
                dataGridView1.Rows.Add();
                dataGridView1.Rows[satirSayisi].Cells["Barkod"].Value = "111111111116";
                dataGridView1.Rows[satirSayisi].Cells["UrunAdi"].Value = "Muhtelif Ürün";
                dataGridView1.Rows[satirSayisi].Cells["Barkod"].Value = Convert.ToInt32 (MiktarTextBox1.Text);
                dataGridView1.Rows[satirSayisi].Cells["Fiyat"].Value = Convert.ToInt32(textBox2.Text);
                dataGridView1.Rows[satirSayisi].Cells["Tutar"].Value = Convert.ToInt32(textBox2.Text)* Convert.ToInt32(MiktarTextBox1.Text);
                GenelToplam();
                textBox2.Clear();
            }
        }

        private void checkBoxIade_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBoxIade.Checked == false)
            {

                checkBoxIade.Visible = true;

                BarkodTextBox1.Focus();
            }
            else
            {
                BarkodTextBox1.Focus();
                checkBoxIade.Visible = false;
                

            }
        }

        public void temizle()
        {

            MiktarTextBox1.Clear();
            BarkodTextBox1.Clear();
            textBox2.Clear();
            checkBoxIade.Checked = false;
            ToplamtextBox1.Text=0.ToString("C2");
            dataGridView1.Rows.Clear();


        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (checkBoxIade.Checked == false)
            {

                checkBoxIade.Visible = true;
                checkBoxIade.Checked = true;

            }
            else
            {

                checkBoxIade.Visible = false;
                checkBoxIade.Checked = false;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            temizle();
        }
    }
}
