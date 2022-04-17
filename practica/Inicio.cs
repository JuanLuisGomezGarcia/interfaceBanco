using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vuelos;
namespace practica
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        

        private void Inicio_Load(object sender, EventArgs e)
        {
            btnSolicitarPrestamo.Enabled = false;
        }

        private void controlBotones()
        { if(Nombre.Text.Trim() !=String.Empty && Nombre.Text.All(Char.IsLetter))
            {
                btnSolicitarPrestamo.Enabled = true;
                errorProvider1.SetError(Nombre, "");

            }
            else {
                if (!(Nombre.Text.All(Char.IsLetter))) { errorProvider1.SetError(Nombre, "El nombre debe contener solo letras"); }
                else { errorProvider1.SetError(Nombre, "Debe introducir su nombre"); }
                btnSolicitarPrestamo.Enabled = false;
                Nombre.Focus();
                        
                        }

        }
        private void btnSolicitarPrestamo_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnSolicitarPrestamo_Click(object sender, EventArgs e)
        {
            using (Prestamo ventanaPrestamos = new Prestamo (Nombre.Text))
                ventanaPrestamos.ShowDialog();

            
        }

        private void Nombre_TextChanged(object sender, EventArgs e)
        {
            controlBotones();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
