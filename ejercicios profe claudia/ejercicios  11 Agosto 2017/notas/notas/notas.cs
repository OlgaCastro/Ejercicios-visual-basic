using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace notas
{
    public partial class notas : Form
    {
        public notas()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double nota1, nota2, nota3, promedio;
            nota1 = double.Parse(textBox1.Text);
            nota2 = double.Parse(textBox2.Text);

            if (textBox3.Text == "")
            {
                MessageBox.Show(" Error, debe ingresar un dato ");
            }
            else
            {
                nota3 = double.Parse(textBox3.Text);

                if (nota3 > 10.0)
                {
                    MessageBox.Show(" Error, las notas que ingreso, deben estar entre 0 y 10", " ERROR ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    promedio = (nota1 + nota2 + nota3) / 3;

                    if (promedio >= 7.0)
                    {
                        MessageBox.Show("Felicitaciones usted ha aprobado la materia con un promedio de : ", +promedio + "FELICITACIONES ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        if (promedio < 3.0)
                        {
                            MessageBox.Show(" Usted es muy VAGO y reprobo la materia con un promedio de: ", +promedio + "LOS SIENTO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Usted tiene la posibilidad de aprobar la materia, presentando una evaluacion, tiene un promedio de: " + promedio + " pero no es sucifiente para aprobar ", " ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            MessageBox.Show(" Ingrese la nota de la evaluacion para saber si definitivamente Aprobo o desaprobo la materia");
                            textBox4.Visible = true;
                            Notafinal.Visible = true;
                            textBox3.ReadOnly = true;
                            Evaluacion.Enabled = false;
                        }
                    }
                }
            }
        }





        private void Reprobo_Click(object sender, EventArgs e)
        {
            double nota1, nota2;

            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Error, debe ingresar los datos");
            }
            else
            {
                nota1 = double.Parse(textBox1.Text);
                nota2 = double.Parse(textBox2.Text);


                if (nota1 > 10.0 || nota2 > 10.0)
                {
                    MessageBox.Show(" Error, las notas que ingrese deben ser entre 0  y 10 ", " ERROR ", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    if (nota1 <= 2.0 && nota2 <= 2.0)
                    {
                        MessageBox.Show(" Reprobo la asignatura porque sus calificaciones fueron muy bajas, no puede recuperar ", " REPROBO ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (nota1 >= 9.0 && nota2 >= 9.0)
                    {
                        MessageBox.Show("Aprobo la materia , No tiene que presentar la evaluacion final", "APROBO", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("Usted tiene la posibilidad de pasar la materia,ingrese la tercera nota y pulse el boton verificar ", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        textBox3.Visible = true;
                        Evaluacion.Visible = true;

                        textBox1.ReadOnly = true;
                        textBox2.ReadOnly = true;
                        Reprobo.Enabled = false;



                    }
                }
            }
        }

        private void Notafinal_Click(object sender, EventArgs e)
        {
            double evaluacion;
            if (textBox4.Text=="")
            {
                MessageBox.Show("Error, debe ingresar un dato");

            }
            else
            {
                evaluacion = double.Parse(textBox4.Text);
                if (evaluacion>10.0)
                {
                    MessageBox.Show("Error, las notas que ingrese debe estar entre 0 y 10", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    if(evaluacion <=5.0)
                    {
                        MessageBox.Show("La calificacion final no tiene una nota lo suficientemente alta para que pudiera aprobar la materia,desafortunadamente REPROBO ");

                    }
                    else
                    {
                        MessageBox.Show("APROBO LA MATERIA", "informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }
    }
    }
