using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA220228
{
    public partial class FrmKereso : Form
    {
        public FrmKereso()
        {
            InitializeComponent();
            UploadCB();
        }

        private void UploadCB()
        {
            using (var conn = new SqlConnection(Program.ConnectionString))
            {
                conn.Open();
                var r = new SqlCommand("SELECT nyelv FROM nyelvek",conn).ExecuteReader();
                while (r.Read())
                {
                    cb.Items.Add(r[0]);
                }
            }
        }

        private void cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvKereso.Rows.Clear();
            using (var conn = new SqlConnection(Program.ConnectionString))
            {
                conn.Open();
                var r = new SqlCommand(
                    "SELECT idopont, szint " +
                    "FROM nyelvek, vizsgak " +
                    "WHERE nyelvek.id = vizsgak.nyelvid " +
                    $"AND nyelv LIKE '{cb.Text}'",conn).ExecuteReader();
                while (r.Read())
                {
                    dgvKereso.Rows.Add(r[0],r[1]);
                }
            }
        }
    }
}
