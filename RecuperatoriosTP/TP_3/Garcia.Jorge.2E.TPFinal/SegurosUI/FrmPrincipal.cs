using Entidades;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SegurosUI
{
    public partial class FrmPrincipal : Form
    {
        private static int numInforme;
        private BindingSource manejador;
        private TXT txt;
        public FrmPrincipal()
        {
            InitializeComponent();
            manejador = new BindingSource();
            txt = new TXT();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            try
            {
                Suscripciones.PolizasVehiculos = Suscripciones.CargarPolizasVehiculos();
                Suscripciones.PolizasVida = Suscripciones.CargarPolizasVida();
                dgvPolizas.DataSource = Suscripciones.TodasLasPolizas;
                manejador.DataSource = dgvPolizas.DataSource;
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
            FrmGestionPoliza frmGestion = new FrmGestionPoliza();
            if (frmGestion.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Poliza agregada exitosamente", "Cliente asegurado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvPolizas.DataSource = Suscripciones.TodasLasPolizas;
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (this.dgvPolizas.SelectedRows.Count > 0)
            {
                manejador.DataSource = null;
                manejador.DataSource = dgvPolizas.DataSource;

                FrmGestionPoliza frmGestion = new FrmGestionPoliza((Poliza)dgvPolizas.CurrentRow.DataBoundItem);

                if (frmGestion.ShowDialog() == DialogResult.OK)
                {                    
                    dgvPolizas.DataSource = manejador;
                    manejador.ResetBindings(false);
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (this.dgvPolizas.SelectedRows.Count > 0)
            {
                try
                {
                    manejador.DataSource = null;
                    manejador.DataSource = dgvPolizas.DataSource;

                    if (Suscripciones.Eliminar((Poliza)dgvPolizas.CurrentRow.DataBoundItem))
                    {
                        dgvPolizas.DataSource = manejador;
                        manejador.ResetBindings(false);
                        MessageBox.Show("Póliza eliminada. Recargue la lista para el el cambio.", "Eliminacion exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Error al tratar de eliminar la póliza", "Acción inválida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnListarTodos_Click(object sender, EventArgs e)
        {
            this.lblTitulo.Text = "TodasLasPolizas";
            ConfigurarPorListado();
            dgvPolizas.DataSource = Suscripciones.TodasLasPolizas;
        }

        private void btn_ListarSegurosVida_Click(object sender, EventArgs e)
        {
            this.lblTitulo.Text = "PolizasVida";
            ConfigurarPorListado();
            dgvPolizas.DataSource = Suscripciones.PolizasVida;
        }

        private void btnListarVehiculos_Click(object sender, EventArgs e)
        {
            this.lblTitulo.Text = "PolizasVehiculos";
            ConfigurarPorListado();
            dgvPolizas.DataSource = Suscripciones.PolizasVehiculos;
        }

        private void btnEstadisticas_Click(object sender, EventArgs e)
        {
            FrmEstadisticas frmEstadisticas = new FrmEstadisticas();
            frmEstadisticas.Show();
        }

        private void btnExportXml_Click(object sender, EventArgs e)
        {
            manejador.DataSource = null;
            manejador.DataSource = dgvPolizas.DataSource;
            string formato = $"{this.lblTitulo.Text}{numInforme}_{DateTime.Now.ToString("dd_mm_yyyy")}.xml";
            List<Poliza> polizas = new List<Poliza>();
            XML<List<Poliza>> serializador = new XML<List<Poliza>>();

            try
            {                
                for (int i = 0; i < manejador.Count; i++)
                {
                    polizas.Add((Poliza)manejador.Current);
                    manejador.MoveNext();
                }

                manejador.ResetBindings(false);

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
            manejador.DataSource = null;
            manejador.DataSource = dgvPolizas.DataSource;
            string archivo = $"{this.lblTitulo.Text}{numInforme}_{DateTime.Now.ToString("dd_mm_yyyy")}.json";
            List<Poliza> polizas = new List<Poliza>();
            JSON<List<Poliza>> serializador = new JSON<List<Poliza>>();

            try
            {
                for (int i = 0; i < manejador.Count; i++)
                {
                    polizas.Add((Poliza)manejador.Current);
                    manejador.MoveNext();
                }

                manejador.ResetBindings(false);

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

        /// <summary>
        /// Se encarga de refrescar el datagridview
        /// </summary>
        private void ConfigurarPorListado()
        {
            this.dgvPolizas.Update();
            this.dgvPolizas.Refresh();
        }

        private void btnTodoMujeres_Click(object sender, EventArgs e)
        {
            this.lblTitulo.Text = "MujeresAseguradas";
            Filtrar(Suscripciones.TodasLasPolizas, (x) => x.Sexo == ESexo.Mujer);
        }

        private void btnHombresAsegurados_Click(object sender, EventArgs e)
        {
            this.lblTitulo.Text = "HombresAsegurados";
            Filtrar(Suscripciones.TodasLasPolizas, (x) => x.Sexo == ESexo.Hombre);
        }

        private void btnFumadores_Click(object sender, EventArgs e)
        {
            this.lblTitulo.Text = "Fumadores";
            Filtrar(Suscripciones.PolizasVida, (x) => x.Fumador == true);
        }

        private void btnNoFumadores_Click(object sender, EventArgs e)
        {
            this.lblTitulo.Text = "NoFumadores";
            Filtrar(Suscripciones.PolizasVida, (x) => x.Fumador == false);
        }

        private void btnAuto_Click(object sender, EventArgs e)
        {
            this.lblTitulo.Text = "Autos";
            Filtrar(Suscripciones.PolizasVehiculos, (x) => x.TipoVehiculo == ETipo.Auto);
        }

        private void btnMoto_Click(object sender, EventArgs e)
        {
            this.lblTitulo.Text = "Motos";
            Filtrar(Suscripciones.PolizasVehiculos, (x) => x.TipoVehiculo == ETipo.Moto);
        }

        /// <summary>
        /// Funcion que filtra la lista genérica a partir del criterio pasado por parámetro y actualiza el DataGridView
        /// con la lista filtrada.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="lista"></param>
        /// <param name="predicate"></param>
        private void Filtrar<T>(List<T> lista, Predicate<T> predicate) where T: Poliza
        {
            manejador.DataSource = null;
            manejador.DataSource = lista.FindAll(predicate);
            dgvPolizas.DataSource = manejador.DataSource;
            manejador.ResetBindings(false);
        }

        private void dgvPolizas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Poliza poliza = (Poliza)dgvPolizas.CurrentRow.DataBoundItem;

            if (MessageBox.Show($"{poliza.Informacion()}\n\n ¿Desea exportar la póliza?", "Detalle de póliza", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    if (txt.Exportar($"Póliza_{poliza.Nombre}.txt", poliza.Informacion()))
                        MessageBox.Show("¡Póliza exportada con exito!", "Lista exportada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (ArchivoException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
