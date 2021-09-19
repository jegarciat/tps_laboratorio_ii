using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiCalculadora
{
    public partial class FormCalculadora : Form
    {
        public FormCalculadora()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Carga el combo box con los operadores.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormCalculadora_Load(object sender, EventArgs e)
        {
            this.cmbOperador.Items.Add("+");
            this.cmbOperador.Items.Add("-");
            this.cmbOperador.Items.Add("/");
            this.cmbOperador.Items.Add("*");

            Limpiar();
        }

        /// <summary>
        /// Llama al método Operar de la clase Calculadora.
        /// </summary>
        /// <param name="numero1"></param>
        /// <param name="numero2"></param>
        /// <param name="operador"></param>
        /// <returns>Resultado de la operación</returns>
        private static double Operar(string numero1, string numero2, string operador)
        {
            Operando operando1 = new Operando(numero1);
            Operando operando2 = new Operando(numero2);
            char.TryParse(operador, out char operadorAux);

            return Calculadora.Operar(operando1, operando2, operadorAux);
        }

        /// <summary>
        /// Llama al método Operar de esta clase y muestra el resultado en el lblResultado y en el listBox si es una operación válida.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOperar_Click(object sender, EventArgs e)
        {
            string numeroString1 = this.txtNumero1.Text;
            string numeroString2 = this.txtNumero2.Text;
            string operador = this.cmbOperador.Text;

            if (!string.IsNullOrWhiteSpace(numeroString1) && !string.IsNullOrWhiteSpace(numeroString2) && !string.IsNullOrWhiteSpace(operador)
                && double.TryParse(numeroString1, out double numero1) && double.TryParse(numeroString2, out double numero2))
            {
                double resultado = Operar(numeroString1, numeroString2, operador);

                if (resultado == double.MinValue)
                {
                    this.lblResultado.Text = "No se puede dividir entre 0";
                    this.btnConvertirABinario.Enabled = false;
                    this.btnConvertirADecimal.Enabled = false;
                    this.btnOperar.Enabled = false;
                }
                else
                {
                    this.lblResultado.Text = resultado.ToString();
                    this.lstOperaciones.Items.Add($"{numero1} {cmbOperador.Text} {numero2} = {resultado}");
                }
            }
        }

        /// <summary>
        /// Limpia los textBox, comboBox, el label y activa los botones de conversión y el de operar.
        /// </summary>
        private void Limpiar()
        {
            this.lblResultado.Text = "0";
            this.txtNumero1.Clear();
            this.txtNumero2.Clear();
            this.cmbOperador.SelectedIndex = -1;
            this.btnConvertirABinario.Enabled = true;
            this.btnConvertirADecimal.Enabled = true;
            this.btnOperar.Enabled = true;
        }

        /// <summary>
        /// Llama al método limpiar.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        /// <summary>
        /// Le pregunta al usuario con un MessageBox si quiere salir o no. En caso afirmativo cierra el formulario.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Seguro de querer salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        /// <summary>
        /// Convierte de ser posible un número decimal a un número binario y lo muestra en el label y en el listBox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {
            Operando numDecimal;
            string resultadoBin;

            if (lblResultado.Text != "0")
            {
                numDecimal = new Operando();
                resultadoBin = numDecimal.DecimalBinario(lblResultado.Text);
                lblResultado.Text = resultadoBin;

                if (resultadoBin != "Valor inválido")
                {
                    this.lstOperaciones.Items.Add($"Resultado en binario: {resultadoBin}");
                }
                else
                {
                    this.btnConvertirABinario.Enabled = false;
                    this.btnConvertirADecimal.Enabled = false;
                    this.btnOperar.Enabled = false;
                }
            }
        }

        /// <summary>
        /// Convierte de ser posible un número binario a un número decimal y lo muestra en el label y en el listBox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {
            Operando binario;
            string resultadoDecimal;

            if (lblResultado.Text != "0")
            {
                binario = new Operando();
                resultadoDecimal = binario.BinarioDecimal(lblResultado.Text);
                lblResultado.Text = resultadoDecimal;

                if (resultadoDecimal != "Valor inválido")
                {
                    this.lstOperaciones.Items.Add($"Resultado en decimal: {resultadoDecimal}");
                }
                else
                {
                    this.btnConvertirABinario.Enabled = false;
                    this.btnConvertirADecimal.Enabled = false;
                    this.btnOperar.Enabled = false;
                }
            }
        }

    }
}
