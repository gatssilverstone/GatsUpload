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
          

            SqlBaglanti.CheckConnection(SqlBaglanti.connect);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            dataGridView6.DataSource = dt;

            



        }

        private void Form1_Load(object sender, EventArgs e)
        {
           VeriCek();
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
            SqlBaglanti.CheckConnection(SqlBaglanti.connect);
            DataTable dataTable = new DataTable();
            SqlDataAdapter find = new SqlDataAdapter("select * from zenokodc_IstocPosPrototype.Urun_Bilgisi where [Ürün Adý] like '%" + UrunlerUrunaditextBox.Text + "%'", SqlBaglanti.connect);
            
            find.Fill(dataTable);
            dataGridView6.DataSource = dataTable;

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
                SqlBaglanti.CheckConnection(SqlBaglanti.connect);
                DataTable dataTable = new DataTable();
                SqlDataAdapter find = new SqlDataAdapter("select * from zenokodc_IstocPosPrototype.Urun_Bilgisi where barkod like '%" + UrunlerBarkodtextBox.Text + "%'", SqlBaglanti.connect);

                find.Fill(dataTable);
                dataGridView6.DataSource = dataTable;
            }
        }

        private void UrunlerStokGrubucomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlBaglanti.CheckConnection(SqlBaglanti.connect);
            DataTable dataTable = new DataTable();
            SqlDataAdapter find = new SqlDataAdapter("select * from zenokodc_IstocPosPrototype.Urun_Bilgisi where [Stok Grubu] like '%" + UrunlerStokGrubucomboBox.Text + "%'", SqlBaglanti.connect);

            find.Fill(dataTable);
            dataGridView6.DataSource = dataTable;
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
                dataGridView6.Columns["Ürün Adý"].Visible = true;
            }
            else
            {
                dataGridView6.Columns["Ürün Adý"].Visible = false;
            }





        }

        private void UrunlerDetayliaramacheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (UrunlerDetayliaramacheckBox.Checked == true)
            {
                dataGridView6.Columns["Ürün Adý"].Visible = false;
                dataGridView6.Columns["barkod"].Visible = false;
                dataGridView6.Columns["alýþ fiyatý"].Visible = false;
                dataGridView6.Columns["satýþ fiyat"].Visible = false;
                dataGridView6.Columns["ürün kodu"].Visible = false;
                dataGridView6.Columns["son iþlem tarihi"].Visible = false;
                dataGridView6.Columns["adet"].Visible = false;
                dataGridView6.Columns["giriþ tarihi"].Visible = false;
                dataGridView6.Columns["çýkýþ tarihi"].Visible = false;
                dataGridView6.Columns["satýþ fiyatý 2"].Visible = false;
                dataGridView6.Columns["satýþ fiyatý 3"].Visible = false;
                dataGridView6.Columns["satýþ fiyatý 4"].Visible = false;
                dataGridView6.Columns["ürün açýklamasý"].Visible = false;
                dataGridView6.Columns["Stok Grubu"].Visible = false;
                dataGridView6.Columns["Ürün Kategori"].Visible = false;
                dataGridView6.Columns["Devir Miktarý"].Visible = false;
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

                dataGridView6.Columns["Ürün Adý"].Visible = true;
                dataGridView6.Columns["barkod"].Visible = true;
                dataGridView6.Columns["alýþ fiyatý"].Visible = true;
                dataGridView6.Columns["satýþ fiyat"].Visible = true;
                dataGridView6.Columns["ürün kodu"].Visible = true;
                dataGridView6.Columns["son iþlem tarihi"].Visible = true;
                dataGridView6.Columns["adet"].Visible = true;
                dataGridView6.Columns["giriþ tarihi"].Visible = true;
                dataGridView6.Columns["çýkýþ tarihi"].Visible = true;
                dataGridView6.Columns["satýþ fiyatý 2"].Visible = true;
                dataGridView6.Columns["satýþ fiyatý 3"].Visible = true;
                dataGridView6.Columns["satýþ fiyatý 4"].Visible = true;
                dataGridView6.Columns["ürün açýklamasý"].Visible = true;
                dataGridView6.Columns["Stok Grubu"].Visible = true;
                dataGridView6.Columns["Ürün Kategori"].Visible = true;
                dataGridView6.Columns["Devir Miktarý"].Visible = true;
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
                dataGridView6.Columns["alýþ fiyatý"].Visible = true;
            }
            else
            {
                dataGridView6.Columns["alýþ fiyatý"].Visible = false;
            }

        }

        private void satis1Check_CheckedChanged(object sender, EventArgs e)
        {
            if (satis1Check.Checked == true)
            {
                dataGridView6.Columns["satýþ fiyatý 2"].Visible = true;
            }
            else
            {
                dataGridView6.Columns["satýþ fiyatý 2"].Visible = false;
            }
        }

        private void satis2Check_CheckedChanged(object sender, EventArgs e)
        {
            if (satis2Check.Checked == true)
            {
                dataGridView6.Columns["satýþ fiyat"].Visible = true;
            }
            else
            {
                dataGridView6.Columns["satýþ fiyat"].Visible = false;
            }
        }

        private void satis3Check_CheckedChanged(object sender, EventArgs e)
        {
            if (satis3Check.Checked == true)
            {
                dataGridView6.Columns["satýþ fiyatý 3"].Visible = true;
            }
            else
            {
                dataGridView6.Columns["satýþ fiyatý 3"].Visible = false;
            }
        }

        private void satis4Check_CheckedChanged(object sender, EventArgs e)
        {
            if (satis4Check.Checked == true)
            {
                dataGridView6.Columns["satýþ fiyatý 4"].Visible = true;
            }
            else
            {
                dataGridView6.Columns["satýþ fiyatý 4"].Visible = false;
            }
        }

        private void urunKodCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (urunKodCheck.Checked == true)
            {
                dataGridView6.Columns["ürün kodu"].Visible = true;
            }
            else
            {
                dataGridView6.Columns["ürün kodu"].Visible = false;
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
                dataGridView6.Columns["ürün açýklamasý"].Visible = true;
            }
            else
            {
                dataGridView6.Columns["ürün açýklamasý"].Visible = false;
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
                dataGridView6.Columns["Ürün Kategori"].Visible = true;
            }
            else
            {
                dataGridView6.Columns["Ürün Kategori"].Visible = false;
            }
        }

        private void devirCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (devirCheck.Checked == true)
            {
                dataGridView6.Columns["Devir Miktarý"].Visible = true;
            }
            else
            {
                dataGridView6.Columns["Devir Miktarý"].Visible = false;
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
                dataGridView6.Columns["giriþ tarihi"].Visible = true;
            }
            else
            {
                dataGridView6.Columns["giriþ tarihi"].Visible = false;
            }
        }

        private void cikisTarihiCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (cikisTarihiCheck.Checked == true)
            {
                dataGridView6.Columns["çýkýþ tarihi"].Visible = true;
            }
            else
            {
                dataGridView6.Columns["çýkýþ tarihi"].Visible = false;
            }
        }

        private void sonIslemCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (sonIslemCheck.Checked == true)
            {
                dataGridView6.Columns["son iþlem tarihi"].Visible = true;
            }
            else
            {
                dataGridView6.Columns["son iþlem tarihi"].Visible = false;
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
            TahsilatÝslemleri TahsilatÝslem = new TahsilatÝslemleri();
            TahsilatÝslem.ShowDialog();
        }

        private void SatisKisayolbuton14_Click(object sender, EventArgs e)
        {

        }
    }
}