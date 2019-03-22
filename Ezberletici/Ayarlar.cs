using ApplicationConfig;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ezberletici
{
    public partial class Ayarlar : Form
    {
        public Ayarlar()
        {
            InitializeComponent();
        }

        private void trckInterval_Scroll(object sender, EventArgs e)
        {


            int value = (sender as TrackBar).Value;
            double indexDbl = value * 1.0 / trckInterval.TickFrequency;
            int index = Convert.ToInt32(Math.Round(indexDbl));
            trckInterval.Value = trckInterval.TickFrequency * index;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            GeneralConfig config = new GeneralConfig();
            bool ConfigResult = config.SetConfig(trckInterval.Value);
            if (ConfigResult)
            {
                MessageBox.Show("Ayarlar Başarıyla Güncellendi");
            }
            else
                MessageBox.Show("Ayarlar Kaydedilirken Bir Hata Oluştu");
        }

        private void Ayarlar_Load(object sender, EventArgs e)
        {
            GeneralConfig config = new GeneralConfig();
            ConfigProperties properties = config.ReadConfigFromFile();
            trckInterval.Value = properties.WordInterval / 60000;
        }

        private void Ayarlar_FormClosing(object sender, FormClosingEventArgs e)
        {
           // KelimeIslemleri f = new KelimeIslemleri();
        }
    }
}
