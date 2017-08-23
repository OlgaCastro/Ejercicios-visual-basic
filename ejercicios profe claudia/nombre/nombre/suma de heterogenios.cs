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
    public partial class suma_de_heterogenios : Form
    {
        public suma_de_heterogenios()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a, b, c, d, resultado, multiplicacion;
            int op;
            
            if (textBox5.Text=="")
            {
                MessageBox.Show("Debe elegir la opcion a realizar");

            }
            else
            {
                a = int.Parse(TXTA.Text);
                b = int.Parse(TXTB.Text);
                c = int.Parse(TXTC.Text);
                d = int.Parse(TXTD.Text);
                op = int.Parse(textBox5.Text);
            }

        }
    }
}
