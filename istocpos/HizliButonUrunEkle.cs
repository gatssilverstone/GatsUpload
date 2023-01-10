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
    public partial class HizliButonUrunEkle : Form
    {
        public HizliButonUrunEkle()
        {
            InitializeComponent();
        }
        istocposDBEntities db = new istocposDBEntities();
        private void HizliUrunAraTextbox_TextChanged(object sender, EventArgs e)
        {
            if(HizliUrunAraTextbox.Text !="")
            {
                string Urunad = HizliUrunAraTextbox.Text;
                var urunler = db.UrunBilgisi.Where(a => a.UrunAdi.Contains(Urunad)).ToList();
                HizliUrunEkleUrunlerGrid.DataSource = urunler;
            }
        }

        private void HizliUrunEkleUrunlerGrid_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (HizliUrunEkleUrunlerGrid.Rows.Count > 0)
            {
                string barkod = HizliUrunEkleUrunlerGrid.CurrentRow.Cells["Urunbarkod"].Value.ToString();
                string urunad = HizliUrunEkleUrunlerGrid.CurrentRow.Cells["UrunAdi"].Value.ToString();
                double fiyat  = Convert.ToDouble(HizliUrunEkleUrunlerGrid.CurrentRow.Cells["SatisFiyati1"].Value.ToString());
                int id = Convert.ToInt16(BNolabel.Text);
                var guncellenecek = db.HizliUrun.Find(id);
                guncellenecek.Barkod = barkod;
                guncellenecek.UrunAdi = urunad;
                guncellenecek.Fiyat1 = fiyat;
                db.SaveChanges();
                MessageBox.Show("Hızlı Buton Tanımlanmıştır");
                Form1 f = (Form1)Application.OpenForms["Form1"];
                if(f!=null)
                {
                    Button b = f.Controls.Find("Hbutton" + id, true).FirstOrDefault() as Button;
                    b.Text = urunad + "\n" + fiyat.ToString("C2");
                }
                this.Close();
            }
        }

        private void HizliUrunAraChekBox_CheckedChanged(object sender, EventArgs e)
        {
            if (HizliUrunAraChekBox.Checked)
            {
                HizliUrunEkleUrunlerGrid.DataSource = db.UrunBilgisi.ToList();

            }
            else {
                HizliUrunEkleUrunlerGrid.DataSource = null;
            }
            
             
        }
    }
}
