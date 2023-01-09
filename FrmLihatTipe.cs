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
using MySql.Data.MySqlClient;
using System.Data;

namespace penginapan
{
	/// <summary>
	/// Description of FrmLihatTipe.
	/// </summary>
	public partial class FrmLihatTipe : Form
	{
		public FrmLihatTipe()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void FrmLihatTipeLoad(object sender, EventArgs e)
		{
			string koneksi = "server=localhost;database=db_penginapan;uid=root;password=";
			MySqlConnection koneksiB = new MySqlConnection(koneksi);
			MySqlCommand com = new MySqlCommand("call LihatTipe()",koneksiB);
			MySqlDataAdapter adap = new MySqlDataAdapter(com);
            tampil.Columns.Clear(); // <-- clear columns
			DataTable table = new DataTable();
			adap.Fill(table);
			tampil.DataSource = table;
			tampil.AllowUserToAddRows = false; // remove the null line
            tampil.ReadOnly = true;
            tampil.Columns[0].HeaderText = "ID Tipe Kamar";
            tampil.Columns[0].Width = 100; 
            tampil.Columns[1].HeaderText = "Nama Tipe Kamar";
            tampil.Columns[1].Width = 170;
		}
	}
}
