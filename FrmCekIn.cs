/*
 * Created by Kiki Ramadhan.
 * User: kikiramadhan075
 * Date: Date: 08/01/2023
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Windows.Forms;
using System.Data;
using MySql.Data.MySqlClient;

namespace penginapan
{
	/// <summary>
	/// Description of FrmCekIn.
	/// </summary>
	public partial class FrmCekIn : Form
	{
		public string idUser;
		public FrmCekIn()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void TextBox1KeyDown(object sender, KeyEventArgs e)
		{
			string idtamu="";
			if (e.KeyCode == Keys.Return)
            {
              	string koneksi = "server=localhost;database=db_penginapan;uid=root;password=";
				MySqlConnection koneksiB = new MySqlConnection(koneksi);
				MySqlCommand com = new MySqlCommand("select * from tbl_tamu where id_tamu='"+idTamu.Text+"'",koneksiB);
				MySqlDataAdapter adap = new MySqlDataAdapter(com);
				DataTable table = new DataTable();
				adap.Fill(table);
				koneksiB.Open();
				foreach(DataRow kolom in table.Rows)
				{
					idtamu = kolom["id_tamu"].ToString();
				}
				if (idTamu.Text == "")
                {
					MessageBox.Show("Kode salah");
                }
				else if(idTamu.Text!=idtamu)
				{
					MessageBox.Show("Kode salah");
				}
                else
				{
					foreach(DataRow kolom in table.Rows)
						{
							namaTamu.Text = kolom["nama_tamu"].ToString();
							noTelpon.Text = kolom["no_telpon"].ToString();
							alamatTamu.Text = kolom["alamat"].ToString();
						}
				}
				koneksiB.Close();
            }
		}
		
		void IdTipeKeyDown(object sender, KeyEventArgs e)
		{
			string idtipe="";
			if (e.KeyCode == Keys.Return)
            {
              	string koneksi = "server=localhost;database=db_penginapan;uid=root;password=";
				MySqlConnection koneksiB = new MySqlConnection(koneksi);
				MySqlCommand com = new MySqlCommand("select * from tbl_tipe_kamar where id_tipe_kamar='"+idTipe.Text+"'",koneksiB);
				MySqlDataAdapter adap = new MySqlDataAdapter(com);
				DataTable table = new DataTable();
				adap.Fill(table);
				koneksiB.Open();
				foreach(DataRow kolom in table.Rows)
				{
					idtipe = kolom["id_tipe_kamar"].ToString();
				}
				if (idTipe.Text == "")
                {
					MessageBox.Show("Kode salah");
                }
				else if(idTipe.Text!=idtipe)
				{
					MessageBox.Show("Kode salah");
				}
                else
				{
					foreach(DataRow kolom in table.Rows)
						{
							namaTipe.Text = kolom["nama"].ToString();
							hargaKamar.Text = kolom["harga"].ToString();
						}
				}
				
				MySqlCommand com2 = new MySqlCommand("select * from tbl_kamar where id_tipe_kamar='"+idTipe.Text+"' and status='N'",koneksiB);
				MySqlDataAdapter adap2 = new MySqlDataAdapter(com2);
				DataTable table2 = new DataTable();
				adap2.Fill(table2);
				cmbNoKamar.Items.Clear();
				foreach(DataRow kolom2 in table2.Rows)
					{
						cmbNoKamar.Items.Add(kolom2["id_kamar"].ToString());
						deskripsiKamar.Text = kolom2["deskripsi"].ToString();
					}
				koneksiB.Close();
            }
		}
		
		void Button3Click(object sender, EventArgs e)
		{
			string id_tamu = idTamu.Text.ToString();
			string id_tipe = idTipe.Text.ToString();
			string id_user = idUser.ToString();
			string id_kamar = cmbNoKamar.Text.ToString();
			string cek_in2 = dateCekIn.Text.ToString();
			string cek_out2 = dateCekOut.Text.ToString();
			DateTime cek_in = Convert.ToDateTime(dateCekIn.Text);
			DateTime cek_out = Convert.ToDateTime(dateCekOut.Text);
			TimeSpan lama = cek_out.Subtract(cek_in);
			string koneksi = "server=localhost;database=db_penginapan;uid=root;password=";
			MySqlConnection koneksiB = new MySqlConnection(koneksi);
			MySqlCommand com = new MySqlCommand("call tambahReservasi("+id_tamu+","+id_user+","+id_tipe+","+id_kamar+",'"+cek_in2+"','"+cek_out2+"', "+lama.Days+")",koneksiB);
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
		void Button4Click(object sender, EventArgs e)
		{
			this.Close();
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			FrmLihatTamu f10 = new FrmLihatTamu();
			f10.Show();
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			FrmLihatTipe f11 = new FrmLihatTipe();
			f11.Show();
		}
	}
}
