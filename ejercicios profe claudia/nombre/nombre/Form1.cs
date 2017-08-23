using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nombre
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[,] nombre = { { "A", "B", }, { "C", "D" }, { "E", "F" }, { "G", "H" }, { "I", "J" }, { "K", "L" }, { "M", "N" }, { "O", "P" }, { "Q", "R" }, { "S", "T" }, { "U", "V" }, { "W", "X" }, { "Y", "Z" } };
            MessageBox.Show("nombre:   " + nombre[7, 0] + nombre[5, 1] + nombre[3, 0] + nombre[0, 0]+" " + nombre[1, 0] + nombre[0, 0] + nombre[9, 0] + nombre[9, 1] + nombre[8, 1] + nombre[7, 0]);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int[] numero = new int[10];

            numero[0]= 1;
            numero[1] = 2;
            numero[2] = 3;
            numero[3] = 4;
            numero[4] = 5;
            numero[5] = 6;
            numero[6] = 7;
            numero[7] = 8;
            numero[8] = 9;
            numero[9] = 0;
            MessageBox.Show("Cedula de ciudadania:    " + numero[0] +"."+ numero[9] + numero[6] + numero[1] +"."+ numero[5] + numero[5] + numero[4]+"." + numero[4] + numero[7] + numero[8]);
        }
    }
}
