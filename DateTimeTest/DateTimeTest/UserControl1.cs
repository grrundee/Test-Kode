using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DateTimeTest
{
    public partial class UserControl1: UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private void txtInput_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime dato = new DateTime(); // Oppretter et objekt av DateTime klassen
            dato = Convert.ToDateTime(txtInput.Text); // konverterer innholdet i textboxen til DateTime
            txtShow.Text = dato.ToShortDateString(); // konverter til string og dropper tids delen
        }
    }
}
