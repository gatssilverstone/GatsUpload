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
    }
}