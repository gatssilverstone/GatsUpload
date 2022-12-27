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

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlCommand cmd= new SqlCommand("select * from zenokodc_IstocPosPrototype.Urun_Bilgisi", SqlBaglanti.connect);

            SqlBaglanti.CheckConnection(SqlBaglanti.connect);
            SqlDataAdapter dataAdapter= new SqlDataAdapter(cmd);
            DataTable dt= new DataTable();  
            dataAdapter.Fill(dt);
            dataGridView1.DataSource= dt;
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
            Console.WriteLine("Hello world");
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
    }
}