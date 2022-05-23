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
    public partial class ZaposleniPodaci : Form
    {
        int rb = 0;
        DataTable table;
        
        public ZaposleniPodaci()
        {
            InitializeComponent();
        }

        private void ZaposleniPodaci_Load(object sender, EventArgs e)
        {
            cmbPozicijaPopulate();
            cmbSektorPopulate();
            load_Data();
            text_Load();
        }

        private void load_Data()
        {
            SqlConnection connetion = Connection.Connect();
            StringBuilder command = new StringBuilder("SELECT id, ime, prezime, email, pozicija_id, sektor_id FROM Osoba ");
            SqlDataAdapter adapter = new SqlDataAdapter(command.ToString(), connetion);
            table = new DataTable();
            adapter.Fill(table);
        }

        private void cmbPozicijaPopulate()
        {
            SqlConnection connection = Connection.Connect();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Pozicije", connection);
            DataTable dt_pozicije = new DataTable();
            adapter.Fill(dt_pozicije);
            cmb_pozicija.DataSource = dt_pozicije;
            cmb_pozicija.ValueMember = "id";
            cmb_pozicija.DisplayMember = "naziv";
            cmb_pozicija.SelectedValue = -1;
        }

        private void cmbSektorPopulate()
        {
            SqlConnection connection = Connection.Connect();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Sektor", connection);
            DataTable dt_sektor = new DataTable();
            adapter.Fill(dt_sektor);
            cmb_sektor.DataSource = dt_sektor;
            cmb_sektor.ValueMember = "id";
            cmb_sektor.DisplayMember = "naziv";
            cmb_sektor.SelectedValue = -1;
        }

        private void text_Load()
        {
            if (table.Rows.Count == 0)
            {
                txt_id.Text = "";
                txt_ime.Text = "";
                txt_prezime.Text = "";
                txt_email.Text = "";
                cmb_pozicija.SelectedValue = -1;
                cmb_sektor.SelectedValue = -1;
                btn_delete.Enabled = false;
            }
            else
            {
                txt_id.Text = table.Rows[rb]["id"].ToString();
                txt_ime.Text = table.Rows[rb]["ime"].ToString();
                txt_prezime.Text = table.Rows[rb]["prezime"].ToString();
                txt_email.Text = table.Rows[rb]["email"].ToString();
                cmb_pozicija.SelectedValue = table.Rows[rb]["pozicija_id"];
                cmb_sektor.SelectedValue = table.Rows[rb]["sektor_id"];
                btn_delete.Enabled = true;
            }

            if (rb == 0)
            {
                btn_first.Enabled = false;
                btn_prev.Enabled = false;
            }
            else
            {
                btn_first.Enabled = true;
                btn_prev.Enabled = true;
            }

            if (rb == table.Rows.Count - 1)
            {
                btn_last.Enabled = false;
                btn_next.Enabled = false;
            }
            else
            {
                btn_last.Enabled = true;
                btn_next.Enabled = true;
            }

        }

        private void btn_first_Click(object sender, EventArgs e)
        {
            rb = 0;
            text_Load();
        }

        private void btn_prev_Click(object sender, EventArgs e)
        {
            rb--;
            text_Load();
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            rb++;
            text_Load();
        }

        private void btn_last_Click(object sender, EventArgs e)
        {
            rb = table.Rows.Count - 1;
            text_Load();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            SqlConnection connection = Connection.Connect();
            StringBuilder command = new StringBuilder("INSERT INTO Osoba (ime, prezime, email, pozicija_id, sektor_id) VALUES('");
            command.Append(txt_ime.Text + "', '");
            command.Append(txt_prezime.Text + "', '");
            command.Append(txt_email.Text + "', ");
            command.Append(cmb_pozicija.SelectedValue.ToString() + ", ");
            command.Append(cmb_sektor.SelectedValue.ToString() + ") ");
            SqlCommand cmd = new SqlCommand(command.ToString(), connection);
            try
            {
                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            catch(Exception error)
            {
                MessageBox.Show(error.Message);
            }
            load_Data();
            rb = table.Rows.Count - 1;
            text_Load();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_change_Click(object sender, EventArgs e)
        {
            StringBuilder naredba = new StringBuilder("UPDATE Osoba SET ");
            naredba.Append(" ime = '" + txt_ime.Text + "', ");
            naredba.Append(" prezime = '" + txt_prezime.Text + "', ");
            naredba.Append(" email = '" + txt_email.Text + "', ");
            naredba.Append(" pozicija_id = " + cmb_pozicija.SelectedValue.ToString() + ", ");
            naredba.Append(" sektor_id = " + cmb_sektor.SelectedValue.ToString() + " ");
            naredba.Append(" WHERE id = " + txt_id.Text);
            SqlConnection connection = Connection.Connect();
            SqlCommand command = new SqlCommand(naredba.ToString(), connection);

            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }

            load_Data();
            text_Load();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            string command = "DELETE FROM Osoba WHERE id = " + txt_id.Text;
            SqlConnection connection = Connection.Connect();
            SqlCommand cmd = new SqlCommand(command, connection);
            try
            {
                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
                
            }
            catch (Exception greska)
            {
                MessageBox.Show(greska.Message);
            }
            load_Data();
            rb = table.Rows.Count - 1;
            text_Load();
        }
    }
}
