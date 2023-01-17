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
using MySql.Data.MySqlClient;
using System.Data;

namespace penginapan
{
	/// <summary>
	/// Description of FrmLihatTamu.
	/// </summary>
	public partial class FrmLihatTamu : Form
	{
		public FrmLihatTamu()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void FrmLihatTamuLoad(object sender, EventArgs e)
		{
			string koneksi = "server=localhost;database=db_penginapan;uid=root;password=";
			MySqlConnection koneksiB = new MySqlConnection(koneksi);
			MySqlCommand com = new MySqlCommand("call LihatTamu()",koneksiB);
			MySqlDataAdapter adap = new MySqlDataAdapter(com);
            tampil.Columns.Clear(); // <-- clear columns
			DataTable table = new DataTable();
			adap.Fill(table);
			tampil.DataSource = table;
			tampil.AllowUserToAddRows = false; // remove the null line
            tampil.ReadOnly = true;
            tampil.Columns[0].HeaderText = "ID Tamu";
            tampil.Columns[0].Width = 150; 
            tampil.Columns[1].HeaderText = "Nama Tamu";
            tampil.Columns[1].Width = 200; 
            tampil.Columns[2].HeaderText = "No Telepon";
            tampil.Columns[2].Width = 140; 
		}
		
		void Button16Click(object sender, EventArgs e)
		{
			string nama = nmTamu.Text.ToString();
			string koneksi = "server=localhost;database=db_penginapan;uid=root;password=";
			MySqlConnection koneksiB = new MySqlConnection(koneksi);
			MySqlCommand com = new MySqlCommand("select id_tamu, nama_tamu, no_telpon from tbl_tamu where nama_tamu like '%"+nama+"%'",koneksiB);
			MySqlDataAdapter adap = new MySqlDataAdapter(com);
            tampil.Columns.Clear(); // <-- clear columns
			DataTable table = new DataTable();
			adap.Fill(table);
			tampil.DataSource = table;
			tampil.AllowUserToAddRows = false; // remove the null line
            tampil.ReadOnly = true;
            tampil.Columns[0].HeaderText = "ID Tamu";
            tampil.Columns[0].Width = 150; 
            tampil.Columns[1].HeaderText = "Nama Tamu";
            tampil.Columns[1].Width = 200; 
            tampil.Columns[2].HeaderText = "No Telepon";
            tampil.Columns[2].Width = 140; 
		}
		
		void Button15Click(object sender, EventArgs e)
		{
			string almt = almtTamu.Text.ToString();
			string koneksi = "server=localhost;database=db_penginapan;uid=root;password=";
			MySqlConnection koneksiB = new MySqlConnection(koneksi);
			MySqlCommand com = new MySqlCommand("select id_tamu, nama_tamu, no_telpon from tbl_tamu where alamat like '%"+almt+"%'",koneksiB);
			MySqlDataAdapter adap = new MySqlDataAdapter(com);
            tampil.Columns.Clear(); // <-- clear columns
			DataTable table = new DataTable();
			adap.Fill(table);
			tampil.DataSource = table;
			tampil.AllowUserToAddRows = false; // remove the null line
            tampil.ReadOnly = true;
            tampil.Columns[0].HeaderText = "ID Tamu";
            tampil.Columns[0].Width = 150; 
            tampil.Columns[1].HeaderText = "Nama Tamu";
            tampil.Columns[1].Width = 200; 
            tampil.Columns[2].HeaderText = "No Telepon";
            tampil.Columns[2].Width = 140; 
		}

        private void tampil_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
			
        }
    }
}
