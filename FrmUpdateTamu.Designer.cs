
namespace penginapan
{
    partial class FrmUpdateTamu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
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
            this.btnupdate = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
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
            this.groupBox1.Location = new System.Drawing.Point(9, 82);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(320, 158);
            this.groupBox1.TabIndex = 1;
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
            this.pictureBox1.Location = new System.Drawing.Point(9, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(320, 68);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(254, 286);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(75, 23);
            this.btnupdate.TabIndex = 3;
            this.btnupdate.Text = "UPDATE";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(173, 286);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_delete.TabIndex = 4;
            this.btn_delete.Text = "DELETE";
            this.btn_delete.UseVisualStyleBackColor = true;
            // 
            // FrmUpdateTamu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(341, 334);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmUpdateTamu";
            this.Text = "FrmUpdateTamu";
            this.Load += new System.EventHandler(this.FrmUpdateTamu_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbJk;
        private System.Windows.Forms.TextBox pekerjaan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox telpon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox alamatTamu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nmTamu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btn_delete;
    }
}