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

namespace InBody
{
    public partial class Szelsoertek : Form
    {
        public Szelsoertek()
        {
            InitializeComponent();
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy.MM.dd";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
        }

        private void Szelsoertek_Load(object sender, EventArgs e)
        {
            string startupPath = System.IO.Directory.GetCurrentDirectory();
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;" +
               @"AttachDbFilename=" + startupPath + "\\torzsadat.mdf;" +
               @"Integrated Security=True;");
            DataSet ds = new DataSet();
            SqlDataAdapter dataAdapter5 = new SqlDataAdapter("SELECT * FROM Szelsoertek", conn);
            dataAdapter5.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.AutoResizeColumns();
            dataGridView1.AutoResizeColumnHeadersHeight();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string startupPath = System.IO.Directory.GetCurrentDirectory();
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;" +
               @"AttachDbFilename=" + startupPath + "\\torzsadat.mdf;" +
               @"Integrated Security=True;");

            conn.Open();
            SqlCommand cmd = new SqlCommand(@"Insert into Szelsoertek (Nev, Szuletesi_ido, Fekvotamasz_karhajlitas_nyujtas, Huzodzkodas, Alkartamasz_tartas, Helybol_tavolugras, Sulypont_emelkedes, Talajkontakt_ido)  VALUES 
			(@Nev, @Szuletesi_ido, @Fekvotamasz_karhajlitas_nyujtas, @Huzodzkodas, @Alkartamasz_tartas, @Helybol_tavolugras, @Sulypont_emelkedes, @Talajkontakt_ido)", conn);
            cmd.Parameters.Add(new SqlParameter("@Nev", textBox1.Text));
            cmd.Parameters.Add(new SqlParameter("@Szuletesi_ido", dateTimePicker1.Value.Date));
            cmd.Parameters.Add(new SqlParameter("@Fekvotamasz_karhajlitas_nyujtas", textBox3.Text));
            cmd.Parameters.Add(new SqlParameter("@Huzodzkodas", textBox4.Text));
            cmd.Parameters.Add(new SqlParameter("@Alkartamasz_tartas", textBox5.Text));
            cmd.Parameters.Add(new SqlParameter("@Helybol_tavolugras", textBox6.Text));
            cmd.Parameters.Add(new SqlParameter("@Sulypont_emelkedes", textBox7.Text));
            cmd.Parameters.Add(new SqlParameter("@Talajkontakt_ido", textBox8.Text));

            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Sikeresen felvitted az új szélsőértéket", "Üzenet");
            Szelsoertek_Load(null, null);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string startupPath = System.IO.Directory.GetCurrentDirectory();
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;" +
               @"AttachDbFilename=" + startupPath + "\\torzsadat.mdf;" +
               @"Integrated Security=True;");

            conn.Open();
            SqlCommand cmd = new SqlCommand(@"Update Szelsoertek SET Nev = @Nev, Szuletesi_ido = @Szuletesi_ido, Fekvotamasz_karhajlitas_nyujtas = @Fekvotamasz_karhajlitas_nyujtas, Huzodzkodas = @Huzodzkodas, Alkartamasz_tartas = @Alkartamasz_tartas, Helybol_tavolugras = @Helybol_tavolugras, Sulypont_emelkedes = @Sulypont_emelkedes, Talajkontakt_ido = @Talajkontakt_ido
			WHERE Nev = ('" + textBox1.Text + "')", conn);
            cmd.Parameters.Add(new SqlParameter("@Nev", textBox1.Text));
            cmd.Parameters.Add(new SqlParameter("@Szuletesi_ido", dateTimePicker1.Value.Date));
            cmd.Parameters.Add(new SqlParameter("@Fekvotamasz_karhajlitas_nyujtas", textBox3.Text));
            cmd.Parameters.Add(new SqlParameter("@Huzodzkodas", textBox4.Text));
            cmd.Parameters.Add(new SqlParameter("@Alkartamasz_tartas", textBox5.Text));
            cmd.Parameters.Add(new SqlParameter("@Helybol_tavolugras", textBox6.Text));
            cmd.Parameters.Add(new SqlParameter("@Sulypont_emelkedes", textBox7.Text));
            cmd.Parameters.Add(new SqlParameter("@Talajkontakt_ido", textBox8.Text));

            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Sikeresen módosítottad a szélsőértéket", "Üzenet");
            Szelsoertek_Load(null, null);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string startupPath = System.IO.Directory.GetCurrentDirectory();
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;" +
               @"AttachDbFilename=" + startupPath + "\\torzsadat.mdf;" +
               @"Integrated Security=True;");

            conn.Open();

            SqlCommand cmd = new SqlCommand(@"DELETE FROM Szelsoertek WHERE Nev = ('" + textBox1.Text + "')", conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Sikeresen törölted a szélsőértéket", "Üzenet");
            Szelsoertek_Load(null, null);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string startupPath = System.IO.Directory.GetCurrentDirectory();
            using (SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;" +
               @"AttachDbFilename=" + startupPath + "\\torzsadat.mdf;" +
               @"Integrated Security=True;"))
            {
                connection.Open();
                SqlCommand cmd =
                new SqlCommand("select * FROM Szelsoertek WHERE Nev=@Nev", connection);
                cmd.Parameters.AddWithValue("@Nev", textBox1.Text);
                
                cmd.ExecuteNonQuery();
                SqlDataReader read = cmd.ExecuteReader();

                while (read.Read())
                {

                    dateTimePicker1.Text = Convert.ToDateTime(read["Szuletesi_ido"]).ToString();
                    textBox3.Text = (read["Fekvotamasz_karhajlitas_nyujtas"].ToString());
                    textBox4.Text = (read["Huzodzkodas"].ToString());
                    textBox5.Text = (read["Alkartamasz_tartas"].ToString());
                    textBox6.Text = (read["Helybol_tavolugras"].ToString());
                    textBox7.Text = (read["Sulypont_emelkedes"].ToString());
                    textBox8.Text = (read["Talajkontakt_ido"].ToString());
                }
                read.Close();
            }
        }
    }
}
