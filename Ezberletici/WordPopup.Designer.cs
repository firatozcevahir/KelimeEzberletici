namespace Ezberletici
{
    partial class WordPopup
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
            this.lblWord = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblWord
            // 
            this.lblWord.AutoSize = true;
            this.lblWord.BackColor = System.Drawing.Color.Transparent;
            this.lblWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblWord.Location = new System.Drawing.Point(-25, 31);
            this.lblWord.Name = "lblWord";
            this.lblWord.Padding = new System.Windows.Forms.Padding(35);
            this.lblWord.Size = new System.Drawing.Size(397, 106);
            this.lblWord.TabIndex = 0;
            this.lblWord.Text = "-----PLACEHOLDER----";
            this.lblWord.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblWord.Click += new System.EventHandler(this.lblWord_Click);
            this.lblWord.DoubleClick += new System.EventHandler(this.lblWord_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kelime Hatırlatıcı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label2.Location = new System.Drawing.Point(-1, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(357, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "___________________________________________-";
            // 
            // WordPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(347, 170);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblWord);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "WordPopup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "WordPopup";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.WordPopup_FormClosing);
            this.Load += new System.EventHandler(this.WordPopup_Load);
            this.Click += new System.EventHandler(this.WordPopup_Click);
            this.DoubleClick += new System.EventHandler(this.WordPopup_DoubleClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWord;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}