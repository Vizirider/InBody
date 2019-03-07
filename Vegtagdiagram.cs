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
    public partial class Vegtagdiagram : Form
    {
        public Vegtagdiagram(string nev)
        {
            InitializeComponent();
            this.textBox1.Text = nev;
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

                    textBox2.Text = (read["Torzs_izomminoseg"].ToString());
                    textBox3.Text = (read["Bal_kar_izomminoseg"].ToString());
                    textBox4.Text = (read["Jobb_kar_izomminoseg"].ToString());
                    textBox6.Text = (read["Bal_lab_izomminoseg"].ToString());
                    textBox5.Text = (read["Jobb_lab_izomminoseg"].ToString());
                }
                read.Close();
            }
            button1_Click(null, null);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
