using Entidades;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SegurosUI
{
    public partial class FrmPrincipal : Form
    {
        private static int numInforme;

        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            try
            {
                Suscripciones.PolizasVehiculos = Suscripciones.CargarPolizasVehiculos();
                Suscripciones.PolizasVida = Suscripciones.CargarPolizasVida();
                dgvPolizas.DataSource = Suscripciones.TodasLasPolizas;
                this.btnEliminar.Enabled = false;
                this.btnModificar.Enabled = false;
                this.lblTitulo.Text = "TodasLasPolizas";
                this.lblTitulo.Visible = false;
            }
            catch (ArchivoException exception)
            {
                MessageBox.Show(exception.Message, "Error al cargar pólizas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            BindingSource manejadorDeInfo = new BindingSource();
            FrmGestionPoliza frmGestion = new FrmGestionPoliza();
            manejadorDeInfo.DataSource = dgvPolizas.DataSource;

            if (frmGestion.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Poliza agregada exitosamente", "Cliente asegurado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvPolizas.DataSource = manejadorDeInfo;
                manejadorDeInfo.ResetBindings(false);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            BindingSource manejadorDeInfo = new BindingSource();
            manejadorDeInfo.DataSource = dgvPolizas.DataSource;

            if (this.dgvPolizas.SelectedRows.Count > 0)
            {
                FrmGestionPoliza frmGestion = new FrmGestionPoliza((Poliza)dgvPolizas.CurrentRow.DataBoundItem);

                if (frmGestion.ShowDialog() == DialogResult.OK)
                {
                    dgvPolizas.DataSource = manejadorDeInfo;
                    manejadorDeInfo.ResetBindings(false);
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            BindingSource manejadorDeInfo = new BindingSource();
            manejadorDeInfo.DataSource = dgvPolizas.DataSource;

            if (this.dgvPolizas.SelectedRows.Count > 0)
            {
                try
                {
                    Suscripciones.Eliminar((Poliza)dgvPolizas.CurrentRow.DataBoundItem);
                    dgvPolizas.DataSource = manejadorDeInfo;
                    manejadorDeInfo.ResetBindings(false);
                }
                catch (Exception)
                {
                    MessageBox.Show("Error al tratar de eliminar la póliza", "Acción inválida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnListarTodos_Click(object sender, EventArgs e)
        {
            this.btnEliminar.Enabled = false;
            this.btnModificar.Enabled = false;
            this.lblTitulo.Text = "TodasLasPolizas";

            this.dgvPolizas.Update();
            this.dgvPolizas.Refresh();
            dgvPolizas.DataSource = Suscripciones.TodasLasPolizas;
        }

        private void btn_ListarSegurosVida_Click(object sender, EventArgs e)
        {
            ConfigurarPorListado();
            this.lblTitulo.Text = "PolizasVida";
            dgvPolizas.DataSource = Suscripciones.PolizasVida;
        }

        private void btnListarVehiculos_Click(object sender, EventArgs e)
        {
            ConfigurarPorListado();
            this.lblTitulo.Text = "PolizasVehiculos";
            dgvPolizas.DataSource = Suscripciones.PolizasVehiculos;
        }

        private void btnEstadisticas_Click(object sender, EventArgs e)
        {
            FrmEstadisticas frmEstadisticas = new FrmEstadisticas();
            frmEstadisticas.Show();
        }

        private void btnExportXml_Click(object sender, EventArgs e)
        {
            BindingSource manejadorDeInfo = new BindingSource();
            manejadorDeInfo.DataSource = dgvPolizas.DataSource;
            string formato = $"{this.lblTitulo.Text}{numInforme}_{DateTime.Now.ToString("dd_mm_yyyy")}.xml";
            List<Poliza> polizas = new List<Poliza>();
            XML<List<Poliza>> serializador = new XML<List<Poliza>>();

            try
            {
                for (int i = 0; i < manejadorDeInfo.Count; i++)
                {
                    polizas.Add((Poliza)manejadorDeInfo.Current);
                    manejadorDeInfo.MoveNext();
                }

                if (serializador.Exportar(formato, polizas))
                {
                    numInforme++;
                    MessageBox.Show("¡Lista exportada con exito!", "Lista exportada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (ArchivoException ex)
            {
                MessageBox.Show(ex.Message, "Error al exportar pólizas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
            }
        }

        private void btnExportJson_Click(object sender, EventArgs e)
        {
            BindingSource manejadorDeInfo = new BindingSource();
            manejadorDeInfo.DataSource = dgvPolizas.DataSource;
            string archivo = $"{this.lblTitulo.Text}{numInforme}_{DateTime.Now.ToString("dd_mm_yyyy")}.json";
            List<Poliza> polizas = new List<Poliza>();
            JSON<List<Poliza>> serializador = new JSON<List<Poliza>>();

            try
            {
                for (int i = 0; i < manejadorDeInfo.Count; i++)
                {
                    polizas.Add((Poliza)manejadorDeInfo.Current);
                    manejadorDeInfo.MoveNext();
                }

                if (serializador.Exportar(archivo, polizas))
                {
                    numInforme++;
                    MessageBox.Show("¡Lista exportada con exito!", "Lista exportada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (ArchivoException ex)
            {
                MessageBox.Show(ex.Message, "Error al exportar pólizas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
            }
        }

        private void ConfigurarPorListado()
        {
            this.dgvPolizas.Update();
            this.dgvPolizas.Refresh();
            this.btnEliminar.Enabled = true;
            this.btnModificar.Enabled = true;
        }
    }
}
