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
    public partial class input_sk : Form
    {
        public input_sk()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection
        (@"Data Source = . \SQLEXPRESS; Initial Catalog=db21sa1157; Integrated
         Security=True");
        private void showdata()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from input surat keluar";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds, "input surat keluar");
            dgvdatasuratkeluar.DataSource = ds;
            dgvdatasuratkeluar.DataMember = "menu";
            dgvdatasuratkeluar.ReadOnly = true;
        }
        private void resetdata()
        {
            txtId.Text = "";
            txtKodeSurat.Text = "";
            txtNoSurat.Text = "";
            txtNoSurat.Text = "";
            numerictanggal.Text = "";
            txtPerihal.Text = "";
            txtTujuan.Text = "";
            txtIsi.Text = "";
        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)//simpan
        {
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "ADDSURAT";

            SqlParameter IdSurat = new SqlParameter("@id", SqlDbType.VarChar);


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void input_sk_Load(object sender, EventArgs e)
        {
            showdata();
            resetdata();
        }
    }
}
