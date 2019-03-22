using ApplicationConfig;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WordOperations;

namespace Ezberletici
{
    public partial class KelimeIslemleri : Form
    {
        public KelimeIslemleri()
        {
            InitializeComponent();
        }
        private void KelimeIslemleri_Load(object sender, EventArgs e)
        {
            WordAccess wordAccess = new WordAccess();
            List<Words> wordList = wordAccess.GetAllWords();
            foreach (var item in wordList)
                dataGridView1.Rows.Add(item.WordID, item.WordEN, item.WordTR);
            
        }
        public void ExecuteProgramConfig()
        {
            GeneralConfig config = new GeneralConfig();
            ConfigProperties properties = config.ReadConfigFromFile();
            tmrWord.Interval = properties.WordInterval;
            //tmrWord.Interval = 1000; //Hızlı Deneme
        }

        private void ayarlarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ayarlar ayarFrm = new Ayarlar
            {
                StartPosition = FormStartPosition.Manual,
                Left = Left + Width + 10,
                Top = Top
            };
            ayarFrm.Show();
        }

        private void tmrWord_Tick(object sender, EventArgs e)
        {
            WordPopup popup = new WordPopup();
            popup.Show();
            tmrWord.Stop();
        }

        private void başlatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExecuteProgramConfig();
            başlatToolStripMenuItem.Enabled = false;
            tmrWord.Start();
        }

        private void KelimeIslemleri_FormClosing(object sender, FormClosingEventArgs e)
        {
            ntfyTrayIcon.Visible = true;
            e.Cancel = true;
            Hide();
        }

        private void ntfyTrayIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ntfyTrayIcon.Visible = false;
            ntfyTrayIcon.Icon = null;
            Show();
        }

        private void durdurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tmrWord.Stop();
            başlatToolStripMenuItem.Enabled = true;
            durdurToolStripMenuItem.Enabled = false;
        }
    }
}
