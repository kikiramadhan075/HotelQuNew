/*
 * Created by SharpDevelop.
 * User: FVCK-32
 * Date: 19/01/2011
 * Time: 19:16
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace penginapan
{
	partial class FrmTambahPesanan
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTambahPesanan));
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.tabControl2 = new System.Windows.Forms.TabControl();
			this.tabPage8 = new System.Windows.Forms.TabPage();
			this.label7 = new System.Windows.Forms.Label();
			this.button3 = new System.Windows.Forms.Button();
			this.cariByNoKamar = new System.Windows.Forms.TextBox();
			this.tabPage9 = new System.Windows.Forms.TabPage();
			this.label8 = new System.Windows.Forms.Label();
			this.button4 = new System.Windows.Forms.Button();
			this.cariByNamaTamu = new System.Windows.Forms.TextBox();
			this.tabPage10 = new System.Windows.Forms.TabPage();
			this.button6 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.label9 = new System.Windows.Forms.Label();
			this.cmbThnReservasi = new System.Windows.Forms.ComboBox();
			this.label10 = new System.Windows.Forms.Label();
			this.cmbBlnReservasi = new System.Windows.Forms.ComboBox();
			this.label11 = new System.Windows.Forms.Label();
			this.cmbTglReservasi = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.tipe = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.tampil = new System.Windows.Forms.DataGridView();
			this.label6 = new System.Windows.Forms.Label();
			this.ckOut = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.ckIn = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.nmKmr = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.nmTm = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.idRs = new System.Windows.Forms.TextBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.button8 = new System.Windows.Forms.Button();
			this.button9 = new System.Windows.Forms.Button();
			this.label16 = new System.Windows.Forms.Label();
			this.totalSemua = new System.Windows.Forms.TextBox();
			this.label15 = new System.Windows.Forms.Label();
			this.bnyk = new System.Windows.Forms.TextBox();
			this.listPesanan = new System.Windows.Forms.DataGridView();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column5 = new System.Windows.Forms.DataGridViewButtonColumn();
			this.button7 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.label13 = new System.Windows.Forms.Label();
			this.hrgMenu = new System.Windows.Forms.TextBox();
			this.label14 = new System.Windows.Forms.Label();
			this.nmMenu = new System.Windows.Forms.TextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.idMn = new System.Windows.Forms.TextBox();
			this.groupBox1.SuspendLayout();
			this.tabControl2.SuspendLayout();
			this.tabPage8.SuspendLayout();
			this.tabPage9.SuspendLayout();
			this.tabPage10.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.tampil)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.listPesanan)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.Transparent;
			this.groupBox1.Controls.Add(this.tabControl2);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.tipe);
			this.groupBox1.Controls.Add(this.button1);
			this.groupBox1.Controls.Add(this.tampil);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.ckOut);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.ckIn);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.nmKmr);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.nmTm);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.idRs);
			this.groupBox1.Location = new System.Drawing.Point(12, 56);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(709, 240);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Data Pemesan Makanan - Minuman";
			// 
			// tabControl2
			// 
			this.tabControl2.Controls.Add(this.tabPage8);
			this.tabControl2.Controls.Add(this.tabPage9);
			this.tabControl2.Controls.Add(this.tabPage10);
			this.tabControl2.Location = new System.Drawing.Point(6, 173);
			this.tabControl2.Name = "tabControl2";
			this.tabControl2.SelectedIndex = 0;
			this.tabControl2.Size = new System.Drawing.Size(697, 59);
			this.tabControl2.TabIndex = 0;
			// 
			// tabPage8
			// 
			this.tabPage8.Controls.Add(this.label7);
			this.tabPage8.Controls.Add(this.button3);
			this.tabPage8.Controls.Add(this.cariByNoKamar);
			this.tabPage8.Location = new System.Drawing.Point(4, 22);
			this.tabPage8.Name = "tabPage8";
			this.tabPage8.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage8.Size = new System.Drawing.Size(689, 33);
			this.tabPage8.TabIndex = 0;
			this.tabPage8.Text = "Cari Berdasarkan Kamar";
			this.tabPage8.UseVisualStyleBackColor = true;
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(8, 8);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(78, 20);
			this.label7.TabIndex = 2;
			this.label7.Text = "Nomor Kamar :";
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(299, 5);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(75, 23);
			this.button3.TabIndex = 1;
			this.button3.Text = "Cari";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.Button3Click);
			// 
			// cariByNoKamar
			// 
			this.cariByNoKamar.Location = new System.Drawing.Point(92, 6);
			this.cariByNoKamar.Name = "cariByNoKamar";
			this.cariByNoKamar.Size = new System.Drawing.Size(201, 20);
			this.cariByNoKamar.TabIndex = 0;
			// 
			// tabPage9
			// 
			this.tabPage9.Controls.Add(this.label8);
			this.tabPage9.Controls.Add(this.button4);
			this.tabPage9.Controls.Add(this.cariByNamaTamu);
			this.tabPage9.Location = new System.Drawing.Point(4, 22);
			this.tabPage9.Name = "tabPage9";
			this.tabPage9.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage9.Size = new System.Drawing.Size(689, 33);
			this.tabPage9.TabIndex = 1;
			this.tabPage9.Text = "Cari Berdasarkan Nama Tamu";
			this.tabPage9.UseVisualStyleBackColor = true;
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(8, 8);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(78, 20);
			this.label8.TabIndex = 5;
			this.label8.Text = "Nama Tamu :";
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(299, 5);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(75, 23);
			this.button4.TabIndex = 4;
			this.button4.Text = "Cari";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.Button4Click);
			// 
			// cariByNamaTamu
			// 
			this.cariByNamaTamu.Location = new System.Drawing.Point(92, 6);
			this.cariByNamaTamu.Name = "cariByNamaTamu";
			this.cariByNamaTamu.Size = new System.Drawing.Size(201, 20);
			this.cariByNamaTamu.TabIndex = 3;
			// 
			// tabPage10
			// 
			this.tabPage10.Controls.Add(this.button6);
			this.tabPage10.Controls.Add(this.button5);
			this.tabPage10.Controls.Add(this.label9);
			this.tabPage10.Controls.Add(this.cmbThnReservasi);
			this.tabPage10.Controls.Add(this.label10);
			this.tabPage10.Controls.Add(this.cmbBlnReservasi);
			this.tabPage10.Controls.Add(this.label11);
			this.tabPage10.Controls.Add(this.cmbTglReservasi);
			this.tabPage10.Location = new System.Drawing.Point(4, 22);
			this.tabPage10.Name = "tabPage10";
			this.tabPage10.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage10.Size = new System.Drawing.Size(689, 33);
			this.tabPage10.TabIndex = 2;
			this.tabPage10.Text = "Cari Berdasarkan Tanggal Cek In & Cek Out";
			this.tabPage10.UseVisualStyleBackColor = true;
			// 
			// button6
			// 
			this.button6.Location = new System.Drawing.Point(476, 4);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(75, 23);
			this.button6.TabIndex = 7;
			this.button6.Text = "Cek Out";
			this.button6.UseVisualStyleBackColor = true;
			this.button6.Click += new System.EventHandler(this.Button6Click);
			// 
			// button5
			// 
			this.button5.Location = new System.Drawing.Point(386, 4);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(75, 23);
			this.button5.TabIndex = 6;
			this.button5.Text = "Cek In";
			this.button5.UseVisualStyleBackColor = true;
			this.button5.Click += new System.EventHandler(this.Button5Click);
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(261, 9);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(46, 21);
			this.label9.TabIndex = 5;
			this.label9.Text = "Tahun :";
			// 
			// cmbThnReservasi
			// 
			this.cmbThnReservasi.FormattingEnabled = true;
			this.cmbThnReservasi.Location = new System.Drawing.Point(313, 6);
			this.cmbThnReservasi.Name = "cmbThnReservasi";
			this.cmbThnReservasi.Size = new System.Drawing.Size(49, 21);
			this.cmbThnReservasi.TabIndex = 4;
			// 
			// label10
			// 
			this.label10.Location = new System.Drawing.Point(139, 9);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(46, 21);
			this.label10.TabIndex = 3;
			this.label10.Text = "Bulan :";
			// 
			// cmbBlnReservasi
			// 
			this.cmbBlnReservasi.FormattingEnabled = true;
			this.cmbBlnReservasi.Location = new System.Drawing.Point(191, 6);
			this.cmbBlnReservasi.Name = "cmbBlnReservasi";
			this.cmbBlnReservasi.Size = new System.Drawing.Size(49, 21);
			this.cmbBlnReservasi.TabIndex = 2;
			// 
			// label11
			// 
			this.label11.Location = new System.Drawing.Point(6, 9);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(58, 21);
			this.label11.TabIndex = 1;
			this.label11.Text = "Tanggal :";
			// 
			// cmbTglReservasi
			// 
			this.cmbTglReservasi.FormattingEnabled = true;
			this.cmbTglReservasi.Location = new System.Drawing.Point(70, 6);
			this.cmbTglReservasi.Name = "cmbTglReservasi";
			this.cmbTglReservasi.Size = new System.Drawing.Size(49, 21);
			this.cmbTglReservasi.TabIndex = 0;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(357, 52);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(10, 15);
			this.label3.TabIndex = 32;
			this.label3.Text = "-";
			// 
			// tipe
			// 
			this.tipe.Location = new System.Drawing.Point(373, 47);
			this.tipe.Name = "tipe";
			this.tipe.ReadOnly = true;
			this.tipe.Size = new System.Drawing.Size(105, 20);
			this.tipe.TabIndex = 31;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(9, 42);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(157, 27);
			this.button1.TabIndex = 30;
			this.button1.Text = "LIHAT DATA RESERVASI";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// tampil
			// 
			this.tampil.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.tampil.Location = new System.Drawing.Point(6, 76);
			this.tampil.Name = "tampil";
			this.tampil.Size = new System.Drawing.Size(697, 91);
			this.tampil.TabIndex = 29;
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(492, 51);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(52, 15);
			this.label6.TabIndex = 25;
			this.label6.Text = "Cek Out : ";
			// 
			// ckOut
			// 
			this.ckOut.Location = new System.Drawing.Point(566, 49);
			this.ckOut.Name = "ckOut";
			this.ckOut.ReadOnly = true;
			this.ckOut.Size = new System.Drawing.Size(137, 20);
			this.ckOut.TabIndex = 24;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(492, 21);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(52, 15);
			this.label5.TabIndex = 23;
			this.label5.Text = "Cek In : ";
			// 
			// ckIn
			// 
			this.ckIn.Location = new System.Drawing.Point(566, 19);
			this.ckIn.Name = "ckIn";
			this.ckIn.ReadOnly = true;
			this.ckIn.Size = new System.Drawing.Size(137, 20);
			this.ckIn.TabIndex = 22;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(188, 50);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(76, 15);
			this.label4.TabIndex = 21;
			this.label4.Text = "No Kamar : ";
			// 
			// nmKmr
			// 
			this.nmKmr.Location = new System.Drawing.Point(270, 48);
			this.nmKmr.Name = "nmKmr";
			this.nmKmr.ReadOnly = true;
			this.nmKmr.Size = new System.Drawing.Size(81, 20);
			this.nmKmr.TabIndex = 20;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(188, 21);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(76, 15);
			this.label2.TabIndex = 3;
			this.label2.Text = "Nama Tamu : ";
			// 
			// nmTm
			// 
			this.nmTm.Location = new System.Drawing.Point(270, 19);
			this.nmTm.Name = "nmTm";
			this.nmTm.ReadOnly = true;
			this.nmTm.Size = new System.Drawing.Size(208, 20);
			this.nmTm.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(8, 21);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(76, 15);
			this.label1.TabIndex = 1;
			this.label1.Text = "ID Reservasi : ";
			// 
			// idRs
			// 
			this.idRs.Location = new System.Drawing.Point(90, 19);
			this.idRs.Name = "idRs";
			this.idRs.Size = new System.Drawing.Size(76, 20);
			this.idRs.TabIndex = 0;
			this.idRs.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBox1KeyDown);
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(12, -8);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(709, 58);
			this.pictureBox1.TabIndex = 16;
			this.pictureBox1.TabStop = false;
			// 
			// groupBox2
			// 
			this.groupBox2.BackColor = System.Drawing.Color.Transparent;
			this.groupBox2.Controls.Add(this.button8);
			this.groupBox2.Controls.Add(this.button9);
			this.groupBox2.Controls.Add(this.label16);
			this.groupBox2.Controls.Add(this.totalSemua);
			this.groupBox2.Controls.Add(this.label15);
			this.groupBox2.Controls.Add(this.bnyk);
			this.groupBox2.Controls.Add(this.listPesanan);
			this.groupBox2.Controls.Add(this.button7);
			this.groupBox2.Controls.Add(this.button2);
			this.groupBox2.Controls.Add(this.label13);
			this.groupBox2.Controls.Add(this.hrgMenu);
			this.groupBox2.Controls.Add(this.label14);
			this.groupBox2.Controls.Add(this.nmMenu);
			this.groupBox2.Controls.Add(this.label12);
			this.groupBox2.Controls.Add(this.idMn);
			this.groupBox2.Location = new System.Drawing.Point(12, 302);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(709, 206);
			this.groupBox2.TabIndex = 17;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Data Pesanan";
			// 
			// button8
			// 
			this.button8.Location = new System.Drawing.Point(325, 165);
			this.button8.Name = "button8";
			this.button8.Size = new System.Drawing.Size(52, 30);
			this.button8.TabIndex = 40;
			this.button8.Text = "TOTAL";
			this.button8.UseVisualStyleBackColor = true;
			this.button8.Click += new System.EventHandler(this.Button8Click);
			// 
			// button9
			// 
			this.button9.Location = new System.Drawing.Point(549, 165);
			this.button9.Name = "button9";
			this.button9.Size = new System.Drawing.Size(154, 30);
			this.button9.TabIndex = 39;
			this.button9.Text = "SIMPAN DATA PESANAN";
			this.button9.UseVisualStyleBackColor = true;
			this.button9.Click += new System.EventHandler(this.Button9Click);
			// 
			// label16
			// 
			this.label16.Location = new System.Drawing.Point(10, 174);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(145, 15);
			this.label16.TabIndex = 37;
			this.label16.Text = "Total Harga Keseluruhan : ";
			// 
			// totalSemua
			// 
			this.totalSemua.Location = new System.Drawing.Point(161, 171);
			this.totalSemua.Name = "totalSemua";
			this.totalSemua.Size = new System.Drawing.Size(158, 20);
			this.totalSemua.TabIndex = 36;
			// 
			// label15
			// 
			this.label15.Location = new System.Drawing.Point(528, 19);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(52, 15);
			this.label15.TabIndex = 35;
			this.label15.Text = "Banyak : ";
			// 
			// bnyk
			// 
			this.bnyk.Location = new System.Drawing.Point(585, 17);
			this.bnyk.Name = "bnyk";
			this.bnyk.Size = new System.Drawing.Size(56, 20);
			this.bnyk.TabIndex = 34;
			// 
			// listPesanan
			// 
			this.listPesanan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.listPesanan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.Column1,
									this.Column6,
									this.Column2,
									this.Column3,
									this.Column4,
									this.Column5});
			this.listPesanan.Location = new System.Drawing.Point(6, 44);
			this.listPesanan.Name = "listPesanan";
			this.listPesanan.Size = new System.Drawing.Size(697, 115);
			this.listPesanan.TabIndex = 33;
			this.listPesanan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListPesananCellClick);
			// 
			// Column1
			// 
			this.Column1.HeaderText = "Nama Menu";
			this.Column1.Name = "Column1";
			this.Column1.Width = 220;
			// 
			// Column6
			// 
			this.Column6.HeaderText = "ID Menu";
			this.Column6.Name = "Column6";
			this.Column6.ReadOnly = true;
			this.Column6.Width = 80;
			// 
			// Column2
			// 
			this.Column2.HeaderText = "Harga";
			this.Column2.Name = "Column2";
			this.Column2.Width = 70;
			// 
			// Column3
			// 
			this.Column3.HeaderText = "Jumlah";
			this.Column3.Name = "Column3";
			this.Column3.Width = 70;
			// 
			// Column4
			// 
			this.Column4.HeaderText = "Total";
			this.Column4.Name = "Column4";
			this.Column4.Width = 90;
			// 
			// Column5
			// 
			this.Column5.HeaderText = "Batal";
			this.Column5.Name = "Column5";
			this.Column5.Text = "Batal Pesanan";
			this.Column5.ToolTipText = "Batal Pesanan";
			this.Column5.UseColumnTextForButtonValue = true;
			// 
			// button7
			// 
			this.button7.Location = new System.Drawing.Point(647, 11);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(52, 30);
			this.button7.TabIndex = 33;
			this.button7.Text = "PESAN";
			this.button7.UseVisualStyleBackColor = true;
			this.button7.Click += new System.EventHandler(this.Button7Click);
			// 
			// button2
			// 
			this.button2.Font = new System.Drawing.Font("Wingdings 3", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
			this.button2.Location = new System.Drawing.Point(124, 15);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(31, 23);
			this.button2.TabIndex = 28;
			this.button2.Text = "R";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// label13
			// 
			this.label13.Location = new System.Drawing.Point(390, 19);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(52, 15);
			this.label13.TabIndex = 27;
			this.label13.Text = "Harga : ";
			// 
			// hrgMenu
			// 
			this.hrgMenu.Location = new System.Drawing.Point(438, 17);
			this.hrgMenu.Name = "hrgMenu";
			this.hrgMenu.ReadOnly = true;
			this.hrgMenu.Size = new System.Drawing.Size(84, 20);
			this.hrgMenu.TabIndex = 26;
			// 
			// label14
			// 
			this.label14.Location = new System.Drawing.Point(163, 20);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(76, 15);
			this.label14.TabIndex = 25;
			this.label14.Text = "Nama Menu : ";
			// 
			// nmMenu
			// 
			this.nmMenu.Location = new System.Drawing.Point(241, 16);
			this.nmMenu.Name = "nmMenu";
			this.nmMenu.ReadOnly = true;
			this.nmMenu.Size = new System.Drawing.Size(143, 20);
			this.nmMenu.TabIndex = 24;
			// 
			// label12
			// 
			this.label12.Location = new System.Drawing.Point(7, 19);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(60, 15);
			this.label12.TabIndex = 3;
			this.label12.Text = "ID Menu : ";
			// 
			// idMn
			// 
			this.idMn.Location = new System.Drawing.Point(73, 17);
			this.idMn.Name = "idMn";
			this.idMn.Size = new System.Drawing.Size(45, 20);
			this.idMn.TabIndex = 2;
			this.idMn.KeyDown += new System.Windows.Forms.KeyEventHandler(this.IdMnKeyDown);
			// 
			// FrmTambahPesanan
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(733, 514);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.groupBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "FrmTambahPesanan";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FrmTambahPesanan";
			this.Load += new System.EventHandler(this.FrmTambahPesananLoad);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.tabControl2.ResumeLayout(false);
			this.tabPage8.ResumeLayout(false);
			this.tabPage8.PerformLayout();
			this.tabPage9.ResumeLayout(false);
			this.tabPage9.PerformLayout();
			this.tabPage10.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.tampil)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.listPesanan)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button button8;
		private System.Windows.Forms.TextBox totalSemua;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Button button9;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
		private System.Windows.Forms.DataGridViewButtonColumn Column5;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		private System.Windows.Forms.DataGridView listPesanan;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button7;
		private System.Windows.Forms.TextBox bnyk;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.TextBox idMn;
		private System.Windows.Forms.TextBox nmMenu;
		private System.Windows.Forms.TextBox hrgMenu;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.ComboBox cmbTglReservasi;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.ComboBox cmbBlnReservasi;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.ComboBox cmbThnReservasi;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.TabPage tabPage10;
		private System.Windows.Forms.TextBox cariByNamaTamu;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TabPage tabPage9;
		private System.Windows.Forms.TextBox cariByNoKamar;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TabPage tabPage8;
		private System.Windows.Forms.TabControl tabControl2;
		private System.Windows.Forms.DataGridView tampil;
		private System.Windows.Forms.TextBox tipe;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox idRs;
		private System.Windows.Forms.TextBox nmTm;
		private System.Windows.Forms.TextBox ckOut;
		private System.Windows.Forms.TextBox ckIn;
		private System.Windows.Forms.TextBox nmKmr;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox1;
	}
}
