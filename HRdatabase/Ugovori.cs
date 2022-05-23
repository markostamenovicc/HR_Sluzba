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

    public partial class Ugovori : Form
    {
        DataTable table;
        int rb = 0;
        public Ugovori()
        {
            InitializeComponent();
        }

        private void Ugovori_Load(object sender, EventArgs e)
        {
            load_Data();
            cmbUgovorPopulate();
            text_Load();
        }

        private void load_Data()
        {
            SqlConnection connetion = Connection.Connect();
            StringBuilder command = new StringBuilder("SELECT Ugovori.id, datum, Osoba.ime + ' ' + Osoba.prezime as ime, ugovor_id FROM Ugovori JOIN Osoba ON Osoba.id = Ugovori.osoba_id ");
            SqlDataAdapter adapter = new SqlDataAdapter(command.ToString(), connetion);
            table = new DataTable();
            adapter.Fill(table);
        }

        private void cmbUgovorPopulate()
        {
            SqlConnection connection = Connection.Connect();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Ugovor", connection);
            DataTable dt_ugovori = new DataTable();
            adapter.Fill(dt_ugovori);
            cmb_ugovor.DataSource = dt_ugovori;
            cmb_ugovor.ValueMember = "id";
            cmb_ugovor.DisplayMember = "tip";
            cmb_ugovor.SelectedValue = -1;
        }


        private void text_Load()
        {
            if (table.Rows.Count == 0)
            {
                txt_osoba.Text = "";
                cmb_ugovor.SelectedValue = -1;
                btn_delete.Enabled = false;
            }
            else
            {
                dateTime_datum.Value = (DateTime)table.Rows[rb]["datum"];
                txt_osoba.Text = table.Rows[rb]["ime"].ToString();
                cmb_ugovor.SelectedValue = table.Rows[rb]["ugovor_id"];
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
            StringBuilder command = new StringBuilder("INSERT INTO Ugovori (datum, osoba_id, ugovor_id) VALUES('");
            command.Append(dateTime_datum.Value.ToString("yyyy/MM/dd") + "', (SELECT id FROM Osoba WHERE (Osoba.ime + ' ' + Osoba.prezime)='" + txt_osoba.Text + "'), ");
            command.Append(cmb_ugovor.SelectedValue.ToString() + ")");
            SqlCommand cmd = new SqlCommand(command.ToString(), connection);
            try
            {
                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
            load_Data();
            rb = table.Rows.Count - 1;
            text_Load();
        }

        private void btn_change_Click(object sender, EventArgs e)
        {
            StringBuilder naredba = new StringBuilder("UPDATE Ugovori SET ");
            naredba.Append(" datum = '" + dateTime_datum.Value.ToString("yyyy/MM/dd") + "', osoba_id = (");
            naredba.Append("SELECT id FROM Osoba WHERE (Osoba.ime + ' ' + Osoba.prezime)='" + txt_osoba.Text + "'), ugovor_id = ");
            naredba.Append(cmb_ugovor.SelectedValue.ToString() + " WHERE id = " + table.Rows[rb]["id"]);

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
            string command = "DELETE FROM Ugovori WHERE id = " + table.Rows[rb]["id"];
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
