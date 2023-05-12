using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;

namespace Vista
{
    public partial class frmPrincipal : Form
    {
        private List<Disco> discos;
        private int cantDiscos;

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            CargarGrilla();
            ActualizarResultados();
        }

        private void CargarGrilla()
        {
            DiscoNegocio dc = new DiscoNegocio();
            this.discos = dc.CargarDiscos();

            ActualizarGrilla(this.discos);
        }

        private void ActualizarGrilla(List<Disco> discos)
        {
            if (discos != null )
            {
                dgvDiscos.DataSource = discos;
                OcultarColumnas();
                if (dgvDiscos.Rows.Count > 0)
                {
                    CargarImagen(discos[0].Portada);
                }
                // Configuración columnas
                dgvDiscos.Columns["Titulo"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
            else
            {
                MessageBox.Show("Algo pasó, pa.", "Error", MessageBoxButtons.OK, 
                                MessageBoxIcon.Error);
            }
        }

        private void ActualizarResultados()
        {
            cantDiscos = dgvDiscos.RowCount;
            lbResultados.Text = $"Resultados: {cantDiscos}";
        }

        private void CargarImagen(string url)
        {
            try
            {
                pboxPortadas.Load(url);
            }
            catch (Exception)
            {
                try
                {
                    pboxPortadas.Load("https://www.carsaludable.com.ar/wp-content/uploads/2014/03/default-placeholder.png");
                }
                catch (Exception)
                {
                    MessageBox.Show("El problema es al cargar la imagen placeholder.", "Error");
                }
            }
        }

        private void OcultarColumnas()
        {
            dgvDiscos.Columns["Portada"].Visible = false;
            dgvDiscos.Columns["ID"].Visible = false;
        }

        private void dgvDiscos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDiscos.CurrentRow != null)
            {
                Disco discoSeleccionado = (Disco) dgvDiscos.CurrentRow.DataBoundItem;
                CargarImagen(discoSeleccionado.Portada);
            }
        }
        private void dgvDiscos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvDiscos.Columns[e.ColumnIndex].Name == "FechaLanzamiento" && e.Value is DateTime)
            {
                dgvDiscos.Columns[e.ColumnIndex].DefaultCellStyle.Format = "dd/MM/yyyy";
            }
        }

        private void btnAgregarDisco_Click(object sender, EventArgs e)
        {
            frmPlantillaDisco plantillaDisco = new frmPlantillaDisco();
            plantillaDisco.ShowDialog();
            CargarGrilla();
            ActualizarResultados();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                Disco discoSeleccionado = (Disco) dgvDiscos.CurrentRow.DataBoundItem;
                frmPlantillaDisco plantillaDisco = new frmPlantillaDisco(discoSeleccionado);
                plantillaDisco.ShowDialog();
                CargarGrilla();
                ActualizarResultados();
            }
            catch (NullReferenceException) 
            { 
                MessageBox.Show("No hay ningún disco seleccionado", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo modificar el disco seleccionado", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBorrarDisco_Click(object sender, EventArgs e)
        {
            Disco discoSeleccionado = (Disco)dgvDiscos.CurrentRow.DataBoundItem;

            DialogResult respuesta = MessageBox.Show("¿Desea usted eliminar el siguiente disco?\n" + 
                                                     $"{discoSeleccionado}", "Advertencia", 
                                                     MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (respuesta == DialogResult.Yes)
            {
                DiscoNegocio discoNegocio = new DiscoNegocio();
                try
                {
                    discoNegocio.BorrarDisco(discoSeleccionado.Id);
                    CargarGrilla();
                    ActualizarResultados();
                    MessageBox.Show("¡Disco borrado con éxito!", "Modificación disco", 
                                    MessageBoxButtons.OK);
                }
                catch (Exception)
                {
                    MessageBox.Show("No se pudo borrar el disco seleccionado", "Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            List<Disco> discosFiltrados;
            string filtro = txboxBuscar.Text;

            if (rbtnTitulo.Checked)
            {
                discosFiltrados = discos.FindAll(d => d.Titulo.ToUpper().Contains(filtro.ToUpper()));
            }
            else if (rbtnEstilo.Checked)
            {
                discosFiltrados = discos.FindAll(d => d.Estilo.Descripcion.ToUpper().Contains(filtro.ToUpper()));
            }
            else if (rbtnEdicion.Checked)
            {
                discosFiltrados = discos.FindAll(d => d.Edicion.Descripcion.ToUpper().Contains(filtro.ToUpper()));
            }
            else
            {
                discosFiltrados = discos;
            }

            if (discosFiltrados != null)
            {
                dgvDiscos.DataSource = typeof(Disco);
                dgvDiscos.DataSource = discosFiltrados;
                OcultarColumnas();
                ActualizarGrilla(discosFiltrados);
                ActualizarResultados();
            }
        }

        private void txboxBuscar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnBuscar_Click(sender, e);
            }
        }

        private void txboxBuscar_TextChanged(object sender, EventArgs e)
        {
            if (txboxBuscar.Text == "")
            {
                ActualizarGrilla(discos);
                ActualizarResultados();
            }
        }
    }
}
