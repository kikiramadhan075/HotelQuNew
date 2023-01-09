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
	/// Description of FrmTambahKamar.
	/// </summary>
	public partial class FrmTambahKamar : Form
	{
		public FrmTambahKamar()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void FrmTambahKamarLoad(object sender, EventArgs e)
		{
			string koneksi = "server=localhost;database=db_penginapan;uid=root;password=";
			MySqlConnection koneksiB = new MySqlConnection(koneksi);
			MySqlCommand com = new MySqlCommand("call TipeKamar()",koneksiB);
			MySqlDataAdapter adap = new MySqlDataAdapter(com);
			DataTable table = new DataTable();
			adap.Fill(table);
			foreach(DataRow kolom in table.Rows)
				{
					string id_tipe = kolom["id_tipe_kamar"].ToString();
					string nama = kolom["nama"].ToString();
					string gabung = id_tipe +" - "+ nama;
					cmbCariTipeKamar.Items.Add(gabung);
				}
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			this.Close();
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			string deskripsi = des.Text.ToString();
			string id = cmbCariTipeKamar.Text.ToString();
			string tipe = id.Substring(0,1);
			string status = "N";
			string koneksi = "server=localhost;database=db_penginapan;uid=root;password=";
			MySqlConnection koneksiB = new MySqlConnection(koneksi);
			MySqlCommand com = new MySqlCommand("call tambahKamar("+tipe+",'"+deskripsi+"','"+status+"')",koneksiB);
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
	}
}
