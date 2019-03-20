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
            OleDbConnection conn = new OleDbConnection(connString);
            OleDbCommand command = new OleDbCommand();
            command.Connection = conn;
            command.CommandText = "SELECT * FROM Words";
            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
            using (var reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    MessageBox.Show(reader["Lang_TR"].ToString());
                }
            }
            
            conn.Close();
        }
    }
}
