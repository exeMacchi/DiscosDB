using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace Vista
{
    public partial class frmPlantillaDisco : Form
    {
        private Disco disco = null;

        public frmPlantillaDisco()
        {
            InitializeComponent();
            btnAgregar.Text = "AGREGAR";
        }

        public frmPlantillaDisco(Disco discoModificar)
        {
            InitializeComponent();
            disco = discoModificar;
            btnAgregar.Text = "MODIFICAR";
        }

        private void txbxCantidadCanciones_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ( (e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            DiscoNegocio discoNegocio = new DiscoNegocio();
            try
            {
                if (disco == null)
                {
                    disco = new Disco();
                }

                disco.Titulo = txbxTitulo.Text;
                disco.FechaLanzamiento = dtpFechaLanzamiento.Value;
                disco.CantidadCanciones = int.Parse(txbxCantidadCanciones.Text);
                if (txbxPortada.Text.StartsWith("http") && CargarImagen(txbxPortada.Text))
                {
                    disco.Portada = txbxPortada.Text;
                }
                else if (CargarImagen(txbxPortada.Text))
                {
                    // string rutaDestino = ConfigurationManager.AppSettings["Portadas"] + ofdPortada.SafeFileName;
                    // File.Copy(ofdPortada.FileName, rutaDestino);
                    disco.Portada = txbxPortada.Text;
                }
                else
                {
                    disco.Portada = "";
                }
                disco.Estilo = (Estilo)comboxEstilo.SelectedItem;
                disco.Edicion = (Edicion)comboxEdicion.SelectedItem;

                if (disco.Id != 0)
                {
                    discoNegocio.ModificarDisco(disco);
                    MessageBox.Show("¡Disco modificado con éxito!", "Modificación disco", 
                                    MessageBoxButtons.OK);
                }
                else
                {
                    discoNegocio.AgregarDisco(disco);
                    MessageBox.Show("¡Disco agregado con éxito!", "Nuevo disco", 
                                    MessageBoxButtons.OK);
                }
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void frmPlantillaDisco_Load(object sender, EventArgs e)
        {
            EstiloNegocio estiloNegocio = new EstiloNegocio();
            comboxEstilo.DataSource = estiloNegocio.CargarEstilos();
            comboxEstilo.DisplayMember = "Descripcion";
            comboxEstilo.ValueMember = "ID";

            EdicionNegocio edicionNegocio = new EdicionNegocio();
            comboxEdicion.DataSource = edicionNegocio.CargarEdiciones();
            comboxEdicion.DisplayMember = "Descripcion";
            comboxEdicion.ValueMember = "ID";
                
            btnAgregar.Enabled = false;
            txbxPortada.Text = "Seleccione una imagen o escriba una URL...";
            dtpFechaLanzamiento.CustomFormat = "dd/MM/yyyy";

            if (this.disco != null)
            {
                btnAgregar.Enabled = true;
                this.Text = "Modificar disco";

                txbxTitulo.Text = disco.Titulo;
                dtpFechaLanzamiento.Value = disco.FechaLanzamiento;
                txbxCantidadCanciones.Text = disco.CantidadCanciones.ToString();
                txbxPortada.Text = disco.Portada;
                CargarImagen(disco.Portada);
                comboxEstilo.SelectedValue = disco.Estilo.ID;
                comboxEdicion.SelectedValue = disco.Edicion.ID;
            }
        }

        private void txbxTitulo_TextChanged(object sender, EventArgs e)
        {
            VerificarTextBox();
        }

        private void txbxCantidadCanciones_TextChanged(object sender, EventArgs e)
        {
            VerificarTextBox();
        }
        private void txbxPortada_TextChanged(object sender, EventArgs e)
        {
            VerificarTextBox();
        }

        private void VerificarTextBox()
        {
            if (txbxTitulo.Text != "" && 
                txbxCantidadCanciones.Text != "" && 
                txbxPortada.Text != "Seleccione una imagen o escriba una URL...")
            {
                btnAgregar.Enabled = true;
            }
            else
            {
                btnAgregar.Enabled = false;
            }
        }

        private bool CargarImagen(string ruta)
        {
            try
            {
                pboxPortada.Load(ruta);
                return true;
            }
            catch (Exception)
            {
                try
                {
                    pboxPortada.Load("https://www.carsaludable.com.ar/wp-content/uploads/2014/03/default-placeholder.png");
                    return false;
                }
                catch (Exception)
                {
                    MessageBox.Show("El problema es al cargar la imagen placeholder.", "Error");
                    return false;
                }
            }
        }

        private void btnPortada_Click(object sender, EventArgs e)
        {
            ofdPortada.Filter = "Archivos de imagen|*.jpg;*.png";
            
            if (ofdPortada.ShowDialog() == DialogResult.OK)
            {
                string rutaArchivo = ofdPortada.FileName;
                CargarImagen(rutaArchivo);
                txbxPortada.Text = rutaArchivo;
            }
        }

        private void txbxPortada_Leave(object sender, EventArgs e)
        {
            CargarImagen(txbxPortada.Text);
        }

    }
}
