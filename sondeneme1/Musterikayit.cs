using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sondeneme1
{
    public partial class Musterikayit : Form
    {
        public Musterikayit()
        {
            InitializeComponent();
        }

        public void MusteriKaydi()
        {
            SqlBaglanti.MusteriConnect.Open();

            SqlCommand cmd = new SqlCommand("Insert into zenokodc_IstocPosProtoype.Musteriler([Adı Soyadı], [Telefon 1], [Telefon 2], [E-Mail],[Firma Adı],[Fatura Adres], [Vergi Daire], [Vergi No], grup, [açıklama], bakiye, [Sipariş Tutar], tahsilat) values ( @adi, @tel1, @tel2, @mail, @firmaad, @faturaadres, @vergidaire, @vergino, @grup, @aciklama,@bakiye,@tutar,@tahsilat)", SqlBaglanti.MusteriConnect);
            //cmd.Parameters.AddWithValue("@kod", textBox1.Text);
            cmd.Parameters.AddWithValue("@adi", textBox3.Text);
            cmd.Parameters.AddWithValue("@tel1", textBox4.Text);
            cmd.Parameters.AddWithValue("@tel2", textBox5.Text);
            cmd.Parameters.AddWithValue("@mail", textBox2.Text);
            cmd.Parameters.AddWithValue("@faturaadres", textBox7.Text);
            cmd.Parameters.AddWithValue("@firmaad", textBox6.Text);
            cmd.Parameters.AddWithValue("@vergidaire", textBox8.Text);
            cmd.Parameters.AddWithValue("@vergino", textBox9.Text);
            cmd.Parameters.AddWithValue("@grup", comboBox4.Text);
            cmd.Parameters.AddWithValue("@bakiye", textBox9.Text);
            cmd.Parameters.AddWithValue("@tutar", textBox10.Text);
            cmd.Parameters.AddWithValue("@tahsilat", textBox11.Text);
            cmd.Parameters.AddWithValue("@aciklama", textBox11.Text);

            cmd.ExecuteNonQuery();

            
            SqlBaglanti.MusteriConnect.Close();
        }
        private void Musterikayit_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MusteriKaydi();
        }
    }
}
