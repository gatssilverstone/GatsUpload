using System;
using System.Data;
using System.Data.SqlClient;
namespace sondeneme1
{
    
    public partial class Form1 : Form
    {

        
        public Form1()
        {
            
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        public void VeriCek() {
            
            SqlCommand cmd = new SqlCommand("select * from zenokodc_IstocPosPrototype.Urun_Bilgisi", SqlBaglanti.connect);
          

            SqlBaglanti.connect.Open(); 
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            dataGridView6.DataSource = dt;

            SqlBaglanti.connect.Close();
            



        }
        public void VeriCekMusteri() {

            SqlBaglanti.MusteriConnect.Open();

            SqlCommand cmd = new SqlCommand("select * from zenokodc_IstocPosProtoype.Musteriler", SqlBaglanti.MusteriConnect);
            SqlDataAdapter dataAdapter=new SqlDataAdapter(cmd);
            DataTable dataTable= new DataTable();
            dataAdapter.Fill(dataTable);
            dataGridView7.DataSource= dataTable;

        
        
        
            SqlBaglanti.MusteriConnect.Close();
        }
        string satisFiyat;
        private void SatisBarkodOkutma() { 
            SqlBaglanti.connect.Open();

            string barkod=SatisBarkodtextBox.Text;

            SqlCommand cmd = new SqlCommand("Select [�r�n Ad�],barkod,[sat�� fiyat],adet from zenokodc_IstocPosPrototype.Urun_Bilgisi where barkod=@barcode", SqlBaglanti.connect);
            cmd.Parameters.AddWithValue("@barcode", barkod);
            SqlDataReader read = cmd.ExecuteReader();

            
            
            while (read.Read())
            {

                
                
                
                ListViewItem add = new ListViewItem();
                add.Text = read["�r�n Ad�"].ToString();
                add.SubItems.Add(textBox1.Text);
                add.SubItems.Add(read["sat�� fiyat"].ToString());
                add.SubItems.Add(Convert.ToString (urunTutar));
                add.SubItems.Add(read["barkod"].ToString());
                add.SubItems.Add(read["adet"].ToString());
                listView1.Items.Add(add);



            }
            

            SqlBaglanti.connect.Close();
        
        
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           VeriCek();
            VeriCekMusteri();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button26_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button32_Click(object sender, EventArgs e)
        {
            
        }

      
        
        
        
        
        private void button2466666_Click(object sender, EventArgs e)
        {

        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

      
        
        
        
        
        
        
        private void button2478888_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void sToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {

        }

        private void sToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            GirisFisi GirisFisi = new GirisFisi();
            GirisFisi.ShowDialog();
        }

        private void UrunlerUrunaditextBox_TextChanged(object sender, EventArgs e)
        {
            SqlBaglanti.connect.Open();
            DataTable dataTable = new DataTable();
            SqlDataAdapter find = new SqlDataAdapter("select * from zenokodc_IstocPosPrototype.Urun_Bilgisi where [�r�n Ad�] like '%" + UrunlerUrunaditextBox.Text + "%'", SqlBaglanti.connect);
            
            find.Fill(dataTable);
            dataGridView6.DataSource = dataTable;

            SqlBaglanti.connect.Close();

        }

        private void ToptanStokcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void UrunelerUrunekleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UrunEkle urunEkle=new UrunEkle();
            urunEkle.ShowDialog();
        }

        private void UrunlerBarkodtextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void UrunlerBarkodtextBox_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                SqlBaglanti.connect.Open();
                DataTable dataTable = new DataTable();
                SqlDataAdapter find = new SqlDataAdapter("select * from zenokodc_IstocPosPrototype.Urun_Bilgisi where barkod like '%" + UrunlerBarkodtextBox.Text + "%'", SqlBaglanti.connect);

                find.Fill(dataTable);
                dataGridView6.DataSource = dataTable;
                SqlBaglanti.connect.Close();
                textBox1.Text = "1";
            }
            
        }

        private void UrunlerStokGrubucomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlBaglanti.connect.Open();
            DataTable dataTable = new DataTable();
            SqlDataAdapter find = new SqlDataAdapter("select * from zenokodc_IstocPosPrototype.Urun_Bilgisi where [Stok Grubu] like '%" + UrunlerStokGrubucomboBox.Text + "%'", SqlBaglanti.connect);

            find.Fill(dataTable);
            dataGridView6.DataSource = dataTable;

            SqlBaglanti.connect.Close();
        }

        private void BarkodCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (BarkodCheck.Checked == true)
            {
                dataGridView6.Columns["barkod"].Visible = true;
            }
            else
            {
                dataGridView6.Columns["barkod"].Visible = false;
            }
        }

        private void UrunadiCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (UrunadiCheck.Checked == true)
            {
                dataGridView6.Columns["�r�n Ad�"].Visible = true;
            }
            else
            {
                dataGridView6.Columns["�r�n Ad�"].Visible = false;
            }





        }

        private void UrunlerDetayliaramacheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (UrunlerDetayliaramacheckBox.Checked == true)
            {
                dataGridView6.Columns["�r�n Ad�"].Visible = false;
                dataGridView6.Columns["barkod"].Visible = false;
                dataGridView6.Columns["al�� fiyat�"].Visible = false;
                dataGridView6.Columns["sat�� fiyat"].Visible = false;
                dataGridView6.Columns["�r�n kodu"].Visible = false;
                dataGridView6.Columns["son i�lem tarihi"].Visible = false;
                dataGridView6.Columns["adet"].Visible = false;
                dataGridView6.Columns["giri� tarihi"].Visible = false;
                dataGridView6.Columns["��k�� tarihi"].Visible = false;
                dataGridView6.Columns["sat�� fiyat� 2"].Visible = false;
                dataGridView6.Columns["sat�� fiyat� 3"].Visible = false;
                dataGridView6.Columns["sat�� fiyat� 4"].Visible = false;
                dataGridView6.Columns["�r�n a��klamas�"].Visible = false;
                dataGridView6.Columns["Stok Grubu"].Visible = false;
                dataGridView6.Columns["�r�n Kategori"].Visible = false;
                dataGridView6.Columns["Devir Miktar�"].Visible = false;
                dataGridView6.Columns["Birim"].Visible = false;
                dataGridView6.Columns["kdv"].Visible = false;

                urunKodCheck.Visible = true;
                UrunadiCheck.Visible = true;
                BarkodCheck.Visible = true;
                AlisFiyatCheck.Visible = true;
                satis1Check.Visible = true;
                satis2Check.Visible = true;
                satis3Check.Visible = true;
                satis4Check.Visible = true;
                adetCheck.Visible = true;
                aciklamaCheck.Visible = true;
                stokGrupCheck.Visible = true;
                kategoriCheck.Visible = true;
                devirCheck.Visible = true;
                birimCheck.Visible = true;
                kdvCheck.Visible = true;
                ilkGirisCheck.Visible = true;
                sonIslemCheck.Visible = true;
                cikisTarihiCheck.Visible = true;

            }
            else {

                dataGridView6.Columns["�r�n Ad�"].Visible = true;
                dataGridView6.Columns["barkod"].Visible = true;
                dataGridView6.Columns["al�� fiyat�"].Visible = true;
                dataGridView6.Columns["sat�� fiyat"].Visible = true;
                dataGridView6.Columns["�r�n kodu"].Visible = true;
                dataGridView6.Columns["son i�lem tarihi"].Visible = true;
                dataGridView6.Columns["adet"].Visible = true;
                dataGridView6.Columns["giri� tarihi"].Visible = true;
                dataGridView6.Columns["��k�� tarihi"].Visible = true;
                dataGridView6.Columns["sat�� fiyat� 2"].Visible = true;
                dataGridView6.Columns["sat�� fiyat� 3"].Visible = true;
                dataGridView6.Columns["sat�� fiyat� 4"].Visible = true;
                dataGridView6.Columns["�r�n a��klamas�"].Visible = true;
                dataGridView6.Columns["Stok Grubu"].Visible = true;
                dataGridView6.Columns["�r�n Kategori"].Visible = true;
                dataGridView6.Columns["Devir Miktar�"].Visible = true;
                dataGridView6.Columns["Birim"].Visible = true;
                dataGridView6.Columns["kdv"].Visible = true;

                urunKodCheck.Visible=false;
                UrunadiCheck.Visible = false;
                BarkodCheck.Visible = false;
                AlisFiyatCheck.Visible = false;
                satis1Check.Visible = false;
                satis2Check.Visible = false;
                satis3Check.Visible = false;
                satis4Check.Visible = false;
                adetCheck.Visible = false;
                aciklamaCheck.Visible = false;
                stokGrupCheck.Visible = false;
                kategoriCheck.Visible = false;
                devirCheck.Visible = false;
                birimCheck.Visible = false;
                kdvCheck.Visible = false;
                ilkGirisCheck.Visible = false;
                sonIslemCheck.Visible = false;
                cikisTarihiCheck.Visible = false;

            }

        }

        private void AlisFiyatCheck_CheckedChanged(object sender, EventArgs e)
        {
            
            if (AlisFiyatCheck.Checked == true)
            {
                dataGridView6.Columns["al�� fiyat�"].Visible = true;
            }
            else
            {
                dataGridView6.Columns["al�� fiyat�"].Visible = false;
            }

        }

        private void satis1Check_CheckedChanged(object sender, EventArgs e)
        {
            if (satis1Check.Checked == true)
            {
                dataGridView6.Columns["sat�� fiyat� 2"].Visible = true;
            }
            else
            {
                dataGridView6.Columns["sat�� fiyat� 2"].Visible = false;
            }
        }

        private void satis2Check_CheckedChanged(object sender, EventArgs e)
        {
            if (satis2Check.Checked == true)
            {
                dataGridView6.Columns["sat�� fiyat"].Visible = true;
            }
            else
            {
                dataGridView6.Columns["sat�� fiyat"].Visible = false;
            }
        }

        private void satis3Check_CheckedChanged(object sender, EventArgs e)
        {
            if (satis3Check.Checked == true)
            {
                dataGridView6.Columns["sat�� fiyat� 3"].Visible = true;
            }
            else
            {
                dataGridView6.Columns["sat�� fiyat� 3"].Visible = false;
            }
        }

        private void satis4Check_CheckedChanged(object sender, EventArgs e)
        {
            if (satis4Check.Checked == true)
            {
                dataGridView6.Columns["sat�� fiyat� 4"].Visible = true;
            }
            else
            {
                dataGridView6.Columns["sat�� fiyat� 4"].Visible = false;
            }
        }

        private void urunKodCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (urunKodCheck.Checked == true)
            {
                dataGridView6.Columns["�r�n kodu"].Visible = true;
            }
            else
            {
                dataGridView6.Columns["�r�n kodu"].Visible = false;
            }
        }

        private void adetCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (adetCheck.Checked == true)
            {
                dataGridView6.Columns["adet"].Visible = true;
            }
            else
            {
                dataGridView6.Columns["adet"].Visible = false;
            }
        }

        private void aciklamaCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (aciklamaCheck.Checked == true)
            {
                dataGridView6.Columns["�r�n a��klamas�"].Visible = true;
            }
            else
            {
                dataGridView6.Columns["�r�n a��klamas�"].Visible = false;
            }
        }

        private void stokGrupCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (stokGrupCheck.Checked == true)
            {
                dataGridView6.Columns["Stok Grubu"].Visible = true;
            }
            else
            {
                dataGridView6.Columns["Stok Grubu"].Visible = false;
            }
        }

        private void kategoriCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (kategoriCheck.Checked == true)
            {
                dataGridView6.Columns["�r�n Kategori"].Visible = true;
            }
            else
            {
                dataGridView6.Columns["�r�n Kategori"].Visible = false;
            }
        }

        private void devirCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (devirCheck.Checked == true)
            {
                dataGridView6.Columns["Devir Miktar�"].Visible = true;
            }
            else
            {
                dataGridView6.Columns["Devir Miktar�"].Visible = false;
            }
        }

        private void birimCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (birimCheck.Checked == true)
            {
                dataGridView6.Columns["birim"].Visible = true;
            }
            else
            {
                dataGridView6.Columns["birim"].Visible = false;
            }
        }

        private void kdvCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (kdvCheck.Checked == true)
            {
                dataGridView6.Columns["kdv"].Visible = true;
            }
            else
            {
                dataGridView6.Columns["kdv"].Visible = false;
            }
        }

        private void ilkGirisCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (ilkGirisCheck.Checked == true)
            {
                dataGridView6.Columns["giri� tarihi"].Visible = true;
            }
            else
            {
                dataGridView6.Columns["giri� tarihi"].Visible = false;
            }
        }

        private void cikisTarihiCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (cikisTarihiCheck.Checked == true)
            {
                dataGridView6.Columns["��k�� tarihi"].Visible = true;
            }
            else
            {
                dataGridView6.Columns["��k�� tarihi"].Visible = false;
            }
        }

        private void sonIslemCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (sonIslemCheck.Checked == true)
            {
                dataGridView6.Columns["son i�lem tarihi"].Visible = true;
            }
            else
            {
                dataGridView6.Columns["son i�lem tarihi"].Visible = false;
            }
        }

        private void MusterilerMusteriekletoolStripMenuItem_Click(object sender, EventArgs e)
        {
            Musterikayit MusteriKayit = new Musterikayit();
            MusteriKayit.ShowDialog();
        }

        private void UrunlerGiriscikistoolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void MusterilerTahsilahtoolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tahsilat�slemleri Tahsilat�slem = new Tahsilat�slemleri();
            Tahsilat�slem.ShowDialog();
        }

        private void SatisKisayolbuton14_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem14_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem12_Click(object sender, EventArgs e)
        {
            AlinanSiparis AlinanSiparis = new AlinanSiparis();
            AlinanSiparis.ShowDialog();
        }

        private void SatisBarkodtextBox_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        public static decimal topla;

        int urunMiktar;
        int urunTutar;
        int stsFiyat;
        private void SatisBarkodtextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
            {



                
                SatisBarkodOkutma();
                
                stsFiyat = (int) Convert.ToInt32(satisFiyat);
                
               // urunMiktar = (int) Convert.ToInt32(textBox1.Text);
                // urunTutar = urunMiktar *  stsFiyat;
                //urunTutar =(int) Convert.ToInt32(satisFiyat) * Convert.ToInt32(urunMiktar);
                

                SatisBarkodtextBox.Clear();
                



                topla = 0;

                if (textBox1.Text != null)
                {
                    int urunMiktar;
                    urunMiktar = Convert.ToInt32(textBox1.Text);

                    for (int i = 0; i < urunMiktar; i++)
                    {
                        for (int sayi = 0; sayi <= listView1.Items.Count - 1; sayi++)

                        {

                            decimal sayi1;

                            string sayi2;

                            sayi2 = listView1.Items[sayi].SubItems[2].Text;

                            sayi1 = decimal.Parse(sayi2);

                            topla = topla + sayi1;
                            

                            
                        }

                        

                    }

                }
                


                textBox1.Text = "1";
                SatisToplamtutartextBox.Text = Convert.ToString(topla);

            }
        }

        private void SatisSatirsilbuton_Click(object sender, EventArgs e)
        {

            decimal toplam = Convert.ToDecimal(SatisToplamtutartextBox.Text);

            decimal silici = Convert.ToDecimal(listView1.SelectedItems[0].SubItems[2].Text);
            listView1.Items.Remove(listView1.SelectedItems[0]);
            SatisToplamtutartextBox.Text = Convert.ToString(toplam - silici);
        }
        public void clearListWiew()
        {
            listView1.Items.Clear();
            topla = 0;
            SatisToplamtutartextBox.Clear();
        }
        private void SatisEvraksilbuton_Click(object sender, EventArgs e)
        {
            clearListWiew();
        }

        private void SatisNakitsatisbuton_Click(object sender, EventArgs e)
        {
            NakitPerakendeSatis nakitPerakendeSatis=new NakitPerakendeSatis();
            nakitPerakendeSatis.Show();
            
            clearListWiew();


        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}