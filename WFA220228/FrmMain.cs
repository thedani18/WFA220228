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
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
            dgvUpload();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgvUpload();
        }

        private void dgvUpload()
        {
            DGV.Rows.Clear();
            using (var conn = new SqlConnection(Program.ConnectionString))
            {
                conn.Open();
                var r = new SqlCommand($"SELECT jelentkezesek.sorsz, jelentkezesek.nev, nyelvek.nyelv,vizsgak.szint " +
                    $"FROM nyelvek,vizsgak,jelentkezesek " +
                    $"WHERE nyelvek.id = vizsgak.nyelvid " +
                    $"and vizsgak.sorsz = jelentkezesek.vizsga;", conn).ExecuteReader();
                while (r.Read())
                {
                    DGV.Rows.Add(r[0],r[1],r[2],r[3]);
                }
            }
        }

        private void MSUjVizsgazo_Click(object sender, EventArgs e) => new FrmVizsgazo(false).ShowDialog();

        private void DGV_CellContentClick(object sender, DataGridViewCellEventArgs e) => new FrmVizsgazo(true,DGV.CurrentRow.Cells[0].Value.ToString()).ShowDialog();

        private void MSVizsgak_Click(object sender, EventArgs e) => new FrmKereso().ShowDialog();
    }
}
