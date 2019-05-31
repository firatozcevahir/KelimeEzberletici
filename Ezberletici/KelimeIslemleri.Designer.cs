namespace Ezberletici
{
    partial class KelimeIslemleri
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KelimeIslemleri));
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.programToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.başlatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayarlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tmrWord = new System.Windows.Forms.Timer(this.components);
            this.ntfyTrayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.cntxMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuClose = new System.Windows.Forms.ToolStripMenuItem();
            this.lblWords = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.WordID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lang_EN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lang_TR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mainMenu.SuspendLayout();
            this.cntxMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.programToolStripMenuItem,
            this.ayarlarToolStripMenuItem,
            this.çıkışToolStripMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Padding = new System.Windows.Forms.Padding(12, 3, 0, 3);
            this.mainMenu.Size = new System.Drawing.Size(367, 30);
            this.mainMenu.TabIndex = 0;
            this.mainMenu.Text = "menuStrip1";
            // 
            // programToolStripMenuItem
            // 
            this.programToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.başlatToolStripMenuItem});
            this.programToolStripMenuItem.Name = "programToolStripMenuItem";
            this.programToolStripMenuItem.Size = new System.Drawing.Size(78, 24);
            this.programToolStripMenuItem.Text = "Program";
            // 
            // başlatToolStripMenuItem
            // 
            this.başlatToolStripMenuItem.Name = "başlatToolStripMenuItem";
            this.başlatToolStripMenuItem.Size = new System.Drawing.Size(124, 26);
            this.başlatToolStripMenuItem.Text = "Başlat";
            this.başlatToolStripMenuItem.Click += new System.EventHandler(this.başlatToolStripMenuItem_Click);
            // 
            // ayarlarToolStripMenuItem
            // 
            this.ayarlarToolStripMenuItem.Name = "ayarlarToolStripMenuItem";
            this.ayarlarToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
            this.ayarlarToolStripMenuItem.Text = "Ayarlar";
            this.ayarlarToolStripMenuItem.Click += new System.EventHandler(this.ayarlarToolStripMenuItem_Click);
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.çıkışToolStripMenuItem.Text = "Çıkış";
            this.çıkışToolStripMenuItem.Click += new System.EventHandler(this.çıkışToolStripMenuItem_Click);
            // 
            // tmrWord
            // 
            this.tmrWord.Interval = 1000;
            this.tmrWord.Tick += new System.EventHandler(this.tmrWord_Tick);
            // 
            // ntfyTrayIcon
            // 
            this.ntfyTrayIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.ntfyTrayIcon.BalloonTipText = "Kelime Ezberletici Çalışıyor";
            this.ntfyTrayIcon.BalloonTipTitle = "Kelime Ezberletici";
            this.ntfyTrayIcon.ContextMenuStrip = this.cntxMenu;
            this.ntfyTrayIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("ntfyTrayIcon.Icon")));
            this.ntfyTrayIcon.Text = "Kelime Ezberletici";
            this.ntfyTrayIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ntfyTrayIcon_MouseDoubleClick);
            // 
            // cntxMenu
            // 
            this.cntxMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cntxMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuClose});
            this.cntxMenu.Name = "cntxMenu";
            this.cntxMenu.Size = new System.Drawing.Size(109, 28);
            // 
            // menuClose
            // 
            this.menuClose.Name = "menuClose";
            this.menuClose.Size = new System.Drawing.Size(108, 24);
            this.menuClose.Text = "Çıkış";
            this.menuClose.Click += new System.EventHandler(this.menuClose_Click);
            // 
            // lblWords
            // 
            this.lblWords.AutoSize = true;
            this.lblWords.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblWords.Location = new System.Drawing.Point(12, 186);
            this.lblWords.Name = "lblWords";
            this.lblWords.Size = new System.Drawing.Size(117, 20);
            this.lblWords.TabIndex = 2;
            this.lblWords.Text = "Tüm Kelimeler";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.WordID,
            this.Lang_EN,
            this.Lang_TR});
            this.dataGridView1.Location = new System.Drawing.Point(12, 209);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(343, 254);
            this.dataGridView1.TabIndex = 3;
            // 
            // WordID
            // 
            this.WordID.HeaderText = "Word ID";
            this.WordID.Name = "WordID";
            this.WordID.ReadOnly = true;
            // 
            // Lang_EN
            // 
            this.Lang_EN.HeaderText = "EN";
            this.Lang_EN.Name = "Lang_EN";
            this.Lang_EN.ReadOnly = true;
            // 
            // Lang_TR
            // 
            this.Lang_TR.HeaderText = "TR";
            this.Lang_TR.Name = "Lang_TR";
            this.Lang_TR.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-36, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(617, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "_______________________________________________________";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(383, 60);
            this.label2.TabIndex = 5;
            this.label2.Text = "Bu Programda; ayarladığınız süreye göre rastgele \r\nİngilizce kelimeler ve Türkçe " +
    "karşılıkları\r\npopup olarak ekranınızda belirir.\r\n";
            // 
            // KelimeIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(367, 475);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblWords);
            this.Controls.Add(this.mainMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mainMenu;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "KelimeIslemleri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kelilme Hatırlatıcı";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.KelimeIslemleri_FormClosing);
            this.Load += new System.EventHandler(this.KelimeIslemleri_Load);
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.cntxMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenu;
        public System.Windows.Forms.ToolStripMenuItem ayarlarToolStripMenuItem;
        public System.Windows.Forms.Timer tmrWord;
        private System.Windows.Forms.NotifyIcon ntfyTrayIcon;
        private System.Windows.Forms.Label lblWords;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripMenuItem programToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem başlatToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn WordID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lang_EN;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lang_TR;
        private System.Windows.Forms.ContextMenuStrip cntxMenu;
        private System.Windows.Forms.ToolStripMenuItem menuClose;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

