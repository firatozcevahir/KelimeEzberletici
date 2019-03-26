using ApplicationConfig;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WordOperations;

namespace Ezberletici
{
    public partial class WordPopup : Form
    {
        protected override CreateParams CreateParams
        {
            get
            {
                const int CS_DROPSHADOW = 0x20000;
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }
        }
        Words word = new Words();
        KelimeIslemleri f = new KelimeIslemleri();
        public WordPopup()
        {
            Left = 45;
            Top = 45;
            TopMost = true;
            ShowInTaskbar = false;
            InitializeComponent();
        }
        private string RandomBgColor()
        {
            string[] colors = {"#8fd6e8", "#bbf2a9", "#efeea0", "#edb784", "#c383f7", "#f484e3", "#95af8e", "#a59e86", "#e5a2a0", "#d49ee5"};
            Random rnd = new Random();
            return colors[rnd.Next(0, colors.Count())];
        }

        private void WordPopup_Load(object sender, EventArgs e)
        {
            System.Media.SoundPlayer popupPlayer = new System.Media.SoundPlayer("sound-effect-pop-up.wav");
            popupPlayer.Play();

            BackColor = ColorTranslator.FromHtml(RandomBgColor());

            WordAccess wordAccess = new WordAccess();
            word = wordAccess.GetRandomWord();
            lblWord.Text = word.WordEN;
            GeneralConfig config = new GeneralConfig();
            ConfigProperties properties = config.ReadConfigFromFile();
            tmrPopup.Interval = properties.PopUpRemainingTime;
            tmrPopup.Start();

        }

        private void WordPopup_Click(object sender, EventArgs e)
        {
            ToggleLanguages();
        }

        private void lblWord_Click(object sender, EventArgs e)
        {
            ToggleLanguages();
        }

        private void ToggleLanguages()
        {
            if (lblWord.Text == word.WordTR)
                lblWord.Text = word.WordEN;
            else
                lblWord.Text = word.WordTR;
        }

        private void WordPopup_DoubleClick(object sender, EventArgs e)
        {
            Close();
        }

        private void lblWord_DoubleClick(object sender, EventArgs e)
        {
            Close();
        }

        private void WordPopup_FormClosing(object sender, FormClosingEventArgs e)
        {
            f.ExecuteProgramConfig();
            f.tmrWord.Start();
        }
        private bool mouseDown;
        private Point lastLocation;

        private void WordPopup_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void WordPopup_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void WordPopup_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void tmrPopup_Tick(object sender, EventArgs e)
        {
            tmrPopup.Stop();
            Close();
        }

        private void WordPopup_MouseEnter(object sender, EventArgs e)
        {
            tmrPopup.Stop();
        }

        private void WordPopup_MouseLeave(object sender, EventArgs e)
        {
            tmrPopup.Interval = 2000;
            tmrPopup.Start();
        }
    }
}
