using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProjeck_ApkArsipSurat
{
    public partial class Disposisi : Form
    {
        public Disposisi()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection (@"Data Source = . ; Initial Catalog=db21sa1157; Integrated Security=True");
        private void showdata()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Disposisi";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds, "Disposisi");
            dgvDisposisi.DataSource = ds;
            dgvDisposisi.DataMember = "Disposisi";
            dgvDisposisi.ReadOnly = true;
        }
        private void resetdata()
        {
            txtId.Text = "";
            txtNo.Text = "";
            txtIdSM.Text = "";
            txtTujuan.Text = "";
            txtIsi.Text = "";
            txtCatatan.Text = "";
            txtKepada.Text = "";
            txtPengirim.Text = "";
            txtStatus.Text = "";
        }
        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void Disposisi_Load(object sender, EventArgs e)
        {
            showdata();
            resetdata();
        }

        private void btnBaru_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "DISPOSISI";

            SqlParameter IdDisposisi = new SqlParameter("@id", SqlDbType.VarChar);
            SqlParameter NoSurat = new SqlParameter("@no", SqlDbType.VarChar);
            SqlParameter IdSM = new SqlParameter("@idSM", SqlDbType.VarChar);
            SqlParameter Tujuan = new SqlParameter("@Tujuan", SqlDbType.VarChar);
            SqlParameter Isi = new SqlParameter("@Isi", SqlDbType.VarChar);
            SqlParameter Catatan = new SqlParameter("@Catatan", SqlDbType.VarChar);
            SqlParameter Kepada = new SqlParameter("@Kepada", SqlDbType.VarChar);
            SqlParameter Pengirim = new SqlParameter("@Pengirim", SqlDbType.VarChar);
            SqlParameter StatusSurat = new SqlParameter("@Status", SqlDbType.VarChar);

            IdDisposisi.Value = txtId.Text;
            NoSurat.Value = txtNo.Text;
            IdSM.Value = txtIdSM.Text;
            Tujuan.Value = txtTujuan.Text;
            Isi.Value = txtIsi.Text;
            Catatan.Value = txtCatatan.Text;
            Kepada.Value = txtKepada.Text;
            Pengirim.Value = txtPengirim.Text;
            StatusSurat.Value = txtStatus.Text;

            cmd.Parameters.Add(IdDisposisi);
            cmd.Parameters.Add(NoSurat);
            cmd.Parameters.Add(IdSM);
            cmd.Parameters.Add(Tujuan);
            cmd.Parameters.Add(Isi);
            cmd.Parameters.Add(Catatan);
            cmd.Parameters.Add(Kepada);
            cmd.Parameters.Add(Pengirim);
            cmd.Parameters.Add(StatusSurat);

            cmd.ExecuteNonQuery();
            con.Close();
            showdata();
            resetdata();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "DISPOSISI";

            SqlParameter IdDisposisi = new SqlParameter("@id", SqlDbType.VarChar);
            SqlParameter NoSurat = new SqlParameter("@no", SqlDbType.VarChar);
            SqlParameter IdSM = new SqlParameter("@idSM", SqlDbType.VarChar);
            SqlParameter Tujuan = new SqlParameter("@Tujuan", SqlDbType.VarChar);
            SqlParameter Isi = new SqlParameter("@Isi", SqlDbType.VarChar);
            SqlParameter Catatan = new SqlParameter("@Catatan", SqlDbType.VarChar);
            SqlParameter Kepada = new SqlParameter("@Kepada", SqlDbType.VarChar);
            SqlParameter Pengirim = new SqlParameter("@Pengirim", SqlDbType.VarChar);
            SqlParameter StatusSurat = new SqlParameter("@Status", SqlDbType.VarChar);

            IdDisposisi.Value = txtId.Text;
            NoSurat.Value = txtNo.Text;
            IdSM.Value = txtIdSM.Text;
            Tujuan.Value = txtTujuan.Text;
            Isi.Value = txtIsi.Text;
            Catatan.Value = txtCatatan.Text;
            Kepada.Value = txtKepada.Text;
            Pengirim.Value = txtPengirim.Text;
            StatusSurat.Value = txtStatus.Text;

            cmd.Parameters.Add(IdDisposisi);
            cmd.Parameters.Add(NoSurat);
            cmd.Parameters.Add(IdSM);
            cmd.Parameters.Add(Tujuan);
            cmd.Parameters.Add(Isi);
            cmd.Parameters.Add(Catatan);
            cmd.Parameters.Add(Kepada);
            cmd.Parameters.Add(Pengirim);
            cmd.Parameters.Add(StatusSurat);

            cmd.ExecuteNonQuery();
            con.Close();
            showdata();
            resetdata();
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "DISPOSISI";

            SqlParameter IdDisposisi = new SqlParameter("@id", SqlDbType.VarChar);
            SqlParameter NoSurat = new SqlParameter("@no", SqlDbType.VarChar);
            SqlParameter IdSM = new SqlParameter("@idSM", SqlDbType.VarChar);
            SqlParameter Tujuan = new SqlParameter("@Tujuan", SqlDbType.VarChar);
            SqlParameter Isi = new SqlParameter("@Isi", SqlDbType.VarChar);
            SqlParameter Catatan = new SqlParameter("@Catatan", SqlDbType.VarChar);
            SqlParameter Kepada = new SqlParameter("@Kepada", SqlDbType.VarChar);
            SqlParameter Pengirim = new SqlParameter("@Pengirim", SqlDbType.VarChar);
            SqlParameter StatusSurat = new SqlParameter("@Status", SqlDbType.VarChar);

            IdDisposisi.Value = txtId.Text;
            NoSurat.Value = txtNo.Text;
            IdSM.Value = txtIdSM.Text;
            Tujuan.Value = txtTujuan.Text;
            Isi.Value = txtIsi.Text;
            Catatan.Value = txtCatatan.Text;
            Kepada.Value = txtKepada.Text;
            Pengirim.Value = txtPengirim.Text;
            StatusSurat.Value = txtStatus.Text;

            cmd.Parameters.Add(IdDisposisi);
            cmd.Parameters.Add(NoSurat);
            cmd.Parameters.Add(IdSM);
            cmd.Parameters.Add(Tujuan);
            cmd.Parameters.Add(Isi);
            cmd.Parameters.Add(Catatan);
            cmd.Parameters.Add(Kepada);
            cmd.Parameters.Add(Pengirim);
            cmd.Parameters.Add(StatusSurat);

            cmd.ExecuteNonQuery();
            con.Close();
            showdata();
            resetdata();
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "")
            {
                MessageBox.Show("Isi id Disposisi yang akan dihapus");
                goto berhenti;

            }
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update  SuratMasuk set noSurat = '" + txtNo.Text + "',IdSM = " + txtIdSM.Text + "', tujuan surat masuk = " + txtTujuan.Text + "', isi surat masuk = " + txtIsi.Text + "', catatan surat masuk = " + txtCatatan.Text + "', kepada = " + txtKepada.Text + "', pengirim surat = " + txtPengirim.Text + "', Status surat= " + txtStatus.Text + " where idDisposisi = '" + txtId.Text + "'";
            cmd.ExecuteNonQuery();
            con.Close();
            showdata();
            resetdata();

        berhenti:
            ;
        }

        private void btnUbah_Click(object sender, EventArgs e)
        { 
            if (txtId.Text == "" | txtNo.Text == "" | txtIdSM.Text == "" | txtTujuan.Text == "" | txtIsi.Text == "" | txtCatatan.Text ==""
                | txtKepada.Text == "" | txtPengirim.Text == "" | txtStatus.Text == "")
            {
                MessageBox.Show("Semua data harus diisi", "Peringatan");
                goto berhenti;
            }
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update  SuratMasuk set noSurat = '" + txtNo.Text + "',IdSM = " + txtIdSM.Text + "', tujuan surat masuk = " + txtTujuan.Text + "', isi surat masuk = " + txtIsi.Text + "', catatan surat masuk = " + txtCatatan.Text + "', kepada = " + txtKepada.Text + "', pengirim surat = " + txtPengirim.Text + "', Status surat= " + txtStatus.Text + " where idDisposisi = '" + txtId.Text + "'";
            cmd.ExecuteNonQuery();
            con.Close();
            showdata();
            resetdata();

        berhenti:
            ;
        }

        private void btnCetak_Click(object sender, EventArgs e)
        {

        }
    }
}
