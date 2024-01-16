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
    public partial class penggunaa : Form
    {
        private DataTable penggunaDataTable;
        public penggunaa()
        {
            InitializeComponent();
        }

        private void TampilPengguna(object sender, EventArgs e)
        {
           
            string query = "SELECT * FROM tbl_pengguna";
            SqlConnection conn = Koneksi.Conn;
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Load(reader);

            // Assign the DataTable to the field
            penggunaDataTable = dt;

            // Set the data source for the DataGridView
            dgPengguna.DataSource = penggunaDataTable;

            reader.Close();
            conn.Close();
        }

        private void Pengguna_Load(object sender, EventArgs e)
        {
            TampilPengguna();
        }
        public void Clear()
        {
            txtKodePengguna.Clear();
            txtUsername.Clear();
            txtKataSandi.Clear();
            txtJabatan.Clear();
            txtUsername.Focus();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            Entitas.Pengguna mk = new Entitas.Pengguna(txtKodePengguna.Text, txtUsername.Text, txtKataSandi.Text, txtJabatan.Text);
            Manajer.Manajer_Pengguna mm = new Manajer.Manajer_Pengguna();
            int hasilSimpan = mm.Tambah(mk);

            if (hasilSimpan > 0)
            {
                MessageBox.Show("Data berhasil disimpan.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Gagal menyimpan data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Refresh the data in the DataGridView
            TampilPengguna();
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            Entitas.Pengguna mk = new Entitas.Pengguna(txtKodePengguna.Text, txtUsername.Text, txtKataSandi.Text, txtJabatan.Text);
            Manajer.Manajer_Pengguna mm = new Manajer.Manajer_Pengguna();
            int hasilUbah = mm.Edit(mk);

            if (hasilUbah > 0)
            {
                MessageBox.Show("Data berhasil diubah.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Gagal mengubah data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Refresh the data in the DataGridView
            TampilPengguna();
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Yakin Mau Hapus?", "Peringatan", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                string hapus = txtKodePengguna.Text;
                Manajer.Manajer_Pengguna mm = new Manajer.Manajer_Pengguna();
                int hasilHapus = mm.Hapus(hapus);

                if (hasilHapus > 0)
                {
                    MessageBox.Show("Data berhasil dihapus.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Gagal menghapus data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            // Refresh the data in the DataGridView
            TampilPengguna();
            Clear();
        }

        private void dgPengguna_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgPengguna.Rows[e.RowIndex];
                txtKodePengguna.Text = row.Cells["kode_pengguna"].Value.ToString();
                txtUsername.Text = row.Cells["username"].Value.ToString();
                txtKataSandi.Text = row.Cells["kata_sandi"].Value.ToString();
                txtJabatan.Text = row.Cells["jabatan"].Value.ToString();
            }
        }
    }
    }

