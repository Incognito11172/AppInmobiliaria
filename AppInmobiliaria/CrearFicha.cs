using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogic;

namespace Presentation
{
    public partial class CrearFicha : Form
    {

        private string office;
        public CrearFicha(string dato)
        {
            InitializeComponent();
            label3.Text = label3.Text + " " + dato;
            office = dato;
        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void continuar_Click(object sender, EventArgs e)
        {
            try
            {
                // Agregar propietario
                Propietario propietario = new Propietario();

                propietario.nombre = nombrePropietario.Text;
                propietario.telefono = telefonoPropietario.Text;

                //if (!propietario.DoesThisOwnerExist()) propietario.Add();

                // Obtener ID del propietario
                //int? id_propietario = propietario.GetID();

                // Obtener ID de la oficina
                Oficina oficina = new Oficina();
                oficina.nombre = office;

                int? id_oficina = oficina.GetID();

                // Agregar inmueble
                Inmueble inmueble = new Inmueble();

                inmueble.id_oficina = id_oficina;
                //inmueble.id_propietario = id_propietario;
                inmueble.precio_venta = float.Parse(precioVenta.Text);
                inmueble.precio_alquiler = float.Parse(precioAlquiler.Text);
                inmueble.direccion = direccion.Text;
                inmueble.metros_cuadrados = float.Parse(area.Text);
                //inmueble.ruta_foto = SubirImagenAzure();

                //inmueble.Add();

                this.Dispose();

                switch (tipoInmueble.SelectedItem.ToString())
                {
                    case "Vivienda":
                        AñadirVivienda vivienda = new AñadirVivienda(inmueble);
                        vivienda.ShowDialog();
                        break;
                    case "Local":
                        AñadirLocal local = new AñadirLocal(inmueble);
                        local.ShowDialog();
                        break;
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
