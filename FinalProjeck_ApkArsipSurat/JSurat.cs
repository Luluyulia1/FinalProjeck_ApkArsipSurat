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
    public partial class UC_JenisSurat : UserControl
    {
        public UC_JenisSurat()
        {
            InitializeComponent();
        }
        public void TampilJenisSurat()
        {
            string query = "SELECT * FROM tbl_jenis_surat";
            Manajer.Manajer_Jenis_Surat mm = new Manajer.Manajer_Jenis_Surat();
            mm.TampilData(query, "tbl_jenis_Surat", dgJS);
        }

        private void UC_JenisSurat_Load(object sender, EventArgs e)
        {
            TampilJenisSurat();
        }

        public void Clear()
        {
            txtKodeJS.Clear();
            txtJS.Clear();
            txtJS.Focus();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private string kode_jenis_Surat
        {
            get
            {
                SqlConnection conn = Koneksi.Conn;
                conn.Open();
                string nomor = "B0001";
                SqlCommand cmd = new SqlCommand("SELECT MAX (RIGHT(kode_jenis_Surat,4)) FROM tbl_jenis_surat", conn);
                SqlDataReader sdr = cmd.ExecuteReader();
                sdr.Read();
                if (sdr[0].ToString() != "")
                {
                    nomor = "B" + (int.Parse(sdr[0].ToString()) + 1).ToString("000");
                    sdr.Close();
                }
                return nomor;
            }
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            txtKodeJS.Text = kode_jenis_Surat;
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtJS.Text))
            {
                MessageBox.Show("Jenis Surat tidak boleh kosong.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Entitas.Jenis_Surat mk = new Entitas.Jenis_Surat(txtKodeJS.Text, txtJS.Text);
            Manajer.Manajer_Jenis_Surat mm = new Manajer.Manajer_Jenis_Surat();
            int i = mm.Tambah(mk);
            if (i > 0)
            {
                MessageBox.Show("Data berhasil disimpan.");
                Clear();
            }
            else
            {
                MessageBox.Show("Gagal menyimpan data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            TampilJenisSurat();
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtJS.Text))
                {
                    MessageBox.Show("Jenis Surat tidak boleh kosong.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Entitas.Jenis_Surat mk = new Entitas.Jenis_Surat(txtKodeJS.Text, txtJS.Text);
                Manajer.Manajer_Jenis_Surat mm = new Manajer.Manajer_Jenis_Surat();
                int i = mm.Edit(mk);

                if (i > 0)
                {
                    MessageBox.Show("Data berhasil diubah.");
                    Clear();
                }
                else
                {
                    MessageBox.Show("Gagal mengubah data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                TampilJenisSurat();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Hapus Data?", "Peringatan",
               MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                string hapus = txtKodeJS.Text;
                Manajer.Manajer_Jenis_Surat mm = new Manajer.Manajer_Jenis_Surat();
                int i = mm.Hapus(hapus);
                if (i > 0)
                {
                    MessageBox.Show("Data berhasil dihapus.");
                    Clear();
                }
                else
                {
                    MessageBox.Show("Gagal menghapus data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            TampilJenisSurat();
        }

        private void dgJS_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtKodeJS.Text = dgJS.CurrentRow.Cells["kode_jenis_Surat"].Value.ToString();
            txtJS.Text = dgJS.CurrentRow.Cells["jenis_Surat"].Value.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
