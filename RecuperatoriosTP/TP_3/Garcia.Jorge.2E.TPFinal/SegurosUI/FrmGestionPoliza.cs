using Entidades;
using System;
using System.Windows.Forms;

namespace SegurosUI
{
    public partial class FrmGestionPoliza : Form
    {
        private Poliza poliza;
        private PolizaVehiculo polizaVehiculo;
        private PolizaVida polizaVida;
        private bool esModificacion;

        public FrmGestionPoliza()
        {
            InitializeComponent();
        }

        public FrmGestionPoliza(Poliza poliza) : this()
        {
            this.poliza = poliza;
        }

        private void FrmGestionPoliza_Load(object sender, EventArgs e)
        {
            if (poliza is null)
            {
                ConfigurarControlesAgregar();
                cmbTipo.DataSource = Enum.GetValues(typeof(ETipo));
            }
            else
            {
                esModificacion = true;
                ConfigurarParaModificar();
            }
        }

        private void ConfigurarParaVehiculo()
        {
            lblTipo.Visible = true;
            cmbTipo.Visible = true;
            txtAnio.Visible = true;
            lblAnio.Visible = true;
            chkEsFumador.Visible = false;
        }
        
        private void ConfigurarParaVida()
        {
            lblTipo.Visible = false;
            cmbTipo.Visible = false;
            txtAnio.Visible = false;
            lblAnio.Visible = false;
            cmbTipo.Visible = false;
            chkEsFumador.Visible = true;
        }

        private void ConfigurarControlesAgregar()
        {
            btnAceptarEdit.Visible = false;
            lblTipo.Visible = false;
            cmbTipo.Visible = false;
            txtAnio.Visible = false;
            lblAnio.Visible = false;
            chkEsFumador.Visible = false;
            btnAceptarAgregar.Visible = false;
            cmbSexo.DataSource = Enum.GetValues(typeof(ESexo));
            cmbSeguro.Items.Add("Seguro para vehiculo");
            cmbSeguro.Items.Add("Seguro de vida");
        }

        private void ConfigurarParaModificar()
        {
            grpDatos.Text = "Edición de póliza";
            btnAceptarAgregar.Visible = false;
            txtDni.Enabled = false;
            cmbSexo.Enabled = false;
            cmbTipo.Enabled = false;
            cmbSeguro.Enabled = false;
            chkEsFumador.Enabled = false;

            txtNombre.Text = poliza.Nombre;
            txtApellido.Text = poliza.Apellido;
            txtDni.Text = poliza.DNI.ToString();
            txtEdad.Text = poliza.Edad.ToString();
            txtSumaAsegurada.Text = poliza.SumaAsegurada.ToString();
            cmbSexo.Items.Add(poliza.Sexo);
            cmbSexo.SelectedIndex = 0;

            if (poliza is PolizaVehiculo)
            {
                ConfigurarParaVehiculo();
                polizaVehiculo = Suscripciones.PolizasVehiculos.Find((x) => x.DNI == poliza.DNI);
                txtAnio.Text = polizaVehiculo.Anio.ToString();
                cmbTipo.Text = polizaVehiculo.TipoVehiculo.ToString();
                cmbSeguro.Items.Add("Seguro para vehiculo");
                cmbSeguro.SelectedIndex = 0;
                cmbTipo.Items.Add(polizaVehiculo.TipoVehiculo);
                cmbTipo.SelectedIndex = 0;
            }
            else
            {
                ConfigurarParaVida();
                polizaVida = Suscripciones.PolizasVida.Find((x) => x.DNI == poliza.DNI);
                chkEsFumador.Checked = polizaVida.Fumador;
                cmbSeguro.Items.Add("Seguro de vida");
                cmbSeguro.SelectedIndex = 0;
            }
        }

        private void cmbSeguro_TextChanged(object sender, EventArgs e)
        {
            if (cmbSeguro.Text == "Seguro para vehiculo")
            {
                ConfigurarParaVehiculo();
            }
            else
            {
                ConfigurarParaVida();
            }

            if (esModificacion == false)
            {
                btnAceptarAgregar.Visible = true;
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbSeguro.Text == "Seguro para vehiculo")
                {
                    PolizaVehiculo polizaNueva = new PolizaVehiculo();

                    polizaNueva.Nombre = txtNombre.Text;
                    polizaNueva.Apellido = txtApellido.Text;
                    polizaNueva.DNI = int.Parse(txtDni.Text);
                    polizaNueva.Sexo = (ESexo)cmbSexo.SelectedItem;
                    polizaNueva.Edad = int.Parse(txtEdad.Text);
                    polizaNueva.SumaAsegurada = double.Parse(txtSumaAsegurada.Text);
                    polizaNueva.Anio = int.Parse(txtAnio.Text);
                    polizaNueva.TipoVehiculo = (ETipo)cmbTipo.SelectedItem;

                    Suscripciones.PolizasVehiculos.Add(polizaNueva);
                }
                else
                {
                    PolizaVida poliza = new PolizaVida();

                    poliza.Nombre = txtNombre.Text;
                    poliza.Apellido = txtApellido.Text;
                    poliza.DNI = int.Parse(txtDni.Text);
                    poliza.Sexo = (ESexo)cmbSexo.SelectedItem;
                    poliza.Edad = int.Parse(txtEdad.Text);
                    poliza.SumaAsegurada = double.Parse(txtSumaAsegurada.Text);
                    poliza.Fumador = chkEsFumador.Checked;

                    Suscripciones.PolizasVida.Add(poliza);
                }
                
                this.DialogResult = DialogResult.OK;
            }
            catch (PolizaException ex)
            {
                MessageBox.Show(ex.Message, "Error en los datos del cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAceptarEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbSeguro.Text == "Seguro para vehiculo")
                {
                    polizaVehiculo.Nombre = txtNombre.Text;
                    polizaVehiculo.Apellido = txtApellido.Text;
                    polizaVehiculo.Edad = int.Parse(txtEdad.Text);
                    polizaVehiculo.SumaAsegurada = double.Parse(txtSumaAsegurada.Text);
                    polizaVehiculo.Anio = int.Parse(txtAnio.Text);
                }
                else
                {
                    polizaVida.Nombre = txtNombre.Text;
                    polizaVida.Apellido = txtApellido.Text;
                    polizaVida.Sexo = (ESexo)cmbSexo.SelectedItem;
                    polizaVida.Edad = int.Parse(txtEdad.Text);
                    polizaVida.SumaAsegurada = double.Parse(txtSumaAsegurada.Text);
                }

                this.DialogResult = DialogResult.OK;
            }
            catch (PolizaException ex)
            {
                MessageBox.Show(ex.Message, "Error en los datos del cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
