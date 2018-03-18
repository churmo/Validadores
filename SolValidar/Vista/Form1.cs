using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos;

namespace Vista
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }
        int edad;
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            edad = int.Parse(txtEdad.Text);
            if (Validar.esEntero(txtEntero.Text) == false)
            {
                MessageBox.Show("Numero no valido");
                
            }

            if (Validar.esDecimal(txtEntero.Text) == false)
            {
                MessageBox.Show("Numero no valido");
            }

            if (Validar.esEdad(txtEntero.Text) == false)
            {
                MessageBox.Show("Numero no valido");
            }
            else if (edad <= 0 && edad >= 100)
            {
                MessageBox.Show("Edad no valida");
            }

            if (Validar.esDigito(txtCadena.Text) == true)
            {
                MessageBox.Show("Es un digito");
            }
        }
        }
    }
