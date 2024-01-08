using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace AplikasiArsipSurat
{
    public partial class UC_SuratKeluar : UserControl
    {
        public UC_SuratKeluar()
        {
            InitializeComponent();
        }

        private void tampilDataSuratMasuk()
        {
            // string query = "select kode_jenis_surat, tanggal_masuk, kop_surat, no_surat, perihal, isi_surat, pengirim  " +
            //   "from tbl_surat_masuk where kode_surat = '" + txtKodeSurat.Text + "'";
            string query = "SELECT * FROM tbl_surat_keluar";
            Manajer.Manajer_Surat_Keluar mp = new Manajer.Manajer_Surat_Keluar();
            mp.TampilData(query, "tbl_surat_keluar", dgSuratKeluar);
        }
        private void TampilData()
        {
            string query = "select * from tbl_surat_keluar " +
                "where kode_surat_keluar ='" + txtKodeSuratKeluar.Text + "'";
            Manajer.Manajer_Surat_Keluar mp = new Manajer.Manajer_Surat_Keluar();
            mp.TampilData(query, "tbl_surat_keluar", dgSuratKeluar);
        }
        private void tampilKodeDisposisi()
        {
            string query = "SELECT kode_disposisi FROM tbl_disposisi";
            Fungsi.Set_Combobox(query, "kode_disposisi", cbDisposisi);
        }

        private void tampilDisposisi()
        {
            string query = "SELECT kode_surat, kode_status, tujuan, isi, catatan FROM tbl_disposisi " +
                "WHERE kode_disposisi = '" + cbDisposisi.Text + "'";
            Fungsi.Set_Textbox(query, "kode_surat", txtKodeSurat);
            Fungsi.Set_Textbox(query, "kode_status", txtKodeStatus);
            Fungsi.Set_Textbox(query, "tujuan", txtTujuan);
            Fungsi.Set_Textbox(query, "isi", txtIsiSuratKeluar);
            Fungsi.Set_Textbox(query, "catatan", txtCatatan);
        }
        private string tampilKodeSurat
        {
            get
            {
                SqlConnection conn = Koneksi.Conn;
                conn.Open();
                string nomor = "RSC0001";
                SqlCommand cmd = new SqlCommand("SELECT MAX(RIGHT(kode_surat, 7)) FROM tbl_surat_masuk", conn);
                SqlDataReader sdr = cmd.ExecuteReader();
                sdr.Read();
                if (sdr[0].ToString() != "")
                {
                    nomor = "RSC" + (int.Parse(sdr[0].ToString()) + 1).ToString("0000");
                    sdr.Close();
                }
                return nomor;
            }
        }
        private void UC_SuratKeluar_Load(object sender, EventArgs e)
        {
            tampilDataSuratMasuk();
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            txtKodeSuratKeluar.Text = tampilKodeSurat;
            tampilKodeDisposisi();
        }

        private void cbDisposisi_SelectedIndexChanged(object sender, EventArgs e)
        {
            tampilDisposisi();
        }

        private void cbDisposisi_TextChanged(object sender, EventArgs e)
        {
            tampilDisposisi();
        }
        private void Clear()
        {
            txtKodeSuratKeluar.Clear();
            cbDisposisi.SelectedIndex = -1;
            cbDisposisi.Focus();

        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection koneksii = Koneksi.Conn;
                koneksii.Open();
                SqlCommand cmd = new SqlCommand("SELECT kode_surat_keluar, kode_disposisi FROM tbl_surat_keluar WHERE " +
                    "kode_surat_keluar='" + txtKodeSuratKeluar.Text + "' AND kode_disposisi='" + cbDisposisi.Text + "'");
                cmd.Connection = koneksii;
                string cek = (string)cmd.ExecuteScalar();
                koneksii.Close();

                if (!string.IsNullOrEmpty(cek))
                {
                    MessageBox.Show("Data sudah ada.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Entitas.Surat_Keluar p = new Entitas.Surat_Keluar(txtKodeSuratKeluar.Text, cbDisposisi.Text);
                Manajer.Manajer_Surat_Keluar mp = new Manajer.Manajer_Surat_Keluar();
                mp.Tambah(p);
                tampilDataSuratMasuk();

                MessageBox.Show("Data berhasil disimpan.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            SqlConnection koneksii = Koneksi.Conn;
            koneksii.Open();
            SqlCommand cmd = new SqlCommand("SELECT kode_disposisi FROM tbl_surat_keluar WHERE " +
                "kode_surat_keluar='" + txtKodeSuratKeluar.Text + "' AND kode_disposisi='" + cbDisposisi.Text + "'");
            cmd.Connection = koneksii;
            string cek = (string)cmd.ExecuteScalar();
            koneksii.Close();

            Entitas.Surat_Keluar p = new Entitas.Surat_Keluar(txtKodeSuratKeluar.Text, cbDisposisi.Text);
            Manajer.Manajer_Surat_Keluar mp = new Manajer.Manajer_Surat_Keluar();
            mp.Edit(p);
            tampilDataSuratMasuk();
            
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Yakin Mau Hapus?", "Peringatan",
                   MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    string kodesuratkeluar = txtKodeSuratKeluar.Text;
                    Manajer.Manajer_Surat_Keluar mm = new Manajer.Manajer_Surat_Keluar();
                    int i = mm.Hapus(kodesuratkeluar);

                    if (i > 0)
                    {
                        MessageBox.Show("Data berhasil dihapus.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Gagal menghapus data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                tampilDataSuratMasuk();
                Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void dgSuratKeluar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtKodeSuratKeluar.Text = dgSuratKeluar.CurrentRow.Cells["kode_surat_keluar"].Value.ToString();
            cbDisposisi.Text = dgSuratKeluar.CurrentRow.Cells["kode_disposisi"].Value.ToString();
        }

        private void btnCetak1_Click(object sender, EventArgs e)
        {
            LaporanSuratKeluar1 p = new LaporanSuratKeluar1();
            p.Show();
        }

    }
}
