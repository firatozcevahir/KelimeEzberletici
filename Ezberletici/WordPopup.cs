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
            InitializeComponent();
        }

        private void WordPopup_Load(object sender, EventArgs e)
        {
            WordAccess wordAccess = new WordAccess();
            word = wordAccess.GetRandomWord();
            f.tmrWord.Stop();
            lblWord.Text = word.WordEN;
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
    }
}
