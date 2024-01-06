using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FinalProjeck_ApkArsipSurat
{
    public partial class Input_surat_masuk : Form
    {
        public Input_surat_masuk()
        {
            InitializeComponent();
        }
        private void tampilDataSuratMasuk()
        {
            // string query = "select kode_jenis_surat, tanggal_masuk, kop_surat, no_surat, perihal, isi_surat, pengirim  " +
            //   "from tbl_surat_masuk where kode_surat = '" + txtKodeSurat.Text + "'";
            string query = "SELECT * FROM tbl_surat_masuk";
            Manajer.Manajer_Surat_Masuk mp = new Manajer.Manajer_Surat_Masuk();
            mp.TampilData(query, "tbl_surat_masuk", dgSuratMasuk);
        }


        private void TampilData()
        {
            string query = "select * from tbl_surat_masuk " +
                "where kode_surat ='" + txtKodeSurat.Text + "'";
            Manajer.Manajer_Surat_Masuk mp = new Manajer.Manajer_Surat_Masuk();
            mp.TampilData(query, "tbl_surat_masuk", dgSuratMasuk);
        }
        private void tampilKodeJenisSurat()
        {
            //menampilkan data kode jenis surat
            string query = "SELECT kode_jenis_surat FROM tbl_jenis_surat";
            Fungsi.Set_Combobox(query, "kode_jenis_surat", cb_JS);
        }
        private void tampilJenisSurat()
        {
            //menampilkan jenis surat
            string query = "SELECT jenis_surat FROM tbl_jenis_surat " +
                "WHERE kode_jenis_surat = '" + cb_JS.Text + "'";
            Fungsi.Set_Textbox(query, "jenis_surat", txtJenisSurat);
        }
        private string tampilKodeSurat
        {
            get
            {
                SqlConnection conn = Koneksi.Conn;
                conn.Open();
                string nomor = "XYZ0001";
                SqlCommand cmd = new SqlCommand("SELECT MAX(RIGHT(kode_surat, 7)) FROM tbl_surat_masuk", conn);
                SqlDataReader sdr = cmd.ExecuteReader();
                sdr.Read();
                if (sdr[0].ToString() != "")
                {
                    nomor = "XYZ" + (int.Parse(sdr[0].ToString()) + 1).ToString("0000");
                    sdr.Close();
                }
                return nomor;
            }
        }


        private void UC_SuratMasuk_Load(object sender, EventArgs e)
        {
            tampilDataSuratMasuk();
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            txtKodeSurat.Text = tampilKodeSurat;
            tampilKodeJenisSurat();
        }

        private void cb_JS_SelectedIndexChanged(object sender, EventArgs e)
        {
            tampilJenisSurat();
        }
        private void cb_JS_TextChanged(object sender, EventArgs e)
        {
            tampilJenisSurat();
        }

        private void Clear()
        {
            txtKodeSurat.Clear();
            cb_JS.SelectedIndex = -1;
            txtJenisSurat.Clear();
            txtKopSurat.Clear();
            txtNoSurat.Clear();
            txtPerihal.Clear();
            txtIsiSurat.Clear();
            txtPengirim.Clear();
            txtKopSurat.Focus();

        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            SqlConnection koneksii = Koneksi.Conn;
            koneksii.Open();
            SqlCommand cmd = new SqlCommand("SELECT kode_surat, kode_jenis_surat, tanggal_masuk, kop_surat, no_surat,perihal, isi_surat, pengirim FROM tbl_surat_masuk WHERE " +
                "kode_surat='" + txtKodeSurat.Text + "' AND kode_jenis_surat='" + cb_JS.Text + "'");
            cmd.Connection = koneksii;
            string cek = (string)cmd.ExecuteScalar();
            koneksii.Close();

            Entitas.Surat_Masuk p = new Entitas.Surat_Masuk(txtKodeSurat.Text, cb_JS.Text, dt1.Value,
            txtKopSurat.Text, txtNoSurat.Text, txtPerihal.Text, txtIsiSurat.Text, txtPengirim.Text);
            Manajer.Manajer_Surat_Masuk mp = new Manajer.Manajer_Surat_Masuk();
            //int i;


            mp.Tambah(p);
            tampilDataSuratMasuk();

        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Yakin Mau Hapus?", "Peringatan",
               MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                string hapuskodesurat = txtKodeSurat.Text;
                //string hapuscbJS = cb_JS.SelectedItem.ToString();
                string ttt = txtJenisSurat.Text;
                string hapuskopsurat = txtKopSurat.Text;
                string hapusnosurat = txtNoSurat.Text;
                string hapusperihal = txtPerihal.Text;
                string hapusisisurat = txtIsiSurat.Text;
                string hapuspengirim = txtPengirim.Text;
                Manajer.Manajer_Surat_Masuk mm = new Manajer.Manajer_Surat_Masuk();
                mm.Hapus(hapuskodesurat);
                //mm.Hapus(hapuscbJS);
                mm.Hapus(ttt);
                mm.Hapus(hapuskopsurat);
                mm.Hapus(hapusnosurat);
                mm.Hapus(hapusperihal);
                mm.Hapus(hapusisisurat);
                mm.Hapus(hapuspengirim);

            }
            tampilDataSuratMasuk();
            Clear();
        }

        private void dgSuratMasuk_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtKodeSurat.Text = dgSuratMasuk.CurrentRow.Cells["kode_surat"].Value.ToString();
            cb_JS.Text = dgSuratMasuk.CurrentRow.Cells["kode_jenis_surat"].Value.ToString();
            dt1.Text = dgSuratMasuk.CurrentRow.Cells["tanggal_masuk"].Value.ToString();
            txtKopSurat.Text = dgSuratMasuk.CurrentRow.Cells["kop_surat"].Value.ToString();
            txtNoSurat.Text = dgSuratMasuk.CurrentRow.Cells["no_surat"].Value.ToString();
            txtPerihal.Text = dgSuratMasuk.CurrentRow.Cells["perihal"].Value.ToString();
            txtIsiSurat.Text = dgSuratMasuk.CurrentRow.Cells["isi_surat"].Value.ToString();
            txtPengirim.Text = dgSuratMasuk.CurrentRow.Cells["pengirim"].Value.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            SqlConnection koneksii = Koneksi.Conn;
            koneksii.Open();
            SqlCommand cmd = new SqlCommand("SELECT kode_jenis_surat, tanggal_masuk, kop_surat, no_surat,perihal, isi_surat, pengirim FROM tbl_surat_masuk WHERE " +
                "kode_surat='" + txtKodeSurat.Text + "' AND kode_jenis_surat='" + cb_JS.Text + "'");
            cmd.Connection = koneksii;
            string cek = (string)cmd.ExecuteScalar();
            koneksii.Close();

            Entitas.Surat_Masuk p = new Entitas.Surat_Masuk(txtKodeSurat.Text, cb_JS.Text, dt1.Value,
            txtKopSurat.Text, txtNoSurat.Text, txtPerihal.Text, txtIsiSurat.Text, txtPengirim.Text);
            Manajer.Manajer_Surat_Masuk mp = new Manajer.Manajer_Surat_Masuk();
            mp.Edit(p);
            tampilDataSuratMasuk();
        }

        private void btnCetak_Click(object sender, EventArgs e)
        {
            LaporanSuratMasuk p = new LaporanSuratMasuk();
            p.Show();

        }

    }
}
