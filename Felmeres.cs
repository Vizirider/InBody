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
    public partial class Felmeres : Form
    {
        public Felmeres()
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
            textBox2.Clear();
        }
        private void Felmeres_Load(object sender, EventArgs e)
        {
            string startupPath = System.IO.Directory.GetCurrentDirectory();
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;" +
               @"AttachDbFilename=" + startupPath + "\\torzsadat.mdf;" +
               @"Integrated Security=True;");
            DataSet ds = new DataSet();
            SqlDataAdapter dataAdapter5 = new SqlDataAdapter("SELECT * FROM Felmeres", conn);
            dataAdapter5.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.AutoResizeColumns();
            dataGridView1.AutoResizeColumnHeadersHeight();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            string startupPath = System.IO.Directory.GetCurrentDirectory();
            using (SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;" +
               @"AttachDbFilename=" + startupPath + "\\torzsadat.mdf;" +
               @"Integrated Security=True;"))
            {
                SqlCommand command =
                new SqlCommand("select * FROM Felmeres WHERE Nev=('" + textBox1.Text + "')", connection);
                connection.Open();

                SqlDataReader read = command.ExecuteReader();

                while (read.Read())
                {

                    dateTimePicker1.Text = Convert.ToDateTime(read["Szuletesi_ido"]).ToString();
                    textBox3.Text = (read["Mely_guggolas"].ToString());
                    textBox4.Text = (read["Akadaly_atlepes"].ToString());
                    textBox5.Text = (read["Kitores_egyvonalban"].ToString());
                    textBox6.Text = (read["Vall_mobilitas"].ToString());
                    textBox7.Text = (read["Aktiv_nyujtott_labemeles"].ToString());
                    textBox8.Text = (read["Torzs_stabilitas_fekvotamasz"].ToString());
                    textBox2.Text = (read["Rotacios_stabilitas"].ToString());
                }
                read.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.Parse(textBox3.Text) < 0 || int.Parse(textBox4.Text) < 0 || int.Parse(textBox5.Text) < 0 || int.Parse(textBox6.Text) < 0 ||
                int.Parse(textBox7.Text) < 0 || int.Parse(textBox8.Text) < 0 || int.Parse(textBox2.Text) < 0 || int.Parse(textBox3.Text) > 3 ||
                int.Parse(textBox4.Text) > 3 || int.Parse(textBox5.Text) > 3 || int.Parse(textBox6.Text) > 3 || int.Parse(textBox7.Text) > 3 ||
                int.Parse(textBox8.Text) > 3 || int.Parse(textBox3.Text) > 3)
            {
                MessageBox.Show("Csak 0 és 3 közötti érték lehet", "Üzenet");
            }
            else
            {
                string startupPath = System.IO.Directory.GetCurrentDirectory();
                SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;" +
                   @"AttachDbFilename=" + startupPath + "\\torzsadat.mdf;" +
                   @"Integrated Security=True;");

                conn.Open();
                SqlCommand cmd = new SqlCommand(@"Insert into torzsadat.Felmeres (Nev, Szuletesi_ido, Mely_guggolas, Akadaly_atlepes, Kitores_egyvonalban, Vall_mobilitas, Aktiv_nyujtott_labemeles, Torzs_stabilitas_fekvotamasz, Rotacios_stabilitas)  VALUES 
			(@Nev, @Szuletesi_ido, @Mely_guggolas, @Akadaly_atlepes, @Kitores_egyvonalban, @Vall_mobilitas, @Aktiv_nyujtott_labemeles, @Torzs_stabilitas_fekvotamasz, @Rotacios_stabilitas)", conn);
                cmd.Parameters.Add(new SqlParameter("@Nev", textBox1.Text));
                cmd.Parameters.Add(new SqlParameter("@Szuletesi_ido", dateTimePicker1.Value.Date));
                cmd.Parameters.Add(new SqlParameter("@Mely_guggolas", textBox3.Text));
                cmd.Parameters.Add(new SqlParameter("@Akadaly_atlepes", textBox4.Text));
                cmd.Parameters.Add(new SqlParameter("@Kitores_egyvonalban", textBox5.Text));
                cmd.Parameters.Add(new SqlParameter("@Vall_mobilitas", textBox6.Text));
                cmd.Parameters.Add(new SqlParameter("@Aktiv_nyujtott_labemeles", textBox7.Text));
                cmd.Parameters.Add(new SqlParameter("@Torzs_stabilitas_fekvotamasz", textBox8.Text));
                cmd.Parameters.Add(new SqlParameter("@Rotacios_stabilitas", textBox2.Text));

                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Sikeresen felvitted az új felmérést", "Üzenet");
                Felmeres_Load(null, null);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (int.Parse(textBox3.Text) < 0 || int.Parse(textBox4.Text) < 0 || int.Parse(textBox5.Text) < 0 || int.Parse(textBox6.Text) < 0 ||
            int.Parse(textBox7.Text) < 0 || int.Parse(textBox8.Text) < 0 || int.Parse(textBox2.Text) < 0 || int.Parse(textBox3.Text) > 3 ||
            int.Parse(textBox4.Text) > 3 || int.Parse(textBox5.Text) > 3 || int.Parse(textBox6.Text) > 3 || int.Parse(textBox7.Text) > 3 ||
            int.Parse(textBox8.Text) > 3 || int.Parse(textBox3.Text) > 3)
            {
                MessageBox.Show("Csak 0 és 3 közötti érték lehet", "Üzenet");
            }
            else
            {
                string startupPath = System.IO.Directory.GetCurrentDirectory();
                SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;" +
                   @"AttachDbFilename=" + startupPath + "\\torzsadat.mdf;" +
                   @"Integrated Security=True;");

                conn.Open();
                SqlCommand cmd = new SqlCommand(@"Update Felmeres SET Nev = @Nev, Szuletesi_ido = @Szuletesi_ido, Mely_guggolas = @Mely_guggolas, Akadaly_atlepes = @Akadaly_atlepes, Kitores_egyvonalban = @Kitores_egyvonalban, Vall_mobilitas = @Vall_mobilitas, Aktiv_nyujtott_labemeles = @Vall_mobilitas, Torzs_stabilitas_fekvotamasz = @Torzs_stabilitas_fekvotamasz, Rotacios_stabilitas = @Rotacios_stabilitas 
			    WHERE Nev = ('" + textBox1.Text + "')", conn);
                cmd.Parameters.Add(new SqlParameter("@Nev", textBox1.Text));
                cmd.Parameters.Add(new SqlParameter("@Szuletesi_ido", dateTimePicker1.Value.Date));
                cmd.Parameters.Add(new SqlParameter("@Mely_guggolas", textBox3.Text));
                cmd.Parameters.Add(new SqlParameter("@Akadaly_atlepes", textBox4.Text));
                cmd.Parameters.Add(new SqlParameter("@Kitores_egyvonalban", textBox5.Text));
                cmd.Parameters.Add(new SqlParameter("@Vall_mobilitas", textBox6.Text));
                cmd.Parameters.Add(new SqlParameter("@Aktiv_nyujtott_labemeles", textBox7.Text));
                cmd.Parameters.Add(new SqlParameter("@Torzs_stabilitas_fekvotamasz", textBox8.Text));
                cmd.Parameters.Add(new SqlParameter("@Rotacios_stabilitas", textBox2.Text));

                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Sikeresen módosítottad a felmérést", "Üzenet");
                Felmeres_Load(null, null);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string startupPath = System.IO.Directory.GetCurrentDirectory();
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;" +
               @"AttachDbFilename=" + startupPath + "\\torzsadat.mdf;" +
               @"Integrated Security=True;");

            conn.Open();

            SqlCommand cmd = new SqlCommand(@"DELETE FROM Felmeres WHERE Nev = ('" + textBox1.Text + "')", conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Sikeresen törölted a felmérést", "Üzenet");
            Felmeres_Load(null, null);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string startupPath = System.IO.Directory.GetCurrentDirectory();
            using (SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;" +
               @"AttachDbFilename=" + startupPath + "\\torzsadat.mdf;" +
               @"Integrated Security=True;"))
            {
                SqlCommand command =
                    new SqlCommand("select nev from Felmeres WHERE Nev = ('" + this.textBox1.Text + "')", connection);
                connection.Open();

                SqlDataReader read = command.ExecuteReader();

                while (read.Read())
                {
                    Felmeresdiagram dia = new Felmeresdiagram(this.textBox1.Text);
                    dia.Show();
                }


            }
        }
    }
}
