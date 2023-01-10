/*
 * Created by Andra.
 * User: Mahendrasyah
 * Date: 08/01/2023
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using MySql.Data.MySqlClient;

namespace penginapan
{
	/// <summary>
	/// Description of FrmTambahTamu.
	/// </summary>
	public partial class FrmTambahTamu : Form
	{
		public FrmTambahTamu()
		{
			InitializeComponent();
		}
		
		void Button3Click(object sender, EventArgs e)
		{
			string nama = nmTamu.Text.ToString();
			string alamat = alamatTamu.Text.ToString();
			string tlpn = telpon.Text.ToString();
			string jk = cmbJk.Text.ToString();
			string kerja = pekerjaan.Text.ToString();
			string koneksi = "server=localhost;database=db_penginapan;uid=root;password=";
			MySqlConnection koneksiB = new MySqlConnection(koneksi);
			MySqlCommand com = new MySqlCommand("call tambahTamu('"+nama+"','"+alamat+"','"+tlpn+"','"+jk+"','"+kerja+"')",koneksiB);
			try {
				MySqlDataAdapter adap = new MySqlDataAdapter(com);
				DataTable table = new DataTable();
				adap.Fill(table);
				MessageBox.Show("Data berhasil disimpan!!!");
				this.Close();
			} catch (Exception err) {
				MessageBox.Show(err.ToString());
			}
		}

        private void FrmTambahTamu_Load(object sender, EventArgs e)
        {

        }
    }
}
