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
    public partial class UC_Status : UserControl
    {
        public UC_Status()
        {
            InitializeComponent();
        }

        public void TampilStatus()
        {
            string query = "SELECT * FROM tbl_status";
            Manajer.Manajer_Status mm = new Manajer.Manajer_Status();
            mm.TampilData(query, "tbl_status", dgStatus);
        }

        private void UC_Status_Load(object sender, EventArgs e)
        {
            TampilStatus();
        }

        public void Clear()
        {
            txtKodeStatus.Clear();
            txtStatus.Clear();
            txtStatus.Focus();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private string kode_status
        {
            get
            {
                SqlConnection conn = Koneksi.Conn;
                conn.Open();
                string nomor = "A0001";
                SqlCommand cmd = new SqlCommand("SELECT MAX (RIGHT(kode_status,4)) FROM tbl_status", conn);
                SqlDataReader sdr = cmd.ExecuteReader();
                sdr.Read();
                if (sdr[0].ToString() != "")
                {
                    nomor = "A" + (int.Parse(sdr[0].ToString()) + 1).ToString("000");
                    sdr.Close();
                }
                return nomor;
            }
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            txtKodeStatus.Text = kode_status;
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                Entitas.Status mk = new Entitas.Status(txtKodeStatus.Text, txtStatus.Text);
                Manajer.Manajer_Status mm = new Manajer.Manajer_Status();
                int i = mm.Tambah(mk);

                if (i > 0)
                {
                    MessageBox.Show("Data berhasil disimpan.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Gagal menyimpan data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                // Refresh the data in the DataGridView
                TampilStatus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            try
            {
                Entitas.Status mk = new Entitas.Status(txtKodeStatus.Text, txtStatus.Text);
                Manajer.Manajer_Status mm = new Manajer.Manajer_Status();
                int i = mm.Edit(mk);

                if (i > 0)
                {
                    MessageBox.Show("Data berhasil diubah.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Gagal mengubah data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                // Refresh the data in the DataGridView
                TampilStatus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Hapus Data?", "Peringatan", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                try
                {
                    string hapus = txtKodeStatus.Text;
                    Manajer.Manajer_Status mm = new Manajer.Manajer_Status();
                    int i = mm.Hapus(hapus);

                    if (i > 0)
                    {
                        MessageBox.Show("Data berhasil dihapus.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Gagal menghapus data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    // Refresh the data in the DataGridView
                    TampilStatus();
                    Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void dgStatus_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtKodeStatus.Text = dgStatus.CurrentRow.Cells["kode_status"].Value.ToString();
            txtStatus.Text = dgStatus.CurrentRow.Cells["nama_status"].Value.ToString();
        }


    }
}
