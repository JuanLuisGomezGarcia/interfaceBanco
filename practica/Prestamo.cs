using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practica
{
    public partial class Prestamo : Form
    {

        string nombre_cliente;
        string[] razas_disponibles = { "Elfo", "Uruk-hay", "Hobbit", "Enano", "Orco", "Humano" };
        int[] cuotas_disponibles = { 12, 24, 60, 120 };
        string[] lugares_disponibles;
        Dictionary<int, double> intereses_base;
        public Prestamo(string Nombre)
        {
            InitializeComponent();
            nombre_cliente = Nombre;
            string listado_ciudades = Properties.Resources.lugares.ToString();
            lugares_disponibles = listado_ciudades.Split(new[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);

            intereses_base = new Dictionary<int, double>();
            int i; double interes;
            for (i = 0, interes = 3.0; i < cuotas_disponibles.Length; i++, interes += 0.5) {
                intereses_base[cuotas_disponibles[i]] = interes;
            }

        }

        private void Prestamo_Load(object sender, EventArgs e)
        {
            popularCiudades();
            popularRazas();
            popularCuotas();
            Saludo.Text += nombre_cliente;
        }


        void popularRazas()
        {
            for (int i = 0; i < razas_disponibles.Length; i++)
            {
                Raza.Items.Add(razas_disponibles[i]);
            }
        }

        void popularCuotas()
        { for (int i = 0; i < cuotas_disponibles.Length; i++)
                Cuotas.Items.Add(cuotas_disponibles[i]);
        }
        void popularCiudades()
        {
            for (int i = 0; i < lugares_disponibles.Length; i++)
            {
                Lugares.Items.Add(lugares_disponibles[i]);
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        double calcularInteres()
        {
            int cuotas_pedidas = (int)Cuotas.SelectedItem;
            string razas_seleccionada = Raza.SelectedItem.ToString().ToLower();
            string lugar_seleccionado = Lugares.SelectedItem.ToString().ToLower();
            double interes = intereses_base[cuotas_pedidas];

            if (new[] { "Elfo", "Orco" }.Contains(razas_seleccionada)) { interes += 5.0; }

            if (new[] { "la linea", "san roque" }.Contains(lugar_seleccionado)) {
                interes -= 3;
            }
            return interes;

        }



        int validaciones()
        {
            if ((Raza.SelectedIndex <= -1) || (Lugares.SelectedIndex <= -1)) {
                return 1; }
            else { if (!(Monto.Text.All(Char.IsDigit)) || (Monto.Text == "") || (Cuotas.SelectedIndex <= -1))
                { return 2; } else { return 0; }



            } }

        private void btnConfirmarSolicitud_Click(object sender, EventArgs e)
        {
            switch (validaciones()) {
                case 0:
                    {
                        errorProvider1.SetError(DatosPersonales, "");
                        errorProvider1.SetError(DatosPrestamo, "");
                        double interes_mensual = calcularInteres();
                        double monto_pedido = double.Parse(Monto.Text);
                        int cuotas_pedidas = (int)Cuotas.SelectedItem;
                        double interes_total = monto_pedido * (interes_mensual / 100) * cuotas_pedidas;
                        double monto_a_pagar = monto_pedido + interes_total;
                        string mensaje = "Su prestamo por " + monto_pedido + " en " + cuotas_pedidas + " cuotas pedidas ";
                        MessageBoxButtons buttons = MessageBoxButtons.OK;
                        MessageBox.Show(mensaje, "Calculo de interes", buttons);
                        break;
                    }
                case 1:
                    {
                        errorProvider1.SetError(DatosPersonales, "Debe completar todos los datos personales");
                        errorProvider1.SetError(DatosPrestamo, "");
                        break;
                    }
                case 2: { errorProvider1.SetError(DatosPrestamo, "Debe ingresar un monto numerico y unca catidad de plazsos");
                        errorProvider1.SetError(DatosPersonales, "");
                        break;
                    }
                    
        }
            
        
        } 
                

        } 
        }
        
    

    


