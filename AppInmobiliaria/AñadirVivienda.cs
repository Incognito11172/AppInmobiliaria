using BusinessLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation
{
    public partial class AñadirVivienda : Form
    {
        public AñadirVivienda(Propietario propietario, Inmueble inmueble)
        {
            InitializeComponent();

        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            // Añadir vivienda
            Vivienda vivienda = new Vivienda();

            vivienda.habitaciones = int.Parse(cantidadHabitaciones.Text);
            vivienda.baños = int.Parse(cantidadBaños.Text);
            vivienda.salon = salonCheckbox.Checked;
            vivienda.armarios = int.Parse(cantidadArmarios.Text);
            vivienda.m2_terraza = float.Parse(areaTerraza.Text);
            vivienda.garaje = garajeCheckbox.Checked;
            vivienda.gas = gasCheckbox.Checked;
            vivienda.calefaccion = calefaccionCheckbox.Checked;

        }
    }
}
