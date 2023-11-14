using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Validaciones_Laboratorio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
           //Solo numeros 
            if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != 8)
            {

                e.Handled = true;
            }

            //Solo numeros hasta la longitud de 4

            if (textBox1.Text.Length >= 4 && e.KeyChar != 8)
            {
                e.Handled = true; // Bloquea la tecla ingresada 
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Solo letras 
            if (!(e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != 8)
            {

                e.Handled = true;
            }

            //Solo letras hasta la longitud de 6

            if (textBox2.Text.Length >= 6 && e.KeyChar != 8)
            {
                e.Handled = true; 
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Solo letras 
            if (!(e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != 8)
            {

                e.Handled = true;
            }

            //Solo letras hasta la longitud 3 

            if (textBox3.Text.Length >= 3  && e.KeyChar != 8)
            {
                e.Handled = true;
                


            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Enabled = false;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            //Habilita el boton a partir de cierta longitud ---> Tex changed
            if(textBox3.Text.Length >= 3 )
            {
                button1.Enabled=true;
            } else
            {
                button1.Enabled=false;
            }
        }
    }
}
