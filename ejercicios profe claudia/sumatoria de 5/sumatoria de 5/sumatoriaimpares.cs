﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sumatoria_de_5
{
    public partial class sumatoriaimpares : Form
    {
        public sumatoriaimpares()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int suma = 0;
           
            for(int i =1;i<300;i++)
            {
                suma = 300/2;

                if (i% 2==1)
                {
                   
                    MessageBox.Show("numero impar" + i);
                }
             
              
            }
            MessageBox.Show("Hay  " +suma+ "  numeros impares" );
        }
    }
}
