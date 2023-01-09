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
	/// Description of FrmTambahPesanan.
	/// </summary>
	public partial class FrmTambahPesanan : Form
	{
		public FrmTambahPesanan()
		{
			InitializeComponent();
		}
		
		void TextBox1KeyDown(object sender, KeyEventArgs e)
		{
			string idtamu="";
			if (e.KeyCode == Keys.Return)
            {
              	string koneksi = "server=localhost;database=db_penginapan;uid=root;password=";
				MySqlConnection koneksiB = new MySqlConnection(koneksi);
				MySqlCommand com = new MySqlCommand("select * from tbl_reservasi left join (tbl_tamu,tbl_kamar,tbl_tipe_kamar) on tbl_reservasi.id_tamu=tbl_tamu.id_tamu and tbl_reservasi.id_kamar=tbl_kamar.id_kamar and tbl_reservasi.id_tipe_kamar=tbl_tipe_kamar.id_tipe_kamar where id_reservasi='"+idRs.Text+"' and tbl_reservasi.status='N'",koneksiB);
				MySqlDataAdapter adap = new MySqlDataAdapter(com);
				DataTable table = new DataTable();
				adap.Fill(table);
				koneksiB.Open();
				foreach(DataRow kolom in table.Rows)
				{
					idtamu = kolom["id_reservasi"].ToString();
				}
				if (idRs.Text == "")
                {
					MessageBox.Show("Kode salah");
                }
				else if(idRs.Text!=idtamu)
				{
					MessageBox.Show("Kode salah");
				}
                else
				{
					foreach(DataRow kolom in table.Rows)
						{
							nmTm.Text = kolom["nama_tamu"].ToString();
							nmKmr.Text = kolom["id_kamar"].ToString();
							ckIn.Text = kolom["tgl_cek_in"].ToString();
							ckOut.Text = kolom["tgl_cek_out"].ToString();
							tipe.Text = kolom["nama"].ToString();
						}
				}
				koneksiB.Close();
            }
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			string koneksi = "server=localhost;database=db_penginapan;uid=root;password=";
			MySqlConnection koneksiB = new MySqlConnection(koneksi);
			MySqlCommand com = new MySqlCommand("call CariReservasi",koneksiB);
			MySqlDataAdapter adap = new MySqlDataAdapter(com);
			DataTable table = new DataTable();
			adap.Fill(table);
			koneksiB.Open();
			tampil.DataSource = table;
			tampil.AllowUserToAddRows = false; // remove the null line
            tampil.ReadOnly = true;
            tampil.Columns[0].HeaderText = "ID Reservasi";
            tampil.Columns[0].Width = 100; //nama cd
            tampil.Columns[1].HeaderText = "Nama Tamu";
            tampil.Columns[1].Width = 190; //nama cd
            tampil.Columns[2].HeaderText = "Nomor Kamar";
            tampil.Columns[2].Width = 120; //tipe cd
            tampil.Columns[3].HeaderText = "Cek In";
            tampil.Columns[3].Width = 110; //tahun
            tampil.Columns[4].HeaderText = "Cek Out";
            tampil.Columns[4].Width = 110; //harga
			koneksiB.Close();
		}
		
		void FrmTambahPesananLoad(object sender, EventArgs e)
		{
			for(int i=1;i<=31;i++)
			{
				if(i<=9)
				{
					cmbTglReservasi.Items.Add("0"+i);
				}
				else
				{
					cmbTglReservasi.Items.Add(i);
				}
			}
			for(int j=1;j<=12;j++)
			{
				if(j<=9)
				{
					cmbBlnReservasi.Items.Add("0"+j);
				}
				else
				{
					cmbBlnReservasi.Items.Add(j);
				}
			}
			for(int k=2009;k<=2015;k++)
			{
				if(k<=9)
				{
					cmbThnReservasi.Items.Add("0"+k);
				}
				else
				{
					cmbThnReservasi.Items.Add(k);
				}
			}
		}
		
		void Button3Click(object sender, EventArgs e)
		{
			string koneksi = "server=localhost;database=db_penginapan;uid=root;password=";
			string no_kamar = cariByNoKamar.Text.ToString();
			MySqlConnection koneksiB = new MySqlConnection(koneksi);
			MySqlCommand com = new MySqlCommand("call CariReservasiBerdasarkanKamar2("+no_kamar+")",koneksiB);
			try {
				MySqlDataAdapter adap = new MySqlDataAdapter(com);
				DataTable table = new DataTable();
				adap.Fill(table);
				koneksiB.Open();
				tampil.DataSource = table;
			} catch (Exception err) {
				MessageBox.Show(err.ToString());
			}
			tampil.AllowUserToAddRows = false; // remove the null line
            tampil.ReadOnly = true;
            tampil.Columns[0].HeaderText = "ID Reservasi";
            tampil.Columns[0].Width = 100; //nama cd
            tampil.Columns[1].HeaderText = "Nama Tamu";
            tampil.Columns[1].Width = 190; //nama cd
            tampil.Columns[2].HeaderText = "Nomor Kamar";
            tampil.Columns[2].Width = 120; //tipe cd
            tampil.Columns[3].HeaderText = "Cek In";
            tampil.Columns[3].Width = 110; //tahun
            tampil.Columns[4].HeaderText = "Cek Out";
            tampil.Columns[4].Width = 110; //harga
			koneksiB.Close();
		}
		
		void Button4Click(object sender, EventArgs e)
		{
			string koneksi = "server=localhost;database=db_penginapan;uid=root;password=";
			string nama = cariByNamaTamu.Text.ToString();
			MySqlConnection koneksiB = new MySqlConnection(koneksi);
			MySqlCommand com = new MySqlCommand("select id_reservasi, nama_tamu, tbl_kamar.id_kamar, tgl_cek_in, tgl_cek_out from tbl_reservasi left join (tbl_kamar, tbl_tamu, tbl_tipe_kamar) on tbl_reservasi.id_kamar=tbl_kamar.id_kamar and tbl_reservasi.id_tamu=tbl_tamu.id_tamu and tbl_reservasi.id_tipe_kamar=tbl_tipe_kamar.id_tipe_kamar where tbl_tamu.nama_tamu like '%"+nama+"%' and tbl_reservasi.status='N'",koneksiB);
			try {
				MySqlDataAdapter adap = new MySqlDataAdapter(com);
				DataTable table = new DataTable();
				adap.Fill(table);
				koneksiB.Open();
				tampil.DataSource = table;
			} catch (Exception err) {
				MessageBox.Show(err.ToString());
			}
			tampil.AllowUserToAddRows = false; // remove the null line
            tampil.ReadOnly = true;
            tampil.Columns[0].HeaderText = "ID Reservasi";
            tampil.Columns[0].Width = 100; //nama cd
            tampil.Columns[1].HeaderText = "Nama Tamu";
            tampil.Columns[1].Width = 190; //nama cd
            tampil.Columns[2].HeaderText = "Nomor Kamar";
            tampil.Columns[2].Width = 120; //tipe cd
            tampil.Columns[3].HeaderText = "Cek In";
            tampil.Columns[3].Width = 110; //tahun
            tampil.Columns[4].HeaderText = "Cek Out";
            tampil.Columns[4].Width = 110; //harga
			koneksiB.Close();
		}
		
		void Button5Click(object sender, EventArgs e)
		{
			string tgl = cmbTglReservasi.Text;
			string bln = cmbBlnReservasi.Text;
			string thn = cmbThnReservasi.Text;
			string gabung = tgl +"/"+ bln +"/"+ thn;
			cariCekInCekOut("tgl_cek_in",gabung);
		}
		
		void Button6Click(object sender, EventArgs e)
		{
			string tgl = cmbTglReservasi.Text;
			string bln = cmbBlnReservasi.Text;
			string thn = cmbThnReservasi.Text;
			string gabung = tgl +"/"+ bln +"/"+ thn;
			cariCekInCekOut("tgl_cek_out",gabung);
		}
		public void cariCekInCekOut(string ket, string gabung)
		{
			string koneksi = "server=localhost;database=db_penginapan;uid=root;password=";
			string nama = cariByNamaTamu.Text.ToString();
			MySqlConnection koneksiB = new MySqlConnection(koneksi);
			MySqlCommand com = new MySqlCommand("select id_reservasi, nama_tamu, tbl_kamar.id_kamar, tgl_cek_in, tgl_cek_out from tbl_reservasi left join (tbl_kamar, tbl_tamu, tbl_tipe_kamar) on tbl_reservasi.id_kamar=tbl_kamar.id_kamar and tbl_reservasi.id_tamu=tbl_tamu.id_tamu and tbl_reservasi.id_tipe_kamar=tbl_tipe_kamar.id_tipe_kamar where "+ket+"='"+gabung+"' and tbl_reservasi.status='N'",koneksiB);
			try {
				MySqlDataAdapter adap = new MySqlDataAdapter(com);
				DataTable table = new DataTable();
				adap.Fill(table);
				koneksiB.Open();
				tampil.DataSource = table;
			} catch (Exception err) {
				MessageBox.Show(err.ToString());
			}
			tampil.AllowUserToAddRows = false; // remove the null line
            tampil.ReadOnly = true;
            tampil.Columns[0].HeaderText = "ID Reservasi";
            tampil.Columns[0].Width = 100; //nama cd
            tampil.Columns[1].HeaderText = "Nama Tamu";
            tampil.Columns[1].Width = 190; //nama cd
            tampil.Columns[2].HeaderText = "Nomor Kamar";
            tampil.Columns[2].Width = 120; //tipe cd
            tampil.Columns[3].HeaderText = "Cek In";
            tampil.Columns[3].Width = 110; //tahun
            tampil.Columns[4].HeaderText = "Cek Out";
            tampil.Columns[4].Width = 110; //harga
			koneksiB.Close();
		}
		
		void IdMnKeyDown(object sender, KeyEventArgs e)
		{
			string idtamu="";
			if (e.KeyCode == Keys.Return)
            {
              	string koneksi = "server=localhost;database=db_penginapan;uid=root;password=";
				MySqlConnection koneksiB = new MySqlConnection(koneksi);
				MySqlCommand com = new MySqlCommand("select * from tbl_menu where id_menu='"+idMn.Text+"'",koneksiB);
				MySqlDataAdapter adap = new MySqlDataAdapter(com);
				DataTable table = new DataTable();
				adap.Fill(table);
				koneksiB.Open();
				foreach(DataRow kolom in table.Rows)
				{
					idtamu = kolom["id_menu"].ToString();
				}
				if (idMn.Text == "")
                {
					MessageBox.Show("Kode salah");
                }
				else if(idMn.Text!=idtamu)
				{
					MessageBox.Show("Kode salah");
				}
                else
				{
					foreach(DataRow kolom in table.Rows)
						{
							nmMenu.Text = kolom["nama"].ToString();
							hrgMenu.Text = kolom["harga"].ToString();
						}
				}
				koneksiB.Close();
            }
		}
		
		void Button7Click(object sender, EventArgs e)
		{
			if(bnyk.Text.ToString() != "")
			{
				int bnykPesanan;
				int bnykPsn = Convert.ToInt32(bnyk.Text.ToString());
				int hrga = Convert.ToInt32(hrgMenu.Text.ToString());
				int total = bnykPsn * hrga;
				bnykPesanan = listPesanan.Rows.Count;
				listPesanan.Rows.Insert(bnykPesanan-1,1);
				listPesanan[0,bnykPesanan-1].Value = nmMenu.Text;
				listPesanan[1,bnykPesanan-1].Value = idMn.Text;
				listPesanan[2,bnykPesanan-1].Value = hrgMenu.Text;
				listPesanan[3,bnykPesanan-1].Value = bnyk.Text;
				listPesanan[4,bnykPesanan-1].Value = total;
				nmMenu.Text = "";
				idMn.Text = "";
				hrgMenu.Text = "";
				bnyk.Text = "";
			}
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			FrmTambahMenu f7 = new FrmTambahMenu();
			f7.Show();
		}
		
		void ListPesananCellClick(object sender, DataGridViewCellEventArgs e)
		{
			int baris;
			try {
				baris = listPesanan.CurrentCell.RowIndex;
				if (listPesanan.CurrentCell.ColumnIndex == 5) {
					listPesanan.Rows.RemoveAt(baris);
				}
			} catch (Exception) {
				MessageBox.Show("Upzzz, record yang anda hapus masih kosong!");
			}
		}
		
		void Button8Click(object sender, EventArgs e)
		{
			int bnykData;
			int total=0;
			bnykData = listPesanan.Rows.Count;
			for (int i=0;i<bnykData-1 ;i++ ) {
				total = Convert.ToInt32(total + Convert.ToInt32(listPesanan[4,i].Value));
			}
			totalSemua.Text = total.ToString();
		}
		
		void Button9Click(object sender, EventArgs e)
		{
			int bnykData;
			bnykData = listPesanan.Rows.Count;
			string id_res = idRs.Text.ToString();
			string tgl = DateTime.Now.ToString();
			string koneksi = "server=localhost;database=db_penginapan;uid=root;password=";
			MySqlConnection koneksiB = new MySqlConnection(koneksi);
			try {
				for (int i=0;i<bnykData-1 ;i++ ) 
				{
					MySqlCommand com = new MySqlCommand("call TambahPesanan("+id_res+","+listPesanan[1,i].Value.ToString()+","+listPesanan[3,i].Value.ToString()+",'"+tgl+"')",koneksiB);
					MySqlDataAdapter adap = new MySqlDataAdapter(com);
					DataTable table = new DataTable();
					adap.Fill(table);
				}
				MessageBox.Show("Data berhasil disimpan!!!");
				this.Close();
			} catch (Exception err) {
				MessageBox.Show(err.ToString());
			}
		}
	}
}
