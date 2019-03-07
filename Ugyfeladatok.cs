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
    public partial class Ugyfeladatok : Form
    {
        public Ugyfeladatok()
        {
            InitializeComponent();
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy.MM.dd";
            
        }
        
        private void Ugyfeladatok_Load(object sender, EventArgs e)
        {
            string startupPath = System.IO.Directory.GetCurrentDirectory();
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;" +
               @"AttachDbFilename=" + startupPath + "\\torzsadat.mdf;" +
               @"Integrated Security=True;");
            DataSet ds = new DataSet();
            SqlDataAdapter dataAdapter5 = new SqlDataAdapter("SELECT * FROM ugyfel", conn);
            dataAdapter5.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.AutoResizeColumns();
            dataGridView1.AutoResizeColumnHeadersHeight();

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

            string startupPath = System.IO.Directory.GetCurrentDirectory();
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;" +
               @"AttachDbFilename=" + startupPath + "\\torzsadat.mdf;" +
               @"Integrated Security=True;");

            conn.Open();
            SqlCommand cmd = new SqlCommand(@"Insert into torzsadat.ugyfel (Nev, Szuletesi_ido, Eletkor, Nemzetiseg, Sportag, Jelenlegi_klub, Poszt, Neme)  VALUES 
			(@Nev, @Szuletesi_ido, @Eletkor, @Nemzetiseg, @Sportag, @Jelenlegi_klub, @Poszt, @Neme)", conn);
            cmd.Parameters.Add(new SqlParameter("@Nev", textBox1.Text));
            cmd.Parameters.Add(new SqlParameter("@Szuletesi_ido", dateTimePicker1.Value.Date));
            cmd.Parameters.Add(new SqlParameter("@Eletkor", textBox3.Text));
            cmd.Parameters.Add(new SqlParameter("@Nemzetiseg", textBox4.Text));
            cmd.Parameters.Add(new SqlParameter("@Sportag", textBox5.Text));
            cmd.Parameters.Add(new SqlParameter("@Jelenlegi_klub", textBox6.Text));
            cmd.Parameters.Add(new SqlParameter("@Poszt", textBox7.Text));
            cmd.Parameters.Add(new SqlParameter("@Neme", textBox8.Text));
           
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Sikeresen felvitted az új ügyfelet", "Üzenet");
            Ugyfeladatok_Load(null,null);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string startupPath = System.IO.Directory.GetCurrentDirectory();
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;" +
               @"AttachDbFilename=" + startupPath + "\\torzsadat.mdf;" +
               @"Integrated Security=True;");

            conn.Open();
            SqlCommand cmd = new SqlCommand(@"Update ugyfel set Nev = @Nev, Szuletesi_ido = @Szuletesi_ido, Eletkor = @Eletkor, 
            Nemzetiseg = @Nemzetiseg, Sportag = @Sportag, Jelenlegi_klub = @Jelenlegi_klub, Poszt = @Poszt, Neme = @Neme 
			WHERE Nev = ('" + textBox1.Text + "')", conn);
            cmd.Parameters.Add(new SqlParameter("@Nev", textBox1.Text));
            cmd.Parameters.Add(new SqlParameter("@Szuletesi_ido", dateTimePicker1.Value.Date));
            cmd.Parameters.Add(new SqlParameter("@Eletkor", textBox3.Text));
            cmd.Parameters.Add(new SqlParameter("@Nemzetiseg", textBox4.Text));
            cmd.Parameters.Add(new SqlParameter("@Sportag", textBox5.Text));
            cmd.Parameters.Add(new SqlParameter("@Jelenlegi_klub", textBox6.Text));
            cmd.Parameters.Add(new SqlParameter("@Poszt", textBox7.Text));
            cmd.Parameters.Add(new SqlParameter("@Neme", textBox8.Text));

            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Sikeresen módosítottad az ügyfelet", "Üzenet");
            Ugyfeladatok_Load(null, null);
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            string startupPath = System.IO.Directory.GetCurrentDirectory();
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;" +
               @"AttachDbFilename=" + startupPath + "\\torzsadat.mdf;" +
               @"Integrated Security=True;");

            conn.Open();

            SqlCommand cmd = new SqlCommand(@"DELETE FROM ugyfel WHERE Nev = ('" + textBox1.Text + "')", conn);
            conn.Close();
            MessageBox.Show("Sikeresen törölted az ügyfelet", "Üzenet");
            Ugyfeladatok_Load(null, null);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string startupPath = System.IO.Directory.GetCurrentDirectory();
            using (SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;" +
               @"AttachDbFilename=" + startupPath + "\\torzsadat.mdf;" +
               @"Integrated Security=True;"))
            {
                SqlCommand command =
                new SqlCommand("select * FROM ugyfel WHERE Nev=('" + textBox1.Text + "')", connection);
                connection.Open();

                SqlDataReader read = command.ExecuteReader();

                while (read.Read())
                {
 
                    dateTimePicker1.Text = Convert.ToDateTime(read["Szuletesi_ido"]).ToString();
                    textBox3.Text = (read["Eletkor"].ToString());
                    textBox4.Text = (read["Nemzetiseg"].ToString());
                    textBox5.Text = (read["Sportag"].ToString());
                    textBox6.Text = (read["Jelenlegi_klub"].ToString());
                    textBox7.Text = (read["Poszt"].ToString());
                    textBox8.Text = (read["Neme"].ToString());
                }
                read.Close();
            }
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

        private void button4_Click_1(object sender, EventArgs e)
        {

        }
    }
}
