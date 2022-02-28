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
    public partial class FrmVizsgazo : Form
    {
        public string ID { get; set; }
        public FrmVizsgazo(bool modosithato)
        {
            InitializeComponent();
            Modosithato(modosithato);
            FirstTB();
        }

        public FrmVizsgazo(bool modosithato, string id)
        {
            InitializeComponent();
            Modosithato(modosithato);
            ID = id;
            Upload();
        }

        private void Upload()
        {
            using (var conn = new SqlConnection(Program.ConnectionString))
            {
                conn.Open();
                var r = new SqlCommand($"SELECT sorsz, nev, mobil, szulev FROM jelentkezesek WHERE sorsz = {ID};", conn).ExecuteReader();
                r.Read();
                tbID.Text = r[0].ToString();
                tbNev.Text = r[1].ToString();
                tbTelf.Text = r[2].ToString();
                tbSzul.Text = r[3].ToString();
            }
        }

        private void Modosithato(bool modosithato)
        {
            if (modosithato)
            {
                btnModositas.Enabled = true;
                btnTorles.Enabled = true;
                btnUj.Enabled = false;
            }
            else
            {
                btnModositas.Enabled = false;
                btnTorles.Enabled = false;
                btnUj.Enabled = true;
            }
        }

        private void FirstTB()
        {
            using (var conn = new SqlConnection(Program.ConnectionString))
            {
                conn.Open();
                var r = new SqlCommand("SELECT Max(sorsz)+1 FROM jelentkezesek;",conn).ExecuteReader();
                r.Read();
                tbID.Text = r[0].ToString();
            }
        }

        private void btnUj_Click(object sender, EventArgs e)
        {
            if (vizsgalat())
            {
                using (var conn = new SqlConnection(Program.ConnectionString))
                {
                    conn.Open();
                    var asd = new SqlCommand($"INSERT INTO jelentkezesek (sorsz, nev, mobil, szulev) VALUES ({tbID.Text}, '{tbNev.Text}', '{tbTelf.Text}', {tbSzul.Text});", conn);
                    asd.ExecuteNonQuery();
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Hibás adat felvétel!");
            }
        }


        private void btnModositas_Click(object sender, EventArgs e)
        {
            if (vizsgalat())
            {
                using (var conn = new SqlConnection(Program.ConnectionString))
                {
                    conn.Open();
                    new SqlCommand($"UPDATE jelentkezesek SET sorsz = {tbID.Text}, nev = '{tbNev.Text}', mobil = '{tbTelf.Text}', szulev = {tbSzul.Text} WHERE sorsz = {tbID.Text}", conn).ExecuteNonQuery();
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Hibás adat felvétel!");
            }
            
        }

        private void btnTorles_Click(object sender, EventArgs e)
        {
            if (vizsgalat())
            {
                using (var conn = new SqlConnection(Program.ConnectionString))
                {
                    conn.Open();
                    new SqlCommand($"DELETE FROM jelentkezesek WHERE sorsz = {tbID.Text}", conn).ExecuteNonQuery();
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Hibás adat felvétel!");
            }
        }

        private bool vizsgalat()
        {
            if (tbNev.Text != "" && tbTelf.Text.Count() == 8 && int.Parse(tbSzul.Text) <= DateTime.Now.Year)
                return true;
            else
                return false;
        }
    }
}
