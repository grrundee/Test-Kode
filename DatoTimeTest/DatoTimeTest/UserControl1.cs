using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace DatoTimeTest
{
    public partial class UserControl1: UserControl
    {
        // string connectionString = ConfigurationManager.ConnectionStrings["conRailroad"].ConnectionString;//Lagrer connection string til en variabel
        // SqlConnection con = new SqlConnection("connectionString");//Oppretter et objekt av klassen sqlConnection

        public UserControl1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime dato = new DateTime(); // Oppretter et objekt av DateTime klassen
            dato = Convert.ToDateTime(txtInput.Text); // konverterer innholdet i textboxen til DateTime
            txtShow.Text = dato.ToShortDateString(); // konverter til string og dropper tids delen
        }

        private void btnSendDate_Click(object sender, EventArgs e)
        {
            /*DataTable dt = new DataTable();
            SqlCommand procedure = new SqlCommand("navnet på proceduren", con); 
            procedure.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter sda;
            con.Open();
            sda = new SqlDataAdapter(procedure);
            sda.Fill(dt); 
            procedure.ExecuteNonQuery();
            con.Close();*/
        }
    }
}
