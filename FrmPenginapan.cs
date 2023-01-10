/*
 * Created by Zhafran.
 * User: Zhafran
 * Date: Date: 08/01/2023
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using MySql.Data.MySqlClient;
using System.IO;
using ClosedXML.Excel;
using System.Collections.Generic;

namespace penginapan
{
	/// <summary>
	/// Description of FrmPenginapan.
	/// </summary>
	public partial class FrmPenginapan : Form
	{
		DataGridViewButtonColumn CekOut;
		DataGridViewButtonColumn EditTamu;
		DataGridViewButtonColumn DeleteTamu;
		public string id_user, namaUser, userName;
		public FrmPenginapan()
		{
			InitializeComponent();
		}
		
		void CekInClick(object sender, EventArgs e)
		{
			FrmCekIn f2 = new FrmCekIn();
			f2.idUser = id_user;
			f2.Show();
		}
		
		void FrmPenginapanLoad(object sender, EventArgs e)
		{
			for(int i=1;i<=31;i++)
			{
				if(i<=9)
				{
					cmbTglReservasi.Items.Add("0"+i);
					cmbTglPesan.Items.Add("0"+i);
				}
				else
				{
					cmbTglReservasi.Items.Add(i);
					cmbTglPesan.Items.Add(i);
				}
			}
			for(int j=1;j<=12;j++)
			{
				cmbBlnLaporan.Items.Add(j);
				if(j<=9)
				{
					cmbBlnReservasi.Items.Add("0"+j);
					cmbBlnPesan.Items.Add("0"+j);
				}
				else
				{
					cmbBlnReservasi.Items.Add(j);
					cmbBlnPesan.Items.Add(j);
				}
			}
			for(int k=2009;k<=2023;k++)
			{
				cmbThnLaporan.Items.Add(k);
				if(k<=9)
				{
					cmbThnReservasi.Items.Add("0"+k);
					cmbThnPesan.Items.Add("0"+k);
				}
				else
				{
					cmbThnReservasi.Items.Add(k);
					cmbThnPesan.Items.Add(k);
				}
			}
			reloadTipeKamar();
			jamTanggal.Text = DateTime.Now.ToString();
			namaTerang.Text = namaUser.ToString();
			usernameTerang.Text = userName.ToString();
			usrNameDefault.Text = userName.ToString();
		}
		
		public void reloadTipeKamar()
		{
			cmbCariTipeKamar.Items.Clear();
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
		
		void RefreshReservasiClick(object sender, EventArgs e)
		{
			string koneksi = "server=localhost;database=db_penginapan;uid=root;password=";
			MySqlConnection koneksiB = new MySqlConnection(koneksi);
			MySqlCommand com = new MySqlCommand("call DataReservasi",koneksiB);
			MySqlDataAdapter adap = new MySqlDataAdapter(com);
            tampil.Columns.Clear(); // <-- clear columns
			DataTable table = new DataTable();
			adap.Fill(table);
			koneksiB.Open();
			tampil.DataSource = null;
			tampil.DataSource = table;
			tampil.AllowUserToAddRows = false; // remove the null line
            tampil.ReadOnly = true;
            tampil.Columns[0].Visible = false; //id cd
            tampil.Columns[1].HeaderText = "Nomor Kamar";
            tampil.Columns[1].Width = 80; //nama cd
            tampil.Columns[2].HeaderText = "Nama Tamu";
            tampil.Columns[2].Width = 150; //nama cd
            tampil.Columns[3].HeaderText = "Tipe Kamar";
            tampil.Columns[3].Width = 80; //tipe cd
            tampil.Columns[4].HeaderText = "Harga Per Hari";
            tampil.Columns[4].Width = 80; //produsen
            tampil.Columns[5].HeaderText = "Tanggal Cek In";
            tampil.Columns[5].Width = 110; //tahun
            tampil.Columns[6].HeaderText = "Tanggal Cek Out";
            tampil.Columns[6].Width = 110; //harga
            tampil.Columns[7].HeaderText = "Lama Inap";
            tampil.Columns[7].Width = 70; //harga
            tampil.Columns[8].HeaderText = "Total";
            tampil.Columns[8].Width = 70; //harga
            tampil.Columns[9].Visible = false; //id cd
            tampil.Columns[10].Visible = false; //id cd
            CekOut = new DataGridViewButtonColumn();
            CekOut .HeaderText = "Cek Out";
            CekOut .Text = "Cek Out";
            CekOut .UseColumnTextForButtonValue = true;
            CekOut .Width = 80;
            tampil.Columns.Add(CekOut);
			koneksiB.Close();
		}
		
		void Button3Click(object sender, EventArgs e)
		{
			string koneksi = "server=localhost;database=db_penginapan;uid=root;password=";
			string no_kamar = cariByNoKamar.Text.ToString();
			MySqlConnection koneksiB = new MySqlConnection(koneksi);
			MySqlCommand com = new MySqlCommand("call CariReservasiBerdasarkanKamar("+no_kamar+")",koneksiB);
			try {
				MySqlDataAdapter adap = new MySqlDataAdapter(com);
				DataTable table = new DataTable();
            	tampil.Columns.Clear(); // <-- clear columns
				adap.Fill(table);
				koneksiB.Open();
				tampil.DataSource = table;
			} catch (Exception err) {
				MessageBox.Show(err.ToString());
			}
			tampil.AllowUserToAddRows = false; // remove the null line
            tampil.ReadOnly = true;
            tampil.Columns[0].Visible = false; //id cd
            tampil.Columns[1].HeaderText = "Nomor Kamar";
            tampil.Columns[1].Width = 80; //nama cd
            tampil.Columns[2].HeaderText = "Nama Tamu";
            tampil.Columns[2].Width = 150; //nama cd
            tampil.Columns[3].HeaderText = "Tipe Kamar";
            tampil.Columns[3].Width = 80; //tipe cd
            tampil.Columns[4].HeaderText = "Harga Per Hari";
            tampil.Columns[4].Width = 80; //produsen
            tampil.Columns[5].HeaderText = "Tanggal Cek In";
            tampil.Columns[5].Width = 110; //tahun
            tampil.Columns[6].HeaderText = "Tanggal Cek Out";
            tampil.Columns[6].Width = 110; //harga
            tampil.Columns[7].HeaderText = "Lama Inap";
            tampil.Columns[7].Width = 70; //harga
            tampil.Columns[8].HeaderText = "Total";
            tampil.Columns[8].Width = 70; //harga
            tampil.Columns[9].Visible = false; //id cd
            tampil.Columns[10].Visible = false; //id cd
            CekOut = new DataGridViewButtonColumn();
            CekOut .HeaderText = "Cek Out";
            CekOut .Text = "Cek Out";
            CekOut .UseColumnTextForButtonValue = true;
            CekOut .Width = 80;
            tampil.Columns.Add(CekOut);
			koneksiB.Close();
		}
		
		void Button4Click(object sender, EventArgs e)
		{
			string koneksi = "server=localhost;database=db_penginapan;uid=root;password=";
			string nama = cariByNamaTamu.Text.ToString();
			MySqlConnection koneksiB = new MySqlConnection(koneksi);
			MySqlCommand com = new MySqlCommand("select id_reservasi, tbl_kamar.id_kamar, nama_tamu, nama, harga, tgl_cek_in, tgl_cek_out, lama_menginap, (harga*lama_menginap) as total, tbl_tamu.id_tamu, tbl_tipe_kamar.id_tipe_kamar from tbl_reservasi left join (tbl_kamar, tbl_tamu, tbl_tipe_kamar) on tbl_reservasi.id_kamar=tbl_kamar.id_kamar and tbl_reservasi.id_tamu=tbl_tamu.id_tamu and tbl_reservasi.id_tipe_kamar=tbl_tipe_kamar.id_tipe_kamar where tbl_tamu.nama_tamu like '%"+nama+"%' and tbl_reservasi.status='N'",koneksiB);
			try {
				MySqlDataAdapter adap = new MySqlDataAdapter(com);
				DataTable table = new DataTable();
            	tampil.Columns.Clear(); // <-- clear columns
				adap.Fill(table);
				koneksiB.Open();
				tampil.DataSource = table;
			} catch (Exception err) {
				MessageBox.Show(err.ToString());
			}
			tampil.AllowUserToAddRows = false; // remove the null line
            tampil.ReadOnly = true;
            tampil.Columns[0].Visible = false; //id cd
            tampil.Columns[1].HeaderText = "Nomor Kamar";
            tampil.Columns[1].Width = 80; //nama cd
            tampil.Columns[2].HeaderText = "Nama Tamu";
            tampil.Columns[2].Width = 150; //nama cd
            tampil.Columns[3].HeaderText = "Tipe Kamar";
            tampil.Columns[3].Width = 80; //tipe cd
            tampil.Columns[4].HeaderText = "Harga Per Hari";
            tampil.Columns[4].Width = 80; //produsen
            tampil.Columns[5].HeaderText = "Tanggal Cek In";
            tampil.Columns[5].Width = 110; //tahun
            tampil.Columns[6].HeaderText = "Tanggal Cek Out";
            tampil.Columns[6].Width = 110; //harga
            tampil.Columns[7].HeaderText = "Lama Inap";
            tampil.Columns[7].Width = 70; //harga
            tampil.Columns[8].HeaderText = "Total";
            tampil.Columns[8].Width = 70; //harga
            tampil.Columns[9].Visible = false; //id cd
            tampil.Columns[10].Visible = false; //id cd
            CekOut = new DataGridViewButtonColumn();
            CekOut .HeaderText = "Cek Out";
            CekOut .Text = "Cek Out";
            CekOut .UseColumnTextForButtonValue = true;
            CekOut .Width = 80;
            tampil.Columns.Add(CekOut);
			koneksiB.Close();
		}
		
		public void cariCekInCekOut(string ket, string gabung)
		{
			string koneksi = "server=localhost;database=db_penginapan;uid=root;password=";
			string nama = cariByNamaTamu.Text.ToString();
			MySqlConnection koneksiB = new MySqlConnection(koneksi);
			MySqlCommand com = new MySqlCommand("select id_reservasi, tbl_kamar.id_kamar, nama_tamu, nama, harga, tgl_cek_in, tgl_cek_out, lama_menginap, (harga*lama_menginap) as total, tbl_tamu.id_tamu, tbl_tipe_kamar.id_tipe_kamar from tbl_reservasi left join (tbl_kamar, tbl_tamu, tbl_tipe_kamar) on tbl_reservasi.id_kamar=tbl_kamar.id_kamar and tbl_reservasi.id_tamu=tbl_tamu.id_tamu and tbl_reservasi.id_tipe_kamar=tbl_tipe_kamar.id_tipe_kamar where "+ket+"='"+gabung+"' and tbl_reservasi.status='N'",koneksiB);
			try {
				MySqlDataAdapter adap = new MySqlDataAdapter(com);
				DataTable table = new DataTable();
            	tampil.Columns.Clear(); // <-- clear columns
				adap.Fill(table);
				koneksiB.Open();
				tampil.DataSource = table;
			} catch (Exception err) {
				MessageBox.Show(err.ToString());
			}
			tampil.AllowUserToAddRows = false; // remove the null line
            tampil.ReadOnly = true;
            tampil.Columns[0].Visible = false; //id cd
            tampil.Columns[1].HeaderText = "Nomor Kamar";
            tampil.Columns[1].Width = 80; //nama cd
            tampil.Columns[2].HeaderText = "Nama Tamu";
            tampil.Columns[2].Width = 150; //nama cd
            tampil.Columns[3].HeaderText = "Tipe Kamar";
            tampil.Columns[3].Width = 80; //tipe cd
            tampil.Columns[4].HeaderText = "Harga Per Hari";
            tampil.Columns[4].Width = 80; //produsen
            tampil.Columns[5].HeaderText = "Tanggal Cek In";
            tampil.Columns[5].Width = 110; //tahun
            tampil.Columns[6].HeaderText = "Tanggal Cek Out";
            tampil.Columns[6].Width = 110; //harga
            tampil.Columns[7].HeaderText = "Lama Inap";
            tampil.Columns[7].Width = 70; //harga
            tampil.Columns[8].HeaderText = "Total";
            tampil.Columns[8].Width = 70; //harga
            tampil.Columns[9].Visible = false; //id cd
            tampil.Columns[10].Visible = false; //id cd
            CekOut = new DataGridViewButtonColumn();
            CekOut .HeaderText = "Cek Out";
            CekOut .Text = "Cek Out";
            CekOut .UseColumnTextForButtonValue = true;
            CekOut .Width = 80;
            tampil.Columns.Add(CekOut);
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
		
		void Button1Click(object sender, EventArgs e)
		{
			string no_kamar = noKamarCari.Text.ToString();
			string koneksi = "server=localhost;database=db_penginapan;uid=root;password=";
			MySqlConnection koneksiB = new MySqlConnection(koneksi);
			MySqlCommand com = new MySqlCommand("call CariKamarBerdasarkanNoKamar("+no_kamar+")",koneksiB);
			MySqlDataAdapter adap = new MySqlDataAdapter(com);
            tampil.Columns.Clear(); // <-- clear columns
			DataTable table = new DataTable();
			adap.Fill(table);
			tampil.DataSource = table;
			tampil.AllowUserToAddRows = false; // remove the null line
            tampil.ReadOnly = true;
            tampil.Columns[0].HeaderText = "Nomor Kamar";
            tampil.Columns[0].Width = 110; 
            tampil.Columns[1].HeaderText = "Tipe Kamar";
            tampil.Columns[1].Width = 100; 
            tampil.Columns[2].HeaderText = "Deskripsi";
            tampil.Columns[2].Width = 400; 
            tampil.Columns[3].HeaderText = "Harga";
            tampil.Columns[3].Width = 80; 
            tampil.Columns[4].HeaderText = "Status";
            tampil.Columns[4].Width = 50; 
            CekOut = new DataGridViewButtonColumn();
            CekOut .HeaderText = "Cek Out";
            CekOut .Text = "Cek Out";
            CekOut .UseColumnTextForButtonValue = true;
            CekOut .Width = 80;
            tampil.Columns.Add(CekOut);
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			string tipe = cmbCariTipeKamar.Text.ToString();
			string id_tipe = tipe.Substring(0,1);
			string koneksi = "server=localhost;database=db_penginapan;uid=root;password=";
			MySqlConnection koneksiB = new MySqlConnection(koneksi);
			MySqlCommand com = new MySqlCommand("call CariBerdasarkanTipeKamar("+id_tipe+")",koneksiB);
			MySqlDataAdapter adap = new MySqlDataAdapter(com);
            tampil.Columns.Clear(); // <-- clear columns
			DataTable table = new DataTable();
			adap.Fill(table);
			tampil.DataSource = table;
			tampil.AllowUserToAddRows = false; // remove the null line
            tampil.ReadOnly = true;
            tampil.Columns[0].HeaderText = "Nomor Kamar";
            tampil.Columns[0].Width = 110; 
            tampil.Columns[1].HeaderText = "Tipe Kamar";
            tampil.Columns[1].Width = 100; 
            tampil.Columns[2].HeaderText = "Deskripsi";
            tampil.Columns[2].Width = 400; 
            tampil.Columns[3].HeaderText = "Harga";
            tampil.Columns[3].Width = 80; 
            tampil.Columns[4].HeaderText = "Status";
            tampil.Columns[4].Width = 50; 
            CekOut = new DataGridViewButtonColumn();
            CekOut .HeaderText = "Cek Out";
            CekOut .Text = "Cek Out";
            CekOut .UseColumnTextForButtonValue = true;
            CekOut .Width = 80;
            tampil.Columns.Add(CekOut);
		}
		
		void RefreshKamarClick(object sender, EventArgs e)
		{
			string koneksi = "server=localhost;database=db_penginapan;uid=root;password=";
			MySqlConnection koneksiB = new MySqlConnection(koneksi);
			MySqlCommand com = new MySqlCommand("call TampilKamar()",koneksiB);
			MySqlDataAdapter adap = new MySqlDataAdapter(com);
            tampil.Columns.Clear(); // <-- clear columns
			DataTable table = new DataTable();
			adap.Fill(table);
			tampil.DataSource = table;
			tampil.AllowUserToAddRows = false; // remove the null line
            tampil.ReadOnly = true;
            tampil.Columns[0].HeaderText = "Nomor Kamar";
            tampil.Columns[0].Width = 110; 
            tampil.Columns[1].HeaderText = "Tipe Kamar";
            tampil.Columns[1].Width = 100; 
            tampil.Columns[2].HeaderText = "Deskripsi";
            tampil.Columns[2].Width = 400; 
            tampil.Columns[3].HeaderText = "Harga";
            tampil.Columns[3].Width = 80; 
            tampil.Columns[4].HeaderText = "Status";
            tampil.Columns[4].Width = 50; 
		}
		
		void TmbKamarClick(object sender, EventArgs e)
		{
			FrmTambahKamar f3 = new FrmTambahKamar();
			f3.Show();
		}
		
		void Button10Click(object sender, EventArgs e)
		{
			if (namaTipe.Text=="" || hargaTipe.Text=="") {
				MessageBox.Show("Gagal menambah data!!!");
			}
			else{
				string nama = namaTipe.Text.ToString();
				string harga = hargaTipe.Text.ToString();
				string koneksi = "server=localhost;database=db_penginapan;uid=root;password=";
				MySqlConnection koneksiB = new MySqlConnection(koneksi);
				MySqlCommand com = new MySqlCommand("call tambahTipeKamar('"+nama+"','"+harga+"')",koneksiB);
				try {
					MySqlDataAdapter adap = new MySqlDataAdapter(com);
	            	tampil.Columns.Clear(); // <-- clear columns
					DataTable table = new DataTable();
					adap.Fill(table);
					MessageBox.Show("Data berhasil disimpan!!!");
				} catch (Exception err) {
					MessageBox.Show(err.ToString());
				}
			}
		}
		
		void RefreshTipeKamarClick(object sender, EventArgs e)
		{
			string koneksi = "server=localhost;database=db_penginapan;uid=root;password=";
			MySqlConnection koneksiB = new MySqlConnection(koneksi);
			MySqlCommand com = new MySqlCommand("call Tipekamar()",koneksiB);
			MySqlDataAdapter adap = new MySqlDataAdapter(com);
            tampil.Columns.Clear(); // <-- clear columns
			DataTable table = new DataTable();
			adap.Fill(table);
			tampil.DataSource = table;
			tampil.AllowUserToAddRows = false; // remove the null line
            tampil.ReadOnly = true;
            tampil.Columns[0].HeaderText = "ID Tipe Kamar";
            tampil.Columns[0].Width = 110; 
            tampil.Columns[1].HeaderText = "Nama Tipe Kamar";
            tampil.Columns[1].Width = 300; 
            tampil.Columns[2].HeaderText = "Harga";
            tampil.Columns[2].Width = 200; 
		}
		
		void Button8Click(object sender, EventArgs e)
		{
			reloadTipeKamar();
		}
		
		
		void Button19Click(object sender, EventArgs e)
		{
			string koneksi = "server=localhost;database=db_penginapan;uid=root;password=";
			MySqlConnection koneksiB = new MySqlConnection(koneksi);
			MySqlCommand com = new MySqlCommand("call TampilTamu()",koneksiB);
			MySqlDataAdapter adap = new MySqlDataAdapter(com);
            tampil.Columns.Clear(); // <-- clear columns
			DataTable table = new DataTable();
			adap.Fill(table);
			tampil.DataSource = table;
			tampil.AllowUserToAddRows = false; // remove the null line
            tampil.ReadOnly = true;
            tampil.Columns[0].Visible = false;
            tampil.Columns[1].HeaderText = "Nama Tamu";
            tampil.Columns[1].Width = 150; 
            tampil.Columns[2].HeaderText = "Alamat Tamu";
            tampil.Columns[2].Width = 300; 
            tampil.Columns[3].HeaderText = "No Telepon";
            tampil.Columns[3].Width = 140; 
            tampil.Columns[4].HeaderText = "Jenis Kelamin";
            tampil.Columns[4].Width = 100; 
            tampil.Columns[5].HeaderText = "Pekerjaan";
            tampil.Columns[5].Width = 100; 
            EditTamu = new DataGridViewButtonColumn();
            EditTamu .HeaderText = "Edit";
            EditTamu .Text = "Edit";
            EditTamu .UseColumnTextForButtonValue = true;
            EditTamu .Width = 40;
            tampil.Columns.Add(EditTamu);
			DeleteTamu = new DataGridViewButtonColumn();
			DeleteTamu.HeaderText = "Hapus";
			DeleteTamu.Text = "Hapus";
			DeleteTamu.UseColumnTextForButtonValue = true;
			DeleteTamu.Width = 50;
			tampil.Columns.Add(DeleteTamu);
			FrmUpdateTamu updateTamu = new FrmUpdateTamu();
			
		}
		
		void CekInTamuBaruToolStripMenuItemClick(object sender, EventArgs e)
		{
			FrmCekIn f2 = new FrmCekIn();
			f2.Show();
		}
		
		void TambahDataKamarToolStripMenuItemClick(object sender, EventArgs e)
		{
			FrmTambahKamar f3 = new FrmTambahKamar();
			f3.Show();
		}
		
		void Button20Click(object sender, EventArgs e)
		{
			FrmTambahTamu f4 = new FrmTambahTamu();
			f4.Show();
		}
		
		void Button16Click(object sender, EventArgs e)
		{
			string nama = nmTamu.Text.ToString();
			string koneksi = "server=localhost;database=db_penginapan;uid=root;password=";
			MySqlConnection koneksiB = new MySqlConnection(koneksi);
			MySqlCommand com = new MySqlCommand("select * from tbl_tamu where nama_tamu like '%"+nama+"%'",koneksiB);
			MySqlDataAdapter adap = new MySqlDataAdapter(com);
            tampil.Columns.Clear(); // <-- clear columns
			DataTable table = new DataTable();
			adap.Fill(table);
			tampil.DataSource = table;
			tampil.AllowUserToAddRows = false; // remove the null line
            tampil.ReadOnly = true;
            tampil.Columns[0].Visible = false;
            tampil.Columns[1].HeaderText = "Nama Tamu";
            tampil.Columns[1].Width = 150; 
            tampil.Columns[2].HeaderText = "Alamat Tamu";
            tampil.Columns[2].Width = 300; 
            tampil.Columns[3].HeaderText = "No Telepon";
            tampil.Columns[3].Width = 140; 
            tampil.Columns[4].HeaderText = "Jenis Kelamin";
            tampil.Columns[4].Width = 100; 
            tampil.Columns[5].HeaderText = "Pekerjaan";
            tampil.Columns[5].Width = 100; 
            EditTamu = new DataGridViewButtonColumn();
            EditTamu .HeaderText = "Edit";
            EditTamu .Text = "Edit";
            EditTamu .UseColumnTextForButtonValue = true;
            EditTamu .Width = 40;
            tampil.Columns.Add(EditTamu);
			DeleteTamu = new DataGridViewButtonColumn();
			DeleteTamu.HeaderText = "Hapus";
			DeleteTamu.Text = "Hapus";
			DeleteTamu.UseColumnTextForButtonValue = true;
			DeleteTamu.Width = 50;
			tampil.Columns.Add(DeleteTamu);
		}
		
		void Button15Click(object sender, EventArgs e)
		{
			string almt = almtTamu.Text.ToString();
			string koneksi = "server=localhost;database=db_penginapan;uid=root;password=";
			MySqlConnection koneksiB = new MySqlConnection(koneksi);
			MySqlCommand com = new MySqlCommand("select * from tbl_tamu where alamat like '%"+almt+"%'",koneksiB);
			MySqlDataAdapter adap = new MySqlDataAdapter(com);
            tampil.Columns.Clear(); // <-- clear columns
			DataTable table = new DataTable();
			adap.Fill(table);
			tampil.DataSource = table;
			tampil.AllowUserToAddRows = false; // remove the null line
            tampil.ReadOnly = true;
            tampil.Columns[0].Visible = false;
            tampil.Columns[1].HeaderText = "Nama Tamu";
            tampil.Columns[1].Width = 150; 
            tampil.Columns[2].HeaderText = "Alamat Tamu";
            tampil.Columns[2].Width = 300; 
            tampil.Columns[3].HeaderText = "No Telepon";
            tampil.Columns[3].Width = 140; 
            tampil.Columns[4].HeaderText = "Jenis Kelamin";
            tampil.Columns[4].Width = 100; 
            tampil.Columns[5].HeaderText = "Pekerjaan";
            tampil.Columns[5].Width = 100; 
            EditTamu = new DataGridViewButtonColumn();
            EditTamu .HeaderText = "Edit";
            EditTamu .Text = "Edit";
            EditTamu .UseColumnTextForButtonValue = true;
            EditTamu .Width = 40;
            tampil.Columns.Add(EditTamu);
			DeleteTamu = new DataGridViewButtonColumn();
			DeleteTamu.HeaderText = "Hapus";
			DeleteTamu.Text = "Hapus";
			DeleteTamu.UseColumnTextForButtonValue = true;
			DeleteTamu.Width = 50;
			tampil.Columns.Add(DeleteTamu);
		}
		
		void Button22Click(object sender, EventArgs e)
		{
			FrmTambahMenu f5 = new FrmTambahMenu();
			f5.Show();
		}
		
		void Button21Click(object sender, EventArgs e)
		{
			string koneksi = "server=localhost;database=db_penginapan;uid=root;password=";
			MySqlConnection koneksiB = new MySqlConnection(koneksi);
			MySqlCommand com = new MySqlCommand("call TampilMenu()",koneksiB);
			try {
				MySqlDataAdapter adap = new MySqlDataAdapter(com);
				DataTable table = new DataTable();
            	tampil.Columns.Clear(); // <-- clear columns
				adap.Fill(table);
				tampil.DataSource = table;
				tampil.AllowUserToAddRows = false; // remove the null line
	            tampil.ReadOnly = true;
	            tampil.Columns[0].HeaderText = "ID";
	            tampil.Columns[0].Width = 100; 
	            tampil.Columns[1].HeaderText = "Nama Makanan";
	            tampil.Columns[1].Width = 540; 
	            tampil.Columns[2].HeaderText = "Harga Makanan";
	            tampil.Columns[2].Width = 200; 
			} catch (Exception err) {
				MessageBox.Show(err.ToString());
			}
		}
		
		void FrmPenginapanFormClosed(object sender, FormClosedEventArgs e)
		{
			System.Windows.Forms.Application.Exit();
		}
		
		void Button24Click(object sender, EventArgs e)
		{
			FrmTambahPesanan f6 = new FrmTambahPesanan();
			f6.Show();
		}
		
		void Button23Click(object sender, EventArgs e)
		{
			string koneksi = "server=localhost;database=db_penginapan;uid=root;password=";
			MySqlConnection koneksiB = new MySqlConnection(koneksi);
			MySqlCommand com = new MySqlCommand("call TampilPesanan",koneksiB);
			MySqlDataAdapter adap = new MySqlDataAdapter(com);
            tampil.Columns.Clear(); // <-- clear columns
			DataTable table = new DataTable();
			adap.Fill(table);
			tampil.DataSource = table;
			tampil.AllowUserToAddRows = false; // remove the null line 
            tampil.ReadOnly = true;
            tampil.Columns[0].HeaderText = "ID Reservasi";
            tampil.Columns[0].Width = 100; 
            tampil.Columns[1].HeaderText = "No Kamar";
            tampil.Columns[1].Width = 90; 
            tampil.Columns[2].HeaderText = "Pesanan";
            tampil.Columns[2].Width = 300; 
            tampil.Columns[3].HeaderText = "Tgl Cek In";
            tampil.Columns[3].Width = 100; 
            tampil.Columns[4].HeaderText = "Tgl Cek Out";
            tampil.Columns[4].Width = 100; 
            tampil.Columns[5].HeaderText = "Tgl Pesan";
            tampil.Columns[5].Width = 100; 
		}
		
		void Button25Click(object sender, EventArgs e)
		{
			string tgl = cmbTglPesan.Text;
			string bln = cmbBlnPesan.Text;
			string thn = cmbThnPesan.Text;
			string gabung = tgl +"/"+ bln +"/"+ thn;
			string nm = nmKmrPesan.Text.ToString();
			string koneksi = "server=localhost;database=db_penginapan;uid=root;password=";
			MySqlConnection koneksiB = new MySqlConnection(koneksi);
			MySqlCommand com = new MySqlCommand("call CariPesananTglNoKamar('"+gabung+"',"+nm+")",koneksiB);
			try {
				MySqlDataAdapter adap = new MySqlDataAdapter(com);
				DataTable table = new DataTable();
            	tampil.Columns.Clear(); // <-- clear columns
				adap.Fill(table);
				tampil.DataSource = table;
				tampil.AllowUserToAddRows = false; // remove the null line
	            tampil.ReadOnly = true;
	            tampil.Columns[0].HeaderText = "ID Reservasi";
	            tampil.Columns[0].Width = 100; 
	            tampil.Columns[1].HeaderText = "No Kamar";
	            tampil.Columns[1].Width = 90; 
	            tampil.Columns[2].HeaderText = "Pesanan";
	            tampil.Columns[2].Width = 300; 
	            tampil.Columns[3].HeaderText = "Tgl Cek In";
	            tampil.Columns[3].Width = 100; 
	            tampil.Columns[4].HeaderText = "Tgl Cek Out";
	            tampil.Columns[4].Width = 100; 
	            tampil.Columns[5].HeaderText = "Tgl Pesan";
	            tampil.Columns[5].Width = 100; 
			} catch (Exception err) {
				MessageBox.Show(err.ToString());
			}
			
		}
		
		void Button26Click(object sender, EventArgs e)
		{
			string id_rs = idRsPesan.Text.ToString();
			string koneksi = "server=localhost;database=db_penginapan;uid=root;password=";
			MySqlConnection koneksiB = new MySqlConnection(koneksi);
			MySqlCommand com = new MySqlCommand("call CariPesananIdReservasi("+id_rs+")",koneksiB);
			try {
				MySqlDataAdapter adap = new MySqlDataAdapter(com);
				DataTable table = new DataTable();
            	tampil.Columns.Clear(); // <-- clear columns
				adap.Fill(table);
				tampil.DataSource = table;
				tampil.AllowUserToAddRows = false; // remove the null line
	            tampil.ReadOnly = true;
	            tampil.Columns[0].HeaderText = "ID Reservasi";
	            tampil.Columns[0].Width = 100; 
	            tampil.Columns[1].HeaderText = "No Kamar";
	            tampil.Columns[1].Width = 90; 
	            tampil.Columns[2].HeaderText = "Pesanan";
	            tampil.Columns[2].Width = 300; 
	            tampil.Columns[3].HeaderText = "Tgl Cek In";
	            tampil.Columns[3].Width = 100; 
	            tampil.Columns[4].HeaderText = "Tgl Cek Out";
	            tampil.Columns[4].Width = 100; 
	            tampil.Columns[5].HeaderText = "Tgl Pesan";
	            tampil.Columns[5].Width = 100; 
			} catch (Exception err) {
				MessageBox.Show(err.ToString());
			}
		}
		
		void TampilCellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			int currentRow = int.Parse(e.RowIndex.ToString());
			if (tampil.Columns[e.ColumnIndex] == CekOut && currentRow >= 0)
            {
				string id = tampil[0, currentRow].Value.ToString();
				string nomor = tampil[1, currentRow].Value.ToString();
				string nama = tampil[2, currentRow].Value.ToString();
				string tipe = tampil[3, currentRow].Value.ToString();
				int harga = Convert.ToInt32(tampil[4, currentRow].Value.ToString());
				string cekin = tampil[5, currentRow].Value.ToString();
				string cekout = tampil[6, currentRow].Value.ToString();
				int lama = Convert.ToInt32(tampil[7, currentRow].Value.ToString());
				string total = tampil[8, currentRow].Value.ToString();
				string id_tm = tampil[9, currentRow].Value.ToString();
				string id_tp = tampil[10, currentRow].Value.ToString();
				FrmCekOut f8 = new FrmCekOut();
				f8.id_rs = id;
				f8.nmr_kmr = nomor;
				f8.nm_tm = nama;
				f8.tp_kmr = tipe;
				f8.hrg_kmr = harga;
				f8.lm_inap = lama;
				f8.cek_in = cekin;
				f8.cek_out = cekout;
				f8.id_tm = id_tm;
				f8.id_tp_kmr = id_tp;
				f8.id_user = id_user;
				f8.Show();
			}

			int currentRows = int.Parse(e.RowIndex.ToString());
			if (tampil.Columns[e.ColumnIndex] == CekOut && currentRows >= 0)
            {
				string nama = tampil[1, currentRow].Value.ToString();
				string alamat = tampil[2, currentRow].Value.ToString();
				string tlpn = tampil[3, currentRow].Value.ToString();
				string jk = tampil[3, currentRow].Value.ToString();
				string kerja = tampil[3, currentRow].Value.ToString();
				FrmUpdateTamu updateTamu = new FrmUpdateTamu();
				updateTamu.nama = nama;
				updateTamu.alamat = alamat;
				updateTamu.tlpn = tlpn;
				updateTamu.kerja = kerja;
				updateTamu.Show();
			
			}

		}
		
		void Button27Click(object sender, EventArgs e)
		{
			string koneksi = "server=localhost;database=db_penginapan;uid=root;password=";
			MySqlConnection koneksiB = new MySqlConnection(koneksi);
			MySqlCommand com = new MySqlCommand("call LihatLaporan",koneksiB);
			try {
				MySqlDataAdapter adap = new MySqlDataAdapter(com);
				DataTable table = new DataTable();
            	tampil.Columns.Clear(); // <-- clear columns
				adap.Fill(table);
				tampil.DataSource = table;
				tampil.AllowUserToAddRows = false; // remove the null line
	            tampil.ReadOnly = true;
	            tampil.Columns[0].HeaderText = "Nama Tamu";
	            tampil.Columns[0].Width = 300; 
	            tampil.Columns[1].HeaderText = "No Kamar";
	            tampil.Columns[1].Width = 90; 
	            tampil.Columns[2].HeaderText = "Total Bayar";
	            tampil.Columns[2].Width = 120; 
	            tampil.Columns[3].HeaderText = "Bulan";
	            tampil.Columns[3].Width = 100; 
	            tampil.Columns[4].HeaderText = "Tahun";
	            tampil.Columns[4].Width = 100; 
	            tampil.Columns[5].HeaderText = "Username";
	            tampil.Columns[5].Width = 80; 
			} catch (Exception err) {
				MessageBox.Show(err.ToString());
			}
		}

        private void keluarLogOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
			this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        void Button28Click(object sender, EventArgs e)
		{
			try {
				int bulan = Convert.ToInt32(cmbBlnLaporan.Text.ToString());
				int tahun = Convert.ToInt32(cmbThnLaporan.Text.ToString());
				string koneksi = "server=localhost;database=db_penginapan;uid=root;password=";
				MySqlConnection koneksiB = new MySqlConnection(koneksi);
				MySqlCommand com = new MySqlCommand("call ExportLaporan("+bulan+","+tahun+")",koneksiB);
				MySqlDataAdapter adap = new MySqlDataAdapter(com);
				DataTable table = new DataTable();
            	tampil.Columns.Clear(); // <-- clear columns
				adap.Fill(table);
				tampil.DataSource = table;
				tampil.AllowUserToAddRows = false; // remove the null line
	            tampil.ReadOnly = true;
	            tampil.Columns[0].HeaderText = "Nama Tamu";
	            tampil.Columns[0].Width = 300; 
	            tampil.Columns[1].HeaderText = "No Kamar";
	            tampil.Columns[1].Width = 90; 
	            tampil.Columns[2].HeaderText = "Total Bayar";
	            tampil.Columns[2].Width = 120; 
	            tampil.Columns[3].HeaderText = "Bulan";
	            tampil.Columns[3].Width = 100; 
	            tampil.Columns[4].HeaderText = "Tahun";
                tampil.Columns[4].Width = 100; 
	            tampil.Columns[5].HeaderText = "Username";
	            tampil.Columns[5].Width = 80; 
		        int bnykData;
				int total=0;
				bnykData = tampil.Rows.Count;

				for (int i=0;i<bnykData ;i++ ) {
					total = Convert.ToInt32(total + Convert.ToInt32(tampil[2,i].Value));
					tmpilTotal.Text = total.ToString();
				}

				List<Report> reports = new List<Report>();

                for (int i = 0; i < tampil.RowCount; i++)
                {
                    Report report = new Report
                    {
                        idKamar = Convert.ToInt32(table.Rows[i]["id_kamar"].ToString()),
                        namaTamu = table.Rows[i]["nama_tamu"].ToString(),
                        totalBayar = Convert.ToDouble(table.Rows[i]["total_bayar"].ToString()),
                        username = table.Rows[i]["username"].ToString()
                    };

                    reports.Add(report);
                }

				new FrmPreviewReport(reports, bulan, tahun).Show();
			} catch (Exception err) {
				MessageBox.Show(err.ToString());
			}
		}
		
		void Button29Click(object sender, EventArgs e)
		{
			string lama = pswLama.Text.ToString();
			string baru = pswBaru.Text.ToString();
			string koneksi = "server=localhost;database=db_penginapan;uid=root;password=";
			MySqlConnection koneksiB = new MySqlConnection(koneksi);
			MySqlCommand com = new MySqlCommand("select * from tbl_user where id_user='"+id_user+"'",koneksiB);
			MySqlCommand com2 = new MySqlCommand("update tbl_user set password='"+baru+"' where id_user='"+id_user+"'",koneksiB);
			try {
				MySqlDataAdapter adap = new MySqlDataAdapter(com);
				MySqlDataAdapter adap2 = new MySqlDataAdapter(com2);
				DataTable table = new DataTable();
				DataTable table2 = new DataTable();
				adap.Fill(table);
				adap2.Fill(table2);
				MessageBox.Show("Data berhasil disimpan!!!");
			} catch (Exception err) {
				MessageBox.Show(err.ToString());
			}
		}
	}
}
