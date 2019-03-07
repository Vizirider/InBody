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
    public partial class Felmeresdiagram : Form
    {
        public Felmeresdiagram(string nev)
        {
            InitializeComponent();
            textBox1.Text = nev;

            string startupPath = System.IO.Directory.GetCurrentDirectory();
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;" +
               @"AttachDbFilename=" + startupPath + "\\torzsadat.mdf;" +
               @"Integrated Security=True;");
            DataSet ds = new DataSet();
            SqlDataAdapter dataAdapter1 = new SqlDataAdapter("SELECT * FROM Felmeres WHERE Nev = ('" + this.textBox1.Text + "')", conn);
            dataAdapter1.Fill(ds);
            chart1.Titles.Add("Felmerés pontozás 0-3 közötti érték lehet");
            chart1.DataSource = ds.Tables[0];
            chart1.Series.Add("Mely_guggolas");
            chart1.Series["Mely_guggolas"].YValueMembers = "Mely_guggolas";
            chart1.Series["Mely_guggolas"].XValueMember = "Nev";
            chart1.Series["Mely_guggolas"].ChartType = SeriesChartType.Column;
            chart1.Series["Mely_guggolas"].LegendText = "Mély guggolás";
            chart1.Series["Mely_guggolas"].Color = Color.Blue;
            chart1.DataSource = ds.Tables[0];
            chart1.Series.Add("Akadaly_atlepes");
            chart1.Series["Akadaly_atlepes"].YValueMembers = "Akadaly_atlepes";
            chart1.Series["Akadaly_atlepes"].XValueMember = "Nev";
            chart1.Series["Akadaly_atlepes"].ChartType = SeriesChartType.Column;
            chart1.Series["Akadaly_atlepes"].LegendText = "Akadály átlépés";
            chart1.Series["Akadaly_atlepes"].Color = Color.Green;
            chart1.Series.Add("Kitores_egyvonalban");
            chart1.Series["Kitores_egyvonalban"].YValueMembers = "Kitores_egyvonalban";
            chart1.Series["Kitores_egyvonalban"].XValueMember = "Nev";
            chart1.Series["Kitores_egyvonalban"].ChartType = SeriesChartType.Column;
            chart1.Series["Kitores_egyvonalban"].LegendText = "Kitörés egyvonalban";
            chart1.Series["Kitores_egyvonalban"].Color = Color.Red;
            chart1.Series.Add("Vall_mobilitas");
            chart1.Series["Vall_mobilitas"].YValueMembers = "Vall_mobilitas";
            chart1.Series["Vall_mobilitas"].XValueMember = "Nev";
            chart1.Series["Vall_mobilitas"].ChartType = SeriesChartType.Column;
            chart1.Series["Vall_mobilitas"].LegendText = "Váll mobilitás";
            chart1.Series["Vall_mobilitas"].Color = Color.Brown;
            chart1.Series.Add("Aktiv_nyujtott_labemeles");
            chart1.Series["Aktiv_nyujtott_labemeles"].YValueMembers = "Aktiv_nyujtott_labemeles";
            chart1.Series["Aktiv_nyujtott_labemeles"].XValueMember = "Nev";
            chart1.Series["Aktiv_nyujtott_labemeles"].ChartType = SeriesChartType.Column;
            chart1.Series["Aktiv_nyujtott_labemeles"].LegendText = "Aktív nyújtott lábemelés";
            chart1.Series["Aktiv_nyujtott_labemeles"].Color = Color.RosyBrown;
            chart1.Series.Add("Torzs_stabilitas_fekvotamasz");
            chart1.Series["Torzs_stabilitas_fekvotamasz"].YValueMembers = "Torzs_stabilitas_fekvotamasz";
            chart1.Series["Torzs_stabilitas_fekvotamasz"].XValueMember = "Nev";
            chart1.Series["Torzs_stabilitas_fekvotamasz"].ChartType = SeriesChartType.Column;
            chart1.Series["Torzs_stabilitas_fekvotamasz"].LegendText = "Törzs stabilitás fekvőtámasz";
            chart1.Series["Torzs_stabilitas_fekvotamasz"].Color = Color.Orange;
            chart1.Series.Add("Rotacios_stabilitas");
            chart1.Series["Rotacios_stabilitas"].YValueMembers = "Rotacios_stabilitas";
            chart1.Series["Rotacios_stabilitas"].XValueMember = "Nev";
            chart1.Series["Rotacios_stabilitas"].ChartType = SeriesChartType.Column;
            chart1.Series["Rotacios_stabilitas"].LegendText = "Rotációs stabilitás";
            chart1.Series["Rotacios_stabilitas"].Color = Color.LightCoral;
            chart1.Series[0].IsVisibleInLegend = false;


        }

        private void Felmeresdiagram_Load(object sender, EventArgs e)
        {

        }
    }
}
