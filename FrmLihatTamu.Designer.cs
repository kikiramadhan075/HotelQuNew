/*
 * Created by SharpDevelop.
 * User: FVCK-32
 * Date: 25/01/2011
 * Time: 4:53
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace penginapan
{
	partial class FrmLihatTamu
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
            this.tampil = new System.Windows.Forms.DataGridView();
            this.tabControl5 = new System.Windows.Forms.TabControl();
            this.tabPage17 = new System.Windows.Forms.TabPage();
            this.label17 = new System.Windows.Forms.Label();
            this.button16 = new System.Windows.Forms.Button();
            this.nmTamu = new System.Windows.Forms.TextBox();
            this.tabPage18 = new System.Windows.Forms.TabPage();
            this.label16 = new System.Windows.Forms.Label();
            this.button15 = new System.Windows.Forms.Button();
            this.almtTamu = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tampil)).BeginInit();
            this.tabControl5.SuspendLayout();
            this.tabPage17.SuspendLayout();
            this.tabPage18.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.tampil);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(561, 238);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Data Tamu";
            // 
            // tampil
            // 
            this.tampil.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tampil.Location = new System.Drawing.Point(6, 19);
            this.tampil.Name = "tampil";
            this.tampil.RowHeadersWidth = 51;
            this.tampil.Size = new System.Drawing.Size(549, 213);
            this.tampil.TabIndex = 0;
            this.tampil.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tampil_CellContentClick);
            // 
            // tabControl5
            // 
            this.tabControl5.Controls.Add(this.tabPage17);
            this.tabControl5.Controls.Add(this.tabPage18);
            this.tabControl5.Location = new System.Drawing.Point(12, 256);
            this.tabControl5.Name = "tabControl5";
            this.tabControl5.SelectedIndex = 0;
            this.tabControl5.Size = new System.Drawing.Size(561, 59);
            this.tabControl5.TabIndex = 1;
            // 
            // tabPage17
            // 
            this.tabPage17.Controls.Add(this.label17);
            this.tabPage17.Controls.Add(this.button16);
            this.tabPage17.Controls.Add(this.nmTamu);
            this.tabPage17.Location = new System.Drawing.Point(4, 22);
            this.tabPage17.Name = "tabPage17";
            this.tabPage17.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage17.Size = new System.Drawing.Size(553, 33);
            this.tabPage17.TabIndex = 1;
            this.tabPage17.Text = "Cari Berdasarkan Nama Tamu";
            this.tabPage17.UseVisualStyleBackColor = true;
            // 
            // label17
            // 
            this.label17.Location = new System.Drawing.Point(8, 8);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(78, 20);
            this.label17.TabIndex = 5;
            this.label17.Text = "Nama Tamu :";
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(299, 5);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(75, 23);
            this.button16.TabIndex = 4;
            this.button16.Text = "Cari";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.Button16Click);
            // 
            // nmTamu
            // 
            this.nmTamu.Location = new System.Drawing.Point(92, 6);
            this.nmTamu.Name = "nmTamu";
            this.nmTamu.Size = new System.Drawing.Size(201, 20);
            this.nmTamu.TabIndex = 3;
            // 
            // tabPage18
            // 
            this.tabPage18.Controls.Add(this.label16);
            this.tabPage18.Controls.Add(this.button15);
            this.tabPage18.Controls.Add(this.almtTamu);
            this.tabPage18.Location = new System.Drawing.Point(4, 22);
            this.tabPage18.Name = "tabPage18";
            this.tabPage18.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage18.Size = new System.Drawing.Size(553, 33);
            this.tabPage18.TabIndex = 2;
            this.tabPage18.Text = "Cari Berdasarkan Alamat Tamu";
            this.tabPage18.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            this.label16.Location = new System.Drawing.Point(9, 8);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(78, 20);
            this.label16.TabIndex = 8;
            this.label16.Text = "Alamat Tamu:";
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(300, 5);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(75, 23);
            this.button15.TabIndex = 7;
            this.button15.Text = "Cari";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.Button15Click);
            // 
            // almtTamu
            // 
            this.almtTamu.Location = new System.Drawing.Point(93, 6);
            this.almtTamu.Name = "almtTamu";
            this.almtTamu.Size = new System.Drawing.Size(201, 20);
            this.almtTamu.TabIndex = 6;
            // 
            // FrmLihatTamu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(585, 331);
            this.Controls.Add(this.tabControl5);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmLihatTamu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmLihatTamu";
            this.Load += new System.EventHandler(this.FrmLihatTamuLoad);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tampil)).EndInit();
            this.tabControl5.ResumeLayout(false);
            this.tabPage17.ResumeLayout(false);
            this.tabPage17.PerformLayout();
            this.tabPage18.ResumeLayout(false);
            this.tabPage18.PerformLayout();
            this.ResumeLayout(false);

		}
		private System.Windows.Forms.TextBox almtTamu;
		private System.Windows.Forms.Button button15;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.TabPage tabPage18;
		private System.Windows.Forms.TextBox nmTamu;
		private System.Windows.Forms.Button button16;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.TabPage tabPage17;
		private System.Windows.Forms.TabControl tabControl5;
		private System.Windows.Forms.DataGridView tampil;
		private System.Windows.Forms.GroupBox groupBox1;
	}
}
