using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace sondeneme1
{
    public partial class UrunEkle : Form
    {
        public UrunEkle()
        {
            InitializeComponent();
        }


        public void UrunEkleMetod() {

            DateTime date = DateTime.Today;

            SqlCommand cmdADD = new SqlCommand("Insert into zenokodc_IstocPosPrototype.Urun_Bilgisi(barkod, [Ürün Adı], [alış fiyatı], [satış fiyat], [satış fiyatı 2], [satış fiyatı 3], [satış fiyatı 4], Birim, adet, [Stok Grubu], [Ürün Kategori], kdv, [ürün açıklaması], [giriş tarihi], [son işlem tarihi], [çıkış tarihi], [ürün kodu]) values (@barkod, @ad, @alis, @satis1, @satis2, @satis3, @satis4,@birim,@miktar,@stokgrup,@kategori,@kdv,@aciklama,@girisDate,@sonislemDate,@cikisDate,@kod)", SqlBaglanti.connect);
            SqlBaglanti.CheckConnection(SqlBaglanti.connect);
            cmdADD.Parameters.AddWithValue("@barkod", textBoxBarcode.Text);
            cmdADD.Parameters.AddWithValue("kod", textBoxBarcode.Text);
            cmdADD.Parameters.AddWithValue("@ad", textBoxName.Text);
            cmdADD.Parameters.AddWithValue("@alis", textBoxBuyPrice.Text);
            cmdADD.Parameters.AddWithValue("@satis1", textBoxSellPrice1.Text);
            cmdADD.Parameters.AddWithValue("@satis2", textBoxSellPrice2.Text);
            cmdADD.Parameters.AddWithValue("@satis3", textBoxSellPrice3.Text);
            cmdADD.Parameters.AddWithValue("@satis4", textBoxSellPrice4.Text);
            cmdADD.Parameters.AddWithValue("@birim", comboBoxBirim.Text);
            cmdADD.Parameters.AddWithValue("@miktar", textBoxMiktar.Text);
            cmdADD.Parameters.AddWithValue("@stokgrup", comboBoxStokGrup.Text);
            cmdADD.Parameters.AddWithValue("@kategori", comboBoxKategori.Text);
            cmdADD.Parameters.AddWithValue("@kdv", comboBoxKDV.Text);
            cmdADD.Parameters.AddWithValue("@aciklama", richTextBoxAciklama.Text);
            cmdADD.Parameters.AddWithValue("@girisdate", date);
            cmdADD.Parameters.AddWithValue("@sonislemDate", date);
            cmdADD.Parameters.AddWithValue("@cikisDate", date);


            cmdADD.ExecuteNonQuery();

        }

        private void button1_Click(object sender, EventArgs e)
        {



            UrunEkleMetod();
            
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxSellPrice1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
}
