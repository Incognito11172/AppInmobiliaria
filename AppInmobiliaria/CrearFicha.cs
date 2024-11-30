using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using BusinessLogic;
using Azure.Storage.Blobs;
using System.Configuration;

namespace Presentation
{
    public partial class CrearFicha : Form
    {

        private string office;
        private string imagePath = string.Empty;
        private string blobConnectionString = ConfigurationManager.ConnectionStrings["BLOBString"].ConnectionString;
        private string container = "estateimages";
        public CrearFicha(string dato)
        {
            InitializeComponent();
            label3.Text = label3.Text + " " + dato;
            office = dato;
        }

        private string subirImagenAzure()
        {
            try
            {
                // Crear un cliente de blob para el contenedor
                BlobServiceClient blobServiceClient = new BlobServiceClient(blobConnectionString);
                BlobContainerClient containerClient = blobServiceClient.GetBlobContainerClient(container);

                // Asegurarse de que el contenedor exista
                containerClient.CreateIfNotExists();

                // Obtener el nombre del archivo
                string nombreArchivo = Path.GetFileName(imagePath);

                // Crear un cliente para el blob
                BlobClient blobClient = containerClient.GetBlobClient(nombreArchivo);

                // Subir el archivo
                using (FileStream stream = File.OpenRead(imagePath))
                {
                    blobClient.Upload(stream, true);
                }

                // Devolver la URL pública del blob
                return blobClient.Uri.ToString();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        private void subirImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "Archivos de imagen|*.jpg; *.jpeg; *.png; *.gif; *.bmp|Todos los archivos|*.*";

            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                imagePath = openFileDialog.FileName;
                pictureBox12.Image = Image.FromFile(imagePath);
                pictureBox12.SizeMode = PictureBoxSizeMode.StretchImage;
            }

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
                inmueble.ruta_foto = subirImagenAzure();

                //inmueble.Add();

                this.Dispose();

                switch (tipoInmueble.SelectedItem.ToString())
                {
                    case "Vivienda":
                        AñadirVivienda vivienda = new AñadirVivienda(propietario, inmueble);
                        vivienda.ShowDialog();
                        break;
                    case "Local":
                        AñadirLocal local = new AñadirLocal(propietario, inmueble);
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
