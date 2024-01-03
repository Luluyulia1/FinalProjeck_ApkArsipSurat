using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace FinalProjeck_ApkArsipSurat
{
    public partial class Halaman_Menu : Form
    {
        public Halaman_Menu()
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

        private void button1_Click(object sender, EventArgs e) 
        {
          
        }

        private void panelNav_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
