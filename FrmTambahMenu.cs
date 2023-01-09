/*
 * Created by Kiki Ramadhan.
 * User: kikiramadhan075
 * Date: Date: 08/01/2023
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
	/// Description of FrmTambahMenu.
	/// </summary>
	public partial class FrmTambahMenu : Form
	{
		public FrmTambahMenu()
		{
			InitializeComponent();
		}
		
		void Button3Click(object sender, EventArgs e)
		{
			string nm = nama.Text.ToString();
			string hrg = harga.Text.ToString();
			string koneksi = "server=localhost;database=db_penginapan;uid=root;password=";
			MySqlConnection koneksiB = new MySqlConnection(koneksi);
			MySqlCommand com = new MySqlCommand("call TambahMenu('"+nm+"','"+hrg+"')",koneksiB);
			try {
				MySqlDataAdapter adap = new MySqlDataAdapter(com);
				DataTable table = new DataTable();
				adap.Fill(table);
				MessageBox.Show("Data berhasil disimpan!!!");
			} catch (Exception err) {
				MessageBox.Show(err.ToString());
			}
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			string koneksi = "server=localhost;database=db_penginapan;uid=root;password=";
			MySqlConnection koneksiB = new MySqlConnection(koneksi);
			MySqlCommand com = new MySqlCommand("call TampilMenu()",koneksiB);
			try {
				MySqlDataAdapter adap = new MySqlDataAdapter(com);
				DataTable table = new DataTable();
				adap.Fill(table);
				tampil.DataSource = table;
				tampil.AllowUserToAddRows = false; // remove the null line
	            tampil.ReadOnly = true;
	            tampil.Columns[0].HeaderText = "ID";
	            tampil.Columns[0].Width = 30; 
	            tampil.Columns[1].HeaderText = "Nama Makanan";
	            tampil.Columns[1].Width = 200; 
	            tampil.Columns[2].HeaderText = "Harga Makanan";
	            tampil.Columns[2].Width = 120; 
			} catch (Exception err) {
				MessageBox.Show(err.ToString());
			}
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			string nm = cariMenu.Text.ToString();
			string koneksi = "server=localhost;database=db_penginapan;uid=root;password=";
			MySqlConnection koneksiB = new MySqlConnection(koneksi);
			MySqlCommand com = new MySqlCommand("select * from tbl_menu where nama like '%"+nm+"%'",koneksiB);
			try {
				MySqlDataAdapter adap = new MySqlDataAdapter(com);
				DataTable table = new DataTable();
				adap.Fill(table);
				tampil.DataSource = table;
				tampil.AllowUserToAddRows = false; // remove the null line
	            tampil.ReadOnly = true;
	            tampil.Columns[0].HeaderText = "ID";
	            tampil.Columns[0].Width = 30; 
	            tampil.Columns[1].HeaderText = "Nama Makanan";
	            tampil.Columns[1].Width = 200; 
	            tampil.Columns[2].HeaderText = "Harga Makanan";
	            tampil.Columns[2].Width = 120; 
			} catch (Exception err) {
				MessageBox.Show(err.ToString());
			}
		}
	}
}
