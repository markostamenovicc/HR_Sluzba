using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HRdatabase
{
    public partial class ZaposleniSpisak : Form
    {
        public ZaposleniSpisak()
        {
            InitializeComponent();
        }

        private void ZaposleniSpisak_Load(object sender, EventArgs e)
        {
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT id, ime, prezime, email FROM Osoba", Connection.Connect());
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
            dataGridView1.Columns["id"].ReadOnly = true;
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
