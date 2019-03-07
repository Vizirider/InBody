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
using System.Windows.Forms.DataVisualization.Charting;

namespace InBody
{
    public partial class Meresdiagram : Form
    {
        public Meresdiagram(string nev)
        {
            InitializeComponent();
            this.textBox1.Text = nev;
            button3_Click(null,null);
            button1_Click(null, null);
 //           button2_Click(null, null);
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy.MM.dd";
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
                }
                read.Close();
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {

            string startupPath = System.IO.Directory.GetCurrentDirectory();
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;" +
               @"AttachDbFilename=" + startupPath + "\\torzsadat.mdf;" +
               @"Integrated Security=True;");
            DataSet ds = new DataSet();
            SqlDataAdapter dataAdapter1 = new SqlDataAdapter("SELECT * FROM Meresek WHERE Nev = ('" + this.textBox1.Text + "')", conn);
            dataAdapter1.Fill(ds);
            chart1.Titles.Add("Testsúly zsír-tömeg analízis");
            chart1.DataSource = ds.Tables[0];
            chart1.Series.Add("Suly");
            chart1.Series["Suly"].YValueMembers = "Suly";
            chart1.Series["Suly"].XValueMember = "Nev";
            chart1.Series["Suly"].ChartType = SeriesChartType.Column;
            chart1.Series["Suly"].LegendText = "Testtömeg";
            chart1.Series["Suly"].Color = Color.Blue;
            chart1.DataSource = ds.Tables[0];
            chart1.Series.Add("Izomtomeg");
            chart1.Series["Izomtomeg"].YValueMembers = "Izomtomeg";
            chart1.Series["Izomtomeg"].XValueMember = "Nev";
            chart1.Series["Izomtomeg"].ChartType = SeriesChartType.Column;
            chart1.Series["Izomtomeg"].LegendText = "Izomtömeg";
            chart1.Series["Izomtomeg"].Color = Color.Green;
            chart1.Series.Add("Testzsir");
            chart1.Series["Testzsir"].YValueMembers = "Testzsir";
            chart1.Series["Testzsir"].XValueMember = "Nev";
            chart1.Series["Testzsir"].ChartType = SeriesChartType.Column;
            chart1.Series["Testzsir"].LegendText = "Testzsir";
            chart1.Series["Testzsir"].Color = Color.Red;
            chart1.Series[0].IsVisibleInLegend = false;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            string startupPath = System.IO.Directory.GetCurrentDirectory();
            using (SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;" +
               @"AttachDbFilename=" + startupPath + "\\torzsadat.mdf;" +
               @"Integrated Security=True;"))
            {
                SqlCommand command =
                new SqlCommand("SELECT ROUND((Testzsir/ Suly)*100,2) AS Testzsir_szazalek,  " +
                "ROUND((Zsigerizsir/ Suly)*100,2) AS Zsigerizsir_szazalek, ROUND((Testviz/ Suly)*100,2) AS Testviz_szazalek  FROM Meresek WHERE Nev=('" + textBox1.Text + "')", connection);
                connection.Open();

                SqlDataReader read = command.ExecuteReader();

                while (read.Read())
                {

                    textBox2.Text = (read["Testzsir_szazalek"].ToString());
                    textBox4.Text = (read["Zsigerizsir_szazalek"].ToString());
                    textBox5.Text = (read["Testviz_szazalek"].ToString());
                }
                read.Close();
            }
        }


    }
}
