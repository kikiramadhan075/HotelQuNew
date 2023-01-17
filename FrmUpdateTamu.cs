using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace penginapan
{
    public partial class FrmUpdateTamu : Form
    {
        public string nama, alamat, tlpn, jk, kerja;

        private void btnupdate_Click(object sender, EventArgs e)
        {
            string nama = nmTamu.Text.ToString();
            string alamat = alamatTamu.Text.ToString();
            string tlpn = telpon.Text.ToString();
            string jk = cmbJk.Text.ToString();
            string kerja = pekerjaan.Text.ToString();
            string koneksi = "server=localhost;database=db_penginapan;uid=root;password=";
            MySqlConnection koneksiB = new MySqlConnection(koneksi);
            MySqlCommand com = new MySqlCommand("call editTamu('" + nama + "','" + alamat + "','" + tlpn + "','" + jk + "','" + kerja + "')", koneksiB);
            try
            {
                MySqlDataAdapter adap = new MySqlDataAdapter(com);
                DataTable table = new DataTable();
                adap.Fill(table);
                MessageBox.Show("Data berhasil disimpan!!!");
                this.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
            }

        }

        public FrmUpdateTamu()

        {
            InitializeComponent();
        }

        private void FrmUpdateTamu_Load(object sender, EventArgs e)
        {

        }
    }
}
