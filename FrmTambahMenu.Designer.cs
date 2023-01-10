/*
 * Created by SharpDevelop.
 * User: FVCK-32
 * Date: 19/01/2011
 * Time: 8:27
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace penginapan
{
	partial class FrmTambahMenu
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
            this.button3 = new System.Windows.Forms.Button();
            this.harga = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nama = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tampil = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.cariMenu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tampil)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.harga);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.nama);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(412, 116);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tambah Menu Makanan - Minuman";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(215, 71);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 39);
            this.button1.TabIndex = 15;
            this.button1.Text = "REFRESH DATA";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(320, 71);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 39);
            this.button3.TabIndex = 14;
            this.button3.Text = "SIMPAN";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3Click);
            // 
            // harga
            // 
            this.harga.Location = new System.Drawing.Point(166, 46);
            this.harga.Name = "harga";
            this.harga.Size = new System.Drawing.Size(229, 20);
            this.harga.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(11, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Harga Makanan / Minuman :";
            // 
            // nama
            // 
            this.nama.Location = new System.Drawing.Point(166, 20);
            this.nama.Name = "nama";
            this.nama.Size = new System.Drawing.Size(229, 20);
            this.nama.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(11, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nama Makanan / Minuman :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Location = new System.Drawing.Point(12, -8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(412, 69);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // tampil
            // 
            this.tampil.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tampil.Location = new System.Drawing.Point(12, 189);
            this.tampil.Name = "tampil";
            this.tampil.Size = new System.Drawing.Size(412, 159);
            this.tampil.TabIndex = 17;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(12, 354);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(412, 110);
            this.tabControl1.TabIndex = 18;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.cariMenu);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(404, 84);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Cari Daftar Menu Makanan - Minuman";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(316, 38);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 39);
            this.button2.TabIndex = 16;
            this.button2.Text = "CARI DATA";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2Click);
            // 
            // cariMenu
            // 
            this.cariMenu.Location = new System.Drawing.Point(162, 12);
            this.cariMenu.Name = "cariMenu";
            this.cariMenu.Size = new System.Drawing.Size(229, 20);
            this.cariMenu.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(7, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nama Makanan / Minuman :";
            // 
            // FrmTambahMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(436, 476);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.tampil);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmTambahMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmTambahMenu";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tampil)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

		}
		private System.Windows.Forms.DataGridView tampil;
		private System.Windows.Forms.TextBox cariMenu;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox nama;
		private System.Windows.Forms.TextBox harga;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.GroupBox groupBox1;
	}
}
