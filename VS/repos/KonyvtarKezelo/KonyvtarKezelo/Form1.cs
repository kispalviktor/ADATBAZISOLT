using System;
using System.Collections.Generic;
using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace KonyvtarApp
{
    public partial class Form1 : Form
    {
        // Adatbázis kapcsolat
        string connectionString =
            "server=localhost;database=konyvtar;uid=root;pwd=mysql;";

        public Form1()
        {
            InitializeComponent();
        }

        // Form betöltésekor
        private void Form1_Load(object sender, EventArgs e)
        {
            KonyvekBetoltese();
        }

        // Könyvek betöltése DataGridView-ba
        private void KonyvekBetoltese()
        {
            using (MySqlConnection conn =
                new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string query = "SELECT * FROM konyvek";

                    MySqlDataAdapter adapter =
                        new MySqlDataAdapter(query, conn);

                    DataTable table = new DataTable();

                    adapter.Fill(table);

                    dgvKonyvek.DataSource = table;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        "Hiba történt: " + ex.Message);
                }
            }
        }

        // Új könyv hozzáadása
        private void btnHozzaad_Click(object sender, EventArgs e)
        {
            // Ellenőrzés
            if (txtCim.Text == "" || txtSzerzo.Text == "")
            {
                MessageBox.Show(
                    "Minden mezőt ki kell tölteni!");
                return;
            }

            using (MySqlConnection conn =
                new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string query =
                        "INSERT INTO konyvek(cim, szerzo) " +
                        "VALUES(@cim, @szerzo)";

                    MySqlCommand cmd =
                        new MySqlCommand(query, conn);

                    cmd.Parameters.AddWithValue(
                        "@cim", txtCim.Text);

                    cmd.Parameters.AddWithValue(
                        "@szerzo", txtSzerzo.Text);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show(
                        "Könyv sikeresen hozzáadva!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        "Hiba történt: " + ex.Message);
                }
            }

            // Lista frissítése
            KonyvekBetoltese();

            // Mezők ürítése
            txtCim.Clear();
            txtSzerzo.Clear();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
