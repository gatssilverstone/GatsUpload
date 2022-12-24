namespace sondeneme1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.miniToolStrip = new System.Windows.Forms.MenuStrip();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ayarlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.işlemlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.raporlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.whatsAppToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hakkımızdaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yardımToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.tabControl1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 60);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1180, 477);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.Location = new System.Drawing.Point(3, 2);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1174, 464);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Transparent;
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPage1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(1166, 436);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Satış Ekranı";
            // 
            // tabPage2
            // 
            this.tabPage2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Size = new System.Drawing.Size(1166, 436);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Müşteriler";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage3.Size = new System.Drawing.Size(1166, 436);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Ürünler";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 24);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage4.Size = new System.Drawing.Size(1166, 436);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Toptancı";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // miniToolStrip
            // 
            this.miniToolStrip.AccessibleName = "Yeni öğe seçimi";
            this.miniToolStrip.AccessibleRole = System.Windows.Forms.AccessibleRole.ComboBox;
            this.miniToolStrip.AutoSize = false;
            this.miniToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.miniToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.miniToolStrip.Location = new System.Drawing.Point(576, 3);
            this.miniToolStrip.Name = "miniToolStrip";
            this.miniToolStrip.Size = new System.Drawing.Size(1880, 31);
            this.miniToolStrip.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.menuStrip1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1180, 60);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(956, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(221, 54);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ayarlarToolStripMenuItem,
            this.işlemlerToolStripMenuItem,
            this.raporlarToolStripMenuItem,
            this.whatsAppToolStripMenuItem,
            this.hakkımızdaToolStripMenuItem,
            this.yardımToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(590, 27);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ayarlarToolStripMenuItem
            // 
            this.ayarlarToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ayarlarToolStripMenuItem.Name = "ayarlarToolStripMenuItem";
            this.ayarlarToolStripMenuItem.Size = new System.Drawing.Size(71, 23);
            this.ayarlarToolStripMenuItem.Text = "Ayarlar";
            // 
            // işlemlerToolStripMenuItem
            // 
            this.işlemlerToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.işlemlerToolStripMenuItem.Name = "işlemlerToolStripMenuItem";
            this.işlemlerToolStripMenuItem.Size = new System.Drawing.Size(74, 23);
            this.işlemlerToolStripMenuItem.Text = "İşlemler";
            // 
            // raporlarToolStripMenuItem
            // 
            this.raporlarToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.raporlarToolStripMenuItem.Name = "raporlarToolStripMenuItem";
            this.raporlarToolStripMenuItem.Size = new System.Drawing.Size(80, 23);
            this.raporlarToolStripMenuItem.Text = "Raporlar";
            // 
            // whatsAppToolStripMenuItem
            // 
            this.whatsAppToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.whatsAppToolStripMenuItem.Name = "whatsAppToolStripMenuItem";
            this.whatsAppToolStripMenuItem.Size = new System.Drawing.Size(90, 23);
            this.whatsAppToolStripMenuItem.Text = "WhatsApp";
            // 
            // hakkımızdaToolStripMenuItem
            // 
            this.hakkımızdaToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.hakkımızdaToolStripMenuItem.Name = "hakkımızdaToolStripMenuItem";
            this.hakkımızdaToolStripMenuItem.Size = new System.Drawing.Size(101, 23);
            this.hakkımızdaToolStripMenuItem.Text = "Hakkımızda";
            // 
            // yardımToolStripMenuItem
            // 
            this.yardımToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.yardımToolStripMenuItem.Name = "yardımToolStripMenuItem";
            this.yardımToolStripMenuItem.Size = new System.Drawing.Size(69, 23);
            this.yardımToolStripMenuItem.Text = "Yardım";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 541);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Zenoyap";
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private FileSystemWatcher fileSystemWatcher1;
        private FlowLayoutPanel flowLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel1;
        private MenuStrip miniToolStrip;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem ayarlarToolStripMenuItem;
        private ToolStripMenuItem işlemlerToolStripMenuItem;
        private ToolStripMenuItem raporlarToolStripMenuItem;
        private ToolStripMenuItem whatsAppToolStripMenuItem;
        private ToolStripMenuItem hakkımızdaToolStripMenuItem;
        private ToolStripMenuItem yardımToolStripMenuItem;
        private PictureBox pictureBox1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
    }
}