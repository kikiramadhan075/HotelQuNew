/*
 * Created by SharpDevelop.
 * User: FVCK-32
 * Date: 22/01/2011
 * Time: 2:51
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace penginapan
{
	partial class FrmCekOut
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.ttlBiaya = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.hrgKmr = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lmInap = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cekOut = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.cekIn = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.tpKmr = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nmTm = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nmKmr = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.idRs = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button8 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.tampil = new System.Windows.Forms.DataGridView();
            this.totalSemua = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.kembali = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.bayar = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.ttlBiayaSemua = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.ttlBiayaInap = new System.Windows.Forms.TextBox();
            this.ttlBiayaPesanan = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tampil)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.ttlBiaya);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.hrgKmr);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.lmInap);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cekOut);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cekIn);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tpKmr);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.nmTm);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.nmKmr);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.idRs);
            this.groupBox1.Location = new System.Drawing.Point(12, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(593, 130);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Data Reservasi";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(483, 78);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 43);
            this.button1.TabIndex = 19;
            this.button1.Text = "UPDATE DATA";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1Click);
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(377, 53);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 16);
            this.label9.TabIndex = 18;
            this.label9.Text = "Total Biaya Inap :";
            // 
            // ttlBiaya
            // 
            this.ttlBiaya.Location = new System.Drawing.Point(471, 50);
            this.ttlBiaya.Name = "ttlBiaya";
            this.ttlBiaya.ReadOnly = true;
            this.ttlBiaya.Size = new System.Drawing.Size(116, 20);
            this.ttlBiaya.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(6, 55);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 16);
            this.label8.TabIndex = 16;
            this.label8.Text = "Harga Per Hari :";
            // 
            // hrgKmr
            // 
            this.hrgKmr.Location = new System.Drawing.Point(100, 51);
            this.hrgKmr.Name = "hrgKmr";
            this.hrgKmr.ReadOnly = true;
            this.hrgKmr.Size = new System.Drawing.Size(101, 20);
            this.hrgKmr.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(208, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "Lama Inap :";
            // 
            // lmInap
            // 
            this.lmInap.Location = new System.Drawing.Point(283, 50);
            this.lmInap.Name = "lmInap";
            this.lmInap.ReadOnly = true;
            this.lmInap.Size = new System.Drawing.Size(87, 20);
            this.lmInap.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(207, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Cek Out :";
            // 
            // cekOut
            // 
            this.cekOut.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.cekOut.Location = new System.Drawing.Point(271, 81);
            this.cekOut.Name = "cekOut";
            this.cekOut.Size = new System.Drawing.Size(141, 20);
            this.cekOut.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(6, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Cek In :";
            // 
            // cekIn
            // 
            this.cekIn.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.cekIn.Location = new System.Drawing.Point(60, 81);
            this.cekIn.Name = "cekIn";
            this.cekIn.Size = new System.Drawing.Size(141, 20);
            this.cekIn.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(253, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Tipe :";
            // 
            // tpKmr
            // 
            this.tpKmr.Location = new System.Drawing.Point(299, 24);
            this.tpKmr.Name = "tpKmr";
            this.tpKmr.ReadOnly = true;
            this.tpKmr.Size = new System.Drawing.Size(71, 20);
            this.tpKmr.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(379, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nama Tamu :";
            // 
            // nmTm
            // 
            this.nmTm.Location = new System.Drawing.Point(455, 24);
            this.nmTm.Name = "nmTm";
            this.nmTm.ReadOnly = true;
            this.nmTm.Size = new System.Drawing.Size(132, 20);
            this.nmTm.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(127, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "No Kamar :";
            // 
            // nmKmr
            // 
            this.nmKmr.Location = new System.Drawing.Point(202, 23);
            this.nmKmr.Name = "nmKmr";
            this.nmKmr.ReadOnly = true;
            this.nmKmr.Size = new System.Drawing.Size(40, 20);
            this.nmKmr.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID Reservasi :";
            // 
            // idRs
            // 
            this.idRs.Location = new System.Drawing.Point(82, 23);
            this.idRs.Name = "idRs";
            this.idRs.ReadOnly = true;
            this.idRs.Size = new System.Drawing.Size(40, 20);
            this.idRs.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Location = new System.Drawing.Point(12, -8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(593, 63);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.button8);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.tampil);
            this.groupBox2.Controls.Add(this.totalSemua);
            this.groupBox2.Location = new System.Drawing.Point(12, 197);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(593, 170);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Data Pesanan Makanan - Minuman";
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(268, 134);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(52, 30);
            this.button8.TabIndex = 43;
            this.button8.Text = "TOTAL";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.Button8Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(455, 132);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(132, 31);
            this.button2.TabIndex = 20;
            this.button2.Text = "LIHAT DATA PESANAN";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2Click);
            // 
            // label16
            // 
            this.label16.Location = new System.Drawing.Point(6, 142);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(116, 15);
            this.label16.TabIndex = 42;
            this.label16.Text = "Total Biaya Pesanan : ";
            // 
            // tampil
            // 
            this.tampil.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tampil.Location = new System.Drawing.Point(6, 23);
            this.tampil.Name = "tampil";
            this.tampil.Size = new System.Drawing.Size(581, 103);
            this.tampil.TabIndex = 0;
            // 
            // totalSemua
            // 
            this.totalSemua.Location = new System.Drawing.Point(127, 140);
            this.totalSemua.Name = "totalSemua";
            this.totalSemua.ReadOnly = true;
            this.totalSemua.Size = new System.Drawing.Size(135, 20);
            this.totalSemua.TabIndex = 41;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Controls.Add(this.kembali);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.bayar);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.ttlBiayaSemua);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.ttlBiayaInap);
            this.groupBox3.Controls.Add(this.ttlBiayaPesanan);
            this.groupBox3.Location = new System.Drawing.Point(13, 375);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(592, 114);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Pembayaran";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(378, 64);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(196, 44);
            this.button3.TabIndex = 20;
            this.button3.Text = "SIMPAN DATA PEMBAYARAN";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3Click);
            // 
            // kembali
            // 
            this.kembali.Location = new System.Drawing.Point(398, 43);
            this.kembali.Name = "kembali";
            this.kembali.ReadOnly = true;
            this.kembali.Size = new System.Drawing.Size(176, 20);
            this.kembali.TabIndex = 53;
            // 
            // label15
            // 
            this.label15.Location = new System.Drawing.Point(298, 46);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(94, 16);
            this.label15.TabIndex = 52;
            this.label15.Text = "Sisa Kembalian :";
            // 
            // bayar
            // 
            this.bayar.Location = new System.Drawing.Point(398, 18);
            this.bayar.Name = "bayar";
            this.bayar.Size = new System.Drawing.Size(176, 20);
            this.bayar.TabIndex = 51;
            this.bayar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BayarKeyDown);
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(298, 21);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(94, 16);
            this.label14.TabIndex = 50;
            this.label14.Text = "Pembayaran :";
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(5, 81);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(116, 15);
            this.label13.TabIndex = 48;
            this.label13.Text = "Total Semua Biaya : ";
            // 
            // ttlBiayaSemua
            // 
            this.ttlBiayaSemua.Location = new System.Drawing.Point(126, 79);
            this.ttlBiayaSemua.Name = "ttlBiayaSemua";
            this.ttlBiayaSemua.ReadOnly = true;
            this.ttlBiayaSemua.Size = new System.Drawing.Size(150, 20);
            this.ttlBiayaSemua.TabIndex = 47;
            this.ttlBiayaSemua.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(121, 64);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(171, 12);
            this.label12.TabIndex = 46;
            this.label12.Text = "------------------------------------------------ +";
            this.label12.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(5, 22);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(94, 16);
            this.label11.TabIndex = 21;
            this.label11.Text = "Total Biaya Inap :";
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(5, 46);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(116, 15);
            this.label10.TabIndex = 45;
            this.label10.Text = "Total Biaya Pesanan : ";
            // 
            // ttlBiayaInap
            // 
            this.ttlBiayaInap.Location = new System.Drawing.Point(126, 18);
            this.ttlBiayaInap.Name = "ttlBiayaInap";
            this.ttlBiayaInap.ReadOnly = true;
            this.ttlBiayaInap.Size = new System.Drawing.Size(150, 20);
            this.ttlBiayaInap.TabIndex = 20;
            this.ttlBiayaInap.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ttlBiayaPesanan
            // 
            this.ttlBiayaPesanan.Location = new System.Drawing.Point(126, 44);
            this.ttlBiayaPesanan.Name = "ttlBiayaPesanan";
            this.ttlBiayaPesanan.ReadOnly = true;
            this.ttlBiayaPesanan.Size = new System.Drawing.Size(150, 20);
            this.ttlBiayaPesanan.TabIndex = 44;
            this.ttlBiayaPesanan.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // FrmCekOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(617, 501);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmCekOut";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCekOut";
            this.Load += new System.EventHandler(this.FrmCekOutLoad);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tampil)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

		}
		private System.Windows.Forms.TextBox ttlBiayaPesanan;
		private System.Windows.Forms.TextBox ttlBiayaInap;
		private System.Windows.Forms.TextBox ttlBiayaSemua;
		private System.Windows.Forms.TextBox bayar;
		private System.Windows.Forms.TextBox kembali;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.TextBox totalSemua;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Button button8;
		private System.Windows.Forms.DataGridView tampil;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.TextBox idRs;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox nmKmr;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox nmTm;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox tpKmr;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.DateTimePicker cekIn;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.DateTimePicker cekOut;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox lmInap;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox hrgKmr;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox ttlBiaya;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.GroupBox groupBox1;
	}
}
