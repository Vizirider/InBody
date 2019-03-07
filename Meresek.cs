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
    public partial class Meresek : Form
    {
        public Meresek()
        {
            InitializeComponent();
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy.MM.dd";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string startupPath = System.IO.Directory.GetCurrentDirectory();
            using (SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;" +
               @"AttachDbFilename=" + startupPath + "\\torzsadat.mdf;" +
               @"Integrated Security=True;"))
            {
                SqlCommand command =
                    new SqlCommand("select nev from Meresek WHERE Nev = ('" + this.textBox1.Text + "')", connection);
                connection.Open();

                SqlDataReader read = command.ExecuteReader();

                while (read.Read())
                {
                        Meresdiagram diagram = new Meresdiagram(this.textBox1.Text);
                        diagram.Show();
                }

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string startupPath = System.IO.Directory.GetCurrentDirectory();
            using (SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;" +
               @"AttachDbFilename=" + startupPath + "\\torzsadat.mdf;" +
               @"Integrated Security=True;"))
            {
                SqlCommand command =
                new SqlCommand("select * FROM Meresek WHERE Nev=('" + textBox1.Text + "')", connection);
                connection.Open();

                SqlDataReader read = command.ExecuteReader();

                while (read.Read())
                {

                    dateTimePicker1.Text = Convert.ToDateTime(read["Szuletesi_ido"]).ToString();
                    textBox3.Text = (read["Magassag"].ToString());
                    textBox4.Text = (read["Suly"].ToString());
                    textBox5.Text = (read["BMI"].ToString());
                    textBox6.Text = (read["Testzsir"].ToString());
                    textBox7.Text = (read["Izomtomeg"].ToString());
                    textBox8.Text = (read["Izomminoseg"].ToString());
                    textBox11.Text = (read["Zsigerizsir"].ToString());
                    textBox10.Text = (read["Csonttomeg"].ToString());
                    textBox9.Text = (read["Testviz"].ToString());
                    textBox2.Text = (read["BMR"].ToString());
                }
                read.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox11.Clear();
            textBox10.Clear();
            textBox9.Clear();
            textBox2.Clear();

            string startupPath = System.IO.Directory.GetCurrentDirectory();
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;" +
               @"AttachDbFilename=" + startupPath + "\\torzsadat.mdf;" +
               @"Integrated Security=True;");

            conn.Open();
            SqlCommand cmd = new SqlCommand(@"Insert into torzsadat.Meresek (Nev, Szuletesi_ido, Magassag, Suly, BMI, Testzsir, Izomtomeg, Izomminoseg, Zsigerizsir, Csonttomeg, Testviz, BMR)  VALUES 
			(@Nev, @Szuletesi_ido, @Magassag, @Suly, @BMI, @Testzsir, @Izomtomeg, @Izomminoseg, @Zsigerizsir, @Csonttomeg, @Testviz, @BMR)", conn);
            cmd.Parameters.Add(new SqlParameter("@Nev", textBox1.Text));
            cmd.Parameters.Add(new SqlParameter("@Szuletesi_ido", dateTimePicker1.Value.Date));
            cmd.Parameters.Add(new SqlParameter("@Magassag", textBox3.Text));
            cmd.Parameters.Add(new SqlParameter("@Suly", textBox4.Text));
            cmd.Parameters.Add(new SqlParameter("@BMI", textBox5.Text));
            cmd.Parameters.Add(new SqlParameter("@Testzsir", textBox6.Text));
            cmd.Parameters.Add(new SqlParameter("@Izomtomeg", textBox7.Text));
            cmd.Parameters.Add(new SqlParameter("@Izomminoseg", textBox8.Text));
            cmd.Parameters.Add(new SqlParameter("@Zsigerizsir", textBox11.Text));
            cmd.Parameters.Add(new SqlParameter("@Csonttomeg", textBox10.Text));
            cmd.Parameters.Add(new SqlParameter("@Testviz", textBox9.Text));
            cmd.Parameters.Add(new SqlParameter("@BMR", textBox2.Text));
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Sikeresen felvitted az új mérést", "Üzenet");
            Meresek_Load(null, null);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string startupPath = System.IO.Directory.GetCurrentDirectory();
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;" +
               @"AttachDbFilename=" + startupPath + "\\torzsadat.mdf;" +
               @"Integrated Security=True;");

            conn.Open();
            SqlCommand cmd = new SqlCommand(@"Update Meresek set Nev=@Nev, Szuletesi_ido=@Szuletesi_ido, Magassag=@Magassag, Suly=@Suly, BMI=@BMI, 
            Testzsir = @Testzsir, Izomtomeg = @Izomtomeg, Izomminoseg = @Izomminoseg, Zsigerizsir = @Zsigerizsir, Csonttomeg =  @Csonttomeg, Testviz = @Testviz, BMR = @BMR
			WHERE Nev = ('" + textBox1.Text + "')", conn);
            cmd.Parameters.Add(new SqlParameter("@Nev", textBox1.Text));
            cmd.Parameters.Add(new SqlParameter("@Szuletesi_ido", dateTimePicker1.Value.Date));
            cmd.Parameters.Add(new SqlParameter("@Magassag", textBox3.Text));
            cmd.Parameters.Add(new SqlParameter("@Suly", textBox4.Text));
            cmd.Parameters.Add(new SqlParameter("@BMI", textBox5.Text));
            cmd.Parameters.Add(new SqlParameter("@Testzsir", textBox6.Text));
            cmd.Parameters.Add(new SqlParameter("@Izomtomeg", textBox7.Text));
            cmd.Parameters.Add(new SqlParameter("@Izomminoseg", textBox8.Text));
            cmd.Parameters.Add(new SqlParameter("@Zsigerizsir", textBox11.Text));
            cmd.Parameters.Add(new SqlParameter("@Csonttomeg", textBox10.Text));
            cmd.Parameters.Add(new SqlParameter("@Testviz", textBox9.Text));
            cmd.Parameters.Add(new SqlParameter("@BMR", textBox2.Text));

            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Sikeresen módosítottad a mérést", "Üzenet");
            Meresek_Load(null, null);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string startupPath = System.IO.Directory.GetCurrentDirectory();
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;" +
               @"AttachDbFilename=" + startupPath + "\\torzsadat.mdf;" +
               @"Integrated Security=True;");

            conn.Open();

            SqlCommand cmd = new SqlCommand(@"DELETE FROM Meresek WHERE Nev = ('" + textBox1.Text + "')", conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Sikeresen törölted a mérést", "Üzenet");
            Meresek_Load(null, null);
        }

        private void Meresek_Load(object sender, EventArgs e)
        {
            string startupPath = System.IO.Directory.GetCurrentDirectory();
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;" +
               @"AttachDbFilename=" + startupPath + "\\torzsadat.mdf;" +
               @"Integrated Security=True;");
            DataSet ds = new DataSet();
            SqlDataAdapter dataAdapter5 = new SqlDataAdapter("SELECT * FROM meresek", conn);
            dataAdapter5.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.AutoResizeColumns();
            dataGridView1.AutoResizeColumnHeadersHeight();
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
            textBox11.Clear();
            textBox10.Clear();
            textBox9.Clear();
            textBox2.Clear();
        }
    }
}
