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


namespace tablas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string a;
        double n;

        private void button1_Click(object sender, EventArgs e)
        {
            a = Interaction.InputBox("ingrese numero a multiplicar");
            double b = Convert.ToDouble(a);

            for (int i =1; i<=10; i++)
            { 
            n = b*i;

                MessageBox.Show("multiplicacion:  " + b + "*" + i + "=" + n);
            }
          

        }
    }
}
