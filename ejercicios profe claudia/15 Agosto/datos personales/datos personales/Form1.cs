using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace datos_personales
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string nom;
        string carr;
        string id;


        private void button1_Click(object sender, EventArgs e)
        {
            nom = Interaction.InputBox("Ingrese su nombre:");
            carr = Interaction.InputBox("Ingrese su carrera:");
            id = Interaction.InputBox("Ingrese su identificacion:");

            MessageBox.Show("su nombre es:  " + nom + "su carrera es:   " + carr + "su identificacion es:   " + id);
            

        }
    }
}
