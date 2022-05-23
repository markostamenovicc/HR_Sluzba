using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRdatabase
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btn_zaposleniForm_Click(object sender, EventArgs e)
        {
            ZaposleniSpisak zaposleniSpisakForm = new ZaposleniSpisak();
            zaposleniSpisakForm.Show();
        }

        private void btn_zaposleniPodaciForm_Click(object sender, EventArgs e)
        {
            ZaposleniPodaci zaposleniPodaciForm = new ZaposleniPodaci();
            zaposleniPodaciForm.Show();
        }
    }
}
