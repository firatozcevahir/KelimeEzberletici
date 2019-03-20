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
            string connString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=KelimeEzberleticiDb.accdb;Persist Security Info=False;";
        }

        private void ayarlarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ayarlar ayarFrm = new Ayarlar();
            ayarFrm.StartPosition = FormStartPosition.Manual;
            ayarFrm.Left = this.Left + this.Width + 10;
            ayarFrm.Top = this.Top;
            ayarFrm.Height = this.Height;

            ayarFrm.Show();
        }
    }
}
