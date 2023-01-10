/*
 * Created by SharpDevelop.
 * User: FVCK-32
 * Date: 19/01/2011
 * Time: 7:32
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace penginapan
{
	partial class FrmTambahTamu
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
            this.cmbJk = new System.Windows.Forms.ComboBox();
            this.pekerjaan = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.telpon = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.alamatTamu = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nmTamu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.cmbJk);
            this.groupBox1.Controls.Add(this.pekerjaan);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.telpon);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.alamatTamu);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.nmTamu);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(320, 158);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tambah Data Tamu";
            // 
            // cmbJk
            // 
            this.cmbJk.FormattingEnabled = true;
            this.cmbJk.Items.AddRange(new object[] {
            "L",
            "P"});
            this.cmbJk.Location = new System.Drawing.Point(106, 98);
            this.cmbJk.Name = "cmbJk";
            this.cmbJk.Size = new System.Drawing.Size(121, 21);
            this.cmbJk.TabIndex = 10;
            // 
            // pekerjaan
            // 
            this.pekerjaan.Location = new System.Drawing.Point(106, 124);
            this.pekerjaan.Name = "pekerjaan";
            this.pekerjaan.Size = new System.Drawing.Size(196, 20);
            this.pekerjaan.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(9, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 23);
            this.label5.TabIndex = 8;
            this.label5.Text = "Pekerjaan :";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(9, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "Jenis Kelamin :";
            // 
            // telpon
            // 
            this.telpon.Location = new System.Drawing.Point(106, 72);
            this.telpon.Name = "telpon";
            this.telpon.Size = new System.Drawing.Size(196, 20);
            this.telpon.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(9, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "No Telpon :";
            // 
            // alamatTamu
            // 
            this.alamatTamu.Location = new System.Drawing.Point(106, 46);
            this.alamatTamu.Name = "alamatTamu";
            this.alamatTamu.Size = new System.Drawing.Size(196, 20);
            this.alamatTamu.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(9, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Alamat Tamu :";
            // 
            // nmTamu
            // 
            this.nmTamu.Location = new System.Drawing.Point(106, 20);
            this.nmTamu.Name = "nmTamu";
            this.nmTamu.Size = new System.Drawing.Size(196, 20);
            this.nmTamu.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(9, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nama Tamu :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Location = new System.Drawing.Point(12, -5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(320, 68);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(257, 233);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 39);
            this.button3.TabIndex = 15;
            this.button3.Text = "SIMPAN";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(176, 233);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 39);
            this.button4.TabIndex = 14;
            this.button4.Text = "BATAL";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // FrmTambahTamu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(348, 296);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmTambahTamu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmTambahTamu";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

		}
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.TextBox nmTamu;
		private System.Windows.Forms.TextBox alamatTamu;
		private System.Windows.Forms.TextBox telpon;
		private System.Windows.Forms.TextBox pekerjaan;
		private System.Windows.Forms.ComboBox cmbJk;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.GroupBox groupBox1;
	}
}
