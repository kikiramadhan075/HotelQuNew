/*
 * Created by Zhafran.
 * User: Zhafran
 * Date: Date: 08/01/2023
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using MySql.Data.MySqlClient;

namespace penginapan
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void Button1Click(object sender, EventArgs e)
		{
				try {
					string usr = usrName.Text.ToString();
					string psw = psWord.Text.ToString();
					string id_usr = "";
					string nm_usr = "";
					string username = "";
					string koneksi = "server=localhost;database=db_penginapan;uid=root;password=";
					MySqlConnection koneksiB = new MySqlConnection(koneksi);
					MySqlCommand com = new MySqlCommand("select * from tbl_user where username='"+usr+"' and password='"+psw+"'",koneksiB);
					MySqlDataAdapter adap = new MySqlDataAdapter(com);
					DataTable table = new DataTable();
					adap.Fill(table);
					koneksiB.Open();
					foreach(DataRow kolom in table.Rows)
					{
						id_usr = kolom["id_user"].ToString();
						nm_usr = kolom["nama_lengkap"].ToString();
						username = kolom["username"].ToString();
					}
					if (table.Rows.Count>0) 
					{
						FrmPenginapan f1 = new FrmPenginapan();
						f1.id_user = id_usr;
						f1.namaUser = nm_usr;
						f1.userName = username;
						f1.Show();
						this.Hide();
					}
					else{
						MessageBox.Show("Uppppzzzz...!!!!\nPassword dan Username salah....!!!!","Terjadi Error Coy...!!!!");
					}
					koneksiB.Close();
					} catch (Exception err) {
						MessageBox.Show(err.ToString());
					}
		}
	}
}
