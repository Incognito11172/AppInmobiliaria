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
        public CrearFicha(string oficina)
        {
            InitializeComponent();
            label3.Text = label3.Text + " " + oficina;
        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void continuar_Click(object sender, EventArgs e)
        {
            try
            {
                Propietario propietario = new Propietario();

                propietario.nombre = nombrePropietario.Text;
                propietario.telefono = telefonoPropietario.Text;

                if (!propietario.DoesThisOwnerExist()) propietario.Add();
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
