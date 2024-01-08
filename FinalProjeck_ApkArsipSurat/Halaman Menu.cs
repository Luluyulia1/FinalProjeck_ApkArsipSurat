using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AplikasiArsipSurat
{
    public partial class Form_Utama : Form
    {
        public Form_Utama()
        {
            InitializeComponent();
        }
        private void addUserControl(UserControl UserControl)
        {
            UserControl.Dock = DockStyle.Fill;
            panelNav.Controls.Clear();
            panelNav.Controls.Add(UserControl);
            UserControl.BringToFront();
        }

        private void Form_Utama_Load(object sender, EventArgs e)
        {
            UC_Disposisi uc = new UC_Disposisi();
            addUserControl(uc);
        }

        private void btnSuratMasuk_Click(object sender, EventArgs e)
        {
            UC_SuratMasuk uc = new UC_SuratMasuk();
            addUserControl(uc);
        }

        private void btnPengguna_Click(object sender, EventArgs e)
        {
            UC_Pengguna uc = new UC_Pengguna();
            addUserControl(uc);
        }

        private void btnSuratKeluar_Click(object sender, EventArgs e)
        {
            UC_SuratKeluar uc = new UC_SuratKeluar();
            addUserControl(uc);
        }

        private void btnJenisSurat_Click(object sender, EventArgs e)
        {
            UC_JenisSurat uc = new UC_JenisSurat();
            addUserControl(uc);
        }

        private void btnStatus_Click(object sender, EventArgs e)
        {
            UC_Status uc = new UC_Status();
            addUserControl(uc);
        }

        private void btnDisposisi_Click(object sender, EventArgs e)
        {
            UC_Disposisi uc = new UC_Disposisi();
            addUserControl(uc);
        }

        private void btnKeluar_Click(object sender, EventArgs e)
        {
            Login p = new Login();
            p.Show();
            Close();
        }

    

     
    }
}
