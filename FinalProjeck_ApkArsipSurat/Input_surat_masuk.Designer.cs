
namespace FinalProjeck_ApkArsipSurat
{
    partial class Input_surat_masuk
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
            this.components = new System.ComponentModel.Container();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tbljenissuratBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtJenisSurat = new System.Windows.Forms.TextBox();
            this.cb_JS = new System.Windows.Forms.ComboBox();
            this.txtPengirim = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtIsiSurat = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPerihal = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNoSurat = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dt1 = new System.Windows.Forms.DateTimePicker();
            this.btnCetak = new System.Windows.Forms.Button();
            this.btnUbah = new System.Windows.Forms.Button();
            this.dgSuratMasuk = new System.Windows.Forms.DataGridView();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.btnHapus = new System.Windows.Forms.Button();
            this.btnTambah = new System.Windows.Forms.Button();
            this.txtKopSurat = new System.Windows.Forms.TextBox();
            this.txtKodeSurat = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.tbljenissuratBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgSuratMasuk)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(621, 284);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(0, 16);
            this.label12.TabIndex = 146;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(398, 119);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 16);
            this.label11.TabIndex = 144;
            this.label11.Text = "Jenis Surat";
            // 
            // tbljenissuratBindingSource
            // 
            this.tbljenissuratBindingSource.DataMember = "tbl_jenis_surat";
            // 
            // txtJenisSurat
            // 
            this.txtJenisSurat.Location = new System.Drawing.Point(489, 122);
            this.txtJenisSurat.Name = "txtJenisSurat";
            this.txtJenisSurat.Size = new System.Drawing.Size(141, 20);
            this.txtJenisSurat.TabIndex = 145;
            // 
            // cb_JS
            // 
            this.cb_JS.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tbljenissuratBindingSource, "jenis_surat", true));
            this.cb_JS.FormattingEnabled = true;
            this.cb_JS.Location = new System.Drawing.Point(489, 82);
            this.cb_JS.Name = "cb_JS";
            this.cb_JS.Size = new System.Drawing.Size(141, 21);
            this.cb_JS.TabIndex = 143;
            // 
            // txtPengirim
            // 
            this.txtPengirim.Location = new System.Drawing.Point(430, 155);
            this.txtPengirim.Name = "txtPengirim";
            this.txtPengirim.Size = new System.Drawing.Size(203, 20);
            this.txtPengirim.TabIndex = 142;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(363, 155);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 16);
            this.label10.TabIndex = 141;
            this.label10.Text = "Pengirim";
            // 
            // txtIsiSurat
            // 
            this.txtIsiSurat.Location = new System.Drawing.Point(130, 220);
            this.txtIsiSurat.Multiline = true;
            this.txtIsiSurat.Name = "txtIsiSurat";
            this.txtIsiSurat.Size = new System.Drawing.Size(214, 135);
            this.txtIsiSurat.TabIndex = 140;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(9, 220);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 16);
            this.label7.TabIndex = 139;
            this.label7.Text = "Isi Surat";
            // 
            // txtPerihal
            // 
            this.txtPerihal.Location = new System.Drawing.Point(430, 181);
            this.txtPerihal.Name = "txtPerihal";
            this.txtPerihal.Size = new System.Drawing.Size(203, 20);
            this.txtPerihal.TabIndex = 138;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(363, 185);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 16);
            this.label6.TabIndex = 137;
            this.label6.Text = "Perihal";
            // 
            // txtNoSurat
            // 
            this.txtNoSurat.Location = new System.Drawing.Point(130, 184);
            this.txtNoSurat.Name = "txtNoSurat";
            this.txtNoSurat.Size = new System.Drawing.Size(214, 20);
            this.txtNoSurat.TabIndex = 136;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 16);
            this.label5.TabIndex = 135;
            this.label5.Text = "No Surat";
            // 
            // dt1
            // 
            this.dt1.Location = new System.Drawing.Point(130, 119);
            this.dt1.Name = "dt1";
            this.dt1.Size = new System.Drawing.Size(214, 20);
            this.dt1.TabIndex = 134;
            // 
            // btnCetak
            // 
            this.btnCetak.Location = new System.Drawing.Point(539, 277);
            this.btnCetak.Name = "btnCetak";
            this.btnCetak.Size = new System.Drawing.Size(76, 30);
            this.btnCetak.TabIndex = 133;
            this.btnCetak.Text = "Cetak";
            this.btnCetak.UseVisualStyleBackColor = true;
            // 
            // btnUbah
            // 
            this.btnUbah.Location = new System.Drawing.Point(539, 232);
            this.btnUbah.Name = "btnUbah";
            this.btnUbah.Size = new System.Drawing.Size(76, 30);
            this.btnUbah.TabIndex = 131;
            this.btnUbah.Text = "Ubah";
            this.btnUbah.UseVisualStyleBackColor = true;
            // 
            // dgSuratMasuk
            // 
            this.dgSuratMasuk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSuratMasuk.Location = new System.Drawing.Point(-9, 361);
            this.dgSuratMasuk.Name = "dgSuratMasuk";
            this.dgSuratMasuk.Size = new System.Drawing.Size(809, 236);
            this.dgSuratMasuk.TabIndex = 127;
            // 
            // btnSimpan
            // 
            this.btnSimpan.Location = new System.Drawing.Point(461, 232);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(72, 30);
            this.btnSimpan.TabIndex = 129;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = true;
            // 
            // btnHapus
            // 
            this.btnHapus.Location = new System.Drawing.Point(383, 277);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(76, 30);
            this.btnHapus.TabIndex = 130;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.UseVisualStyleBackColor = true;
            // 
            // btnTambah
            // 
            this.btnTambah.Location = new System.Drawing.Point(383, 232);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(72, 30);
            this.btnTambah.TabIndex = 128;
            this.btnTambah.Text = "Tambah";
            this.btnTambah.UseVisualStyleBackColor = true;
            // 
            // txtKopSurat
            // 
            this.txtKopSurat.Location = new System.Drawing.Point(130, 155);
            this.txtKopSurat.Name = "txtKopSurat";
            this.txtKopSurat.Size = new System.Drawing.Size(214, 20);
            this.txtKopSurat.TabIndex = 126;
            // 
            // txtKodeSurat
            // 
            this.txtKodeSurat.Location = new System.Drawing.Point(130, 82);
            this.txtKodeSurat.Name = "txtKodeSurat";
            this.txtKodeSurat.Size = new System.Drawing.Size(214, 20);
            this.txtKodeSurat.TabIndex = 125;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(9, 155);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 16);
            this.label9.TabIndex = 124;
            this.label9.Text = "Kop Surat";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(9, 119);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 16);
            this.label8.TabIndex = 123;
            this.label8.Text = "Tanggal Masuk";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(363, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 16);
            this.label4.TabIndex = 122;
            this.label4.Text = "Kode Jenis Surat";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(14, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Arsip Surat";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(465, 277);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(68, 30);
            this.btnClear.TabIndex = 132;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Book Antiqua", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(505, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Surat Masuk";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 16);
            this.label3.TabIndex = 121;
            this.label3.Text = "Kode Surat";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSlateGray;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 61);
            this.panel1.TabIndex = 120;
            // 
            // Input_surat_masuk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtJenisSurat);
            this.Controls.Add(this.cb_JS);
            this.Controls.Add(this.txtPengirim);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtIsiSurat);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtPerihal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtNoSurat);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dt1);
            this.Controls.Add(this.btnCetak);
            this.Controls.Add(this.btnUbah);
            this.Controls.Add(this.dgSuratMasuk);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.btnHapus);
            this.Controls.Add(this.btnTambah);
            this.Controls.Add(this.txtKopSurat);
            this.Controls.Add(this.txtKodeSurat);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Name = "Input_surat_masuk";
            this.Text = "Input_surat_masuk";
            ((System.ComponentModel.ISupportInitialize)(this.tbljenissuratBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgSuratMasuk)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.BindingSource tbljenissuratBindingSource;
        private System.Windows.Forms.TextBox txtJenisSurat;
        private System.Windows.Forms.ComboBox cb_JS;
        private System.Windows.Forms.TextBox txtPengirim;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtIsiSurat;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPerihal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNoSurat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dt1;
        private System.Windows.Forms.Button btnCetak;
        private System.Windows.Forms.Button btnUbah;
        private System.Windows.Forms.DataGridView dgSuratMasuk;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.TextBox txtKopSurat;
        private System.Windows.Forms.TextBox txtKodeSurat;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
    }
}