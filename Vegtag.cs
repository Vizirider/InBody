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
    public partial class Vegtag : Form
    {
        public Vegtag()
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
            textBox7.Clear();
            textBox6.Clear();
            textBox2.Clear();
            textBox10.Clear();
            textBox9.Clear();
            textBox8.Clear();
            textBox13.Clear();
            textBox12.Clear();
            textBox11.Clear();
            textBox16.Clear();
            textBox15.Clear();
            textBox14.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string startupPath = System.IO.Directory.GetCurrentDirectory();
            using (SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;" +
               @"AttachDbFilename=" + startupPath + "\\torzsadat.mdf;" +
               @"Integrated Security=True;"))
            {
                SqlCommand command =
                new SqlCommand("select * FROM Vegtag WHERE Nev=('" + textBox1.Text + "')", connection);
                connection.Open();

                SqlDataReader read = command.ExecuteReader();

                while (read.Read())
                {

                    dateTimePicker1.Text = Convert.ToDateTime(read["Szuletesi_ido"]).ToString();
                    textBox3.Text = (read["Bal_kar_izomtomeg"].ToString());
                    textBox4.Text = (read["Bal_kar_testzsir"].ToString());
                    textBox5.Text = (read["Bal_kar_izomminoseg"].ToString());
                    textBox7.Text = (read["Jobb_kar_izomtomeg"].ToString());
                    textBox6.Text = (read["Jobb_kar_testzsir"].ToString());
                    textBox2.Text = (read["Jobb_kar_izomminoseg"].ToString());
                    textBox10.Text = (read["Bal_lab_izomtomeg"].ToString());
                    textBox9.Text = (read["Bal_lab_testzsir"].ToString());
                    textBox8.Text = (read["Bal_lab_izomminoseg"].ToString());
                    textBox13.Text = (read["Jobb_lab_izomtomeg"].ToString());
                    textBox12.Text = (read["Jobb_lab_testzsir"].ToString());
                    textBox11.Text = (read["Jobb_lab_izomminoseg"].ToString());
                    textBox16.Text = (read["Torzs_izomtomeg"].ToString());
                    textBox15.Text = (read["Torzs_testzsir"].ToString());
                    textBox14.Text = (read["Torzs_izomminoseg"].ToString());
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
            textBox7.Clear();
            textBox6.Clear();
            textBox2.Clear();
            textBox10.Clear();
            textBox9.Clear();
            textBox8.Clear();
            textBox13.Clear();
            textBox12.Clear();
            textBox11.Clear();
            textBox16.Clear();
            textBox15.Clear();
            textBox14.Clear();

            string startupPath = System.IO.Directory.GetCurrentDirectory();
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;" +
               @"AttachDbFilename=" + startupPath + "\\torzsadat.mdf;" +
               @"Integrated Security=True;");

            conn.Open();
            SqlCommand cmd = new SqlCommand(@"Insert into torzsadat.Vegtag (Nev, Szuletesi_ido, Bal_kar_izomtomeg, Bal_kar_testzsir, Bal_kar_izomminoseg, Jobb_kar_izomtomeg, Jobb_kar_testzsir, Jobb_kar_izomminoseg,
            Bal_lab_izomtomeg, Bal_lab_testzsir, Bal_lab_izomminoseg, Jobb_lab_izomtomeg, Jobb_lab_testzsir, Jobb_lab_izomminoseg, Torzs_izomtomeg, Torzs_testzsir, Torzs_izomminoseg)  VALUES 
			(@Nev, @Szuletesi_ido, @Bal_kar_izomtomeg, @Bal_kar_testzsir, @Bal_kar_izomminoseg, @Jobb_kar_izomtomeg, @Jobb_kar_testzsir, @Jobb_kar_izomminoseg,
            @Bal_lab_izomtomeg, @Bal_lab_testzsir, @Bal_lab_izomminoseg, @Jobb_lab_izomtomeg, @Jobb_lab_testzsir, @Jobb_lab_izomminoseg, @Torzs_izomtomeg, @Torzs_testzsir, @Torzs_izomminoseg)", conn);
            cmd.Parameters.Add(new SqlParameter("@Nev", textBox1.Text));
            cmd.Parameters.Add(new SqlParameter("@Szuletesi_ido", dateTimePicker1.Value.Date));
            cmd.Parameters.Add(new SqlParameter("@Bal_kar_izomtomeg", textBox3.Text));
            cmd.Parameters.Add(new SqlParameter("@Bal_kar_testzsir", textBox4.Text));
            cmd.Parameters.Add(new SqlParameter("@Bal_kar_izomminoseg", textBox5.Text));
            cmd.Parameters.Add(new SqlParameter("@Jobb_kar_izomtomeg", textBox7.Text));
            cmd.Parameters.Add(new SqlParameter("@Jobb_kar_testzsir", textBox6.Text));
            cmd.Parameters.Add(new SqlParameter("@Jobb_kar_izomminoseg", textBox2.Text));
            cmd.Parameters.Add(new SqlParameter("@Bal_lab_izomtomeg", textBox10.Text));
            cmd.Parameters.Add(new SqlParameter("@Bal_lab_testzsir", textBox9.Text));
            cmd.Parameters.Add(new SqlParameter("@Bal_lab_izomminoseg", textBox8.Text));
            cmd.Parameters.Add(new SqlParameter("@Jobb_lab_izomtomeg", textBox13.Text));
            cmd.Parameters.Add(new SqlParameter("@Jobb_lab_testzsir", textBox12.Text));
            cmd.Parameters.Add(new SqlParameter("@Jobb_lab_izomminoseg", textBox11.Text));
            cmd.Parameters.Add(new SqlParameter("@Torzs_izomtomeg", textBox16.Text));
            cmd.Parameters.Add(new SqlParameter("@Torzs_testzsir", textBox15.Text));
            cmd.Parameters.Add(new SqlParameter("@Torzs_izomminoseg", textBox14.Text));
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Sikeresen felvitted az új mérést", "Üzenet");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string startupPath = System.IO.Directory.GetCurrentDirectory();
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;" +
               @"AttachDbFilename=" + startupPath + "\\torzsadat.mdf;" +
               @"Integrated Security=True;");

            conn.Open();
            SqlCommand cmd = new SqlCommand(@"Update Vegtag SET Nev=@Nev, Szuletesi_ido=@Szuletesi_ido, Bal_kar_izomtomeg=@Bal_kar_izomtomeg, Bal_kar_testzsir=@Bal_kar_testzsir, Bal_kar_izomminoseg=@Bal_kar_izomminoseg, Jobb_kar_izomtomeg=@Jobb_kar_izomtomeg, Jobb_kar_testzsir=@Jobb_kar_testzsir, Jobb_kar_izomminoseg=@Jobb_kar_izomminoseg,
            Bal_lab_izomtomeg=@Bal_lab_izomtomeg, Bal_lab_testzsir=@Bal_lab_testzsir, Bal_lab_izomminoseg=@Bal_lab_izomminoseg, Jobb_lab_izomtomeg=@Jobb_lab_izomtomeg, Jobb_lab_testzsir=@Jobb_lab_testzsir, Jobb_lab_izomminoseg=@Jobb_lab_izomminoseg, Torzs_izomtomeg=@Torzs_izomtomeg, Torzs_testzsir=@Torzs_testzsir, Torzs_izomminoseg=@Torzs_izomminoseg
            WHERE Nev = ('" + textBox1.Text + "')", conn);
            cmd.Parameters.Add(new SqlParameter("@Nev", textBox1.Text));
            cmd.Parameters.Add(new SqlParameter("@Szuletesi_ido", dateTimePicker1.Value.Date));
            cmd.Parameters.Add(new SqlParameter("@Bal_kar_izomtomeg", textBox3.Text));
            cmd.Parameters.Add(new SqlParameter("@Bal_kar_testzsir", textBox4.Text));
            cmd.Parameters.Add(new SqlParameter("@Bal_kar_izomminoseg", textBox5.Text));
            cmd.Parameters.Add(new SqlParameter("@Jobb_kar_izomtomeg", textBox7.Text));
            cmd.Parameters.Add(new SqlParameter("@Jobb_kar_testzsir", textBox6.Text));
            cmd.Parameters.Add(new SqlParameter("@Jobb_kar_izomminoseg", textBox2.Text));
            cmd.Parameters.Add(new SqlParameter("@Bal_lab_izomtomeg", textBox10.Text));
            cmd.Parameters.Add(new SqlParameter("@Bal_lab_testzsir", textBox9.Text));
            cmd.Parameters.Add(new SqlParameter("@Bal_lab_izomminoseg", textBox8.Text));
            cmd.Parameters.Add(new SqlParameter("@Jobb_lab_izomtomeg", textBox13.Text));
            cmd.Parameters.Add(new SqlParameter("@Jobb_lab_testzsir", textBox12.Text));
            cmd.Parameters.Add(new SqlParameter("@Jobb_lab_izomminoseg", textBox11.Text));
            cmd.Parameters.Add(new SqlParameter("@Torzs_izomtomeg", textBox16.Text));
            cmd.Parameters.Add(new SqlParameter("@Torzs_testzsir", textBox15.Text));
            cmd.Parameters.Add(new SqlParameter("@Torzs_izomminoseg", textBox14.Text));
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Sikeresen módosítottad a mérést", "Üzenet");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string startupPath = System.IO.Directory.GetCurrentDirectory();
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;" +
               @"AttachDbFilename=" + startupPath + "\\torzsadat.mdf;" +
               @"Integrated Security=True;");

            conn.Open();

            SqlCommand cmd = new SqlCommand(@"DELETE FROM Vegtag WHERE Nev = ('" + textBox1.Text + "')", conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Sikeresen törölted a mérést", "Üzenet");
            button6_Click(null, null);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string startupPath = System.IO.Directory.GetCurrentDirectory();
            using (SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;" +
               @"AttachDbFilename=" + startupPath + "\\torzsadat.mdf;" +
               @"Integrated Security=True;"))
            {
                SqlCommand command =
                    new SqlCommand("select nev from Vegtag WHERE Nev = ('" + this.textBox1.Text + "')", connection);
                connection.Open();

                SqlDataReader read = command.ExecuteReader();

                while (read.Read())
                {
                    Vegtagdiagram vegtagdia = new Vegtagdiagram(this.textBox1.Text);
                    vegtagdia.Show();
                }


            }
        }
    }
}
