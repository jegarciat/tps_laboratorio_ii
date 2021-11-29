using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace SegurosUI
{
    public partial class FrmEstadisticas : Form
    {
        private TXT manejadorTexto;
        private Calculos calculos;
        private static int numero;

        public FrmEstadisticas()
        {
            InitializeComponent();
            manejadorTexto = new TXT();
            calculos = new Calculos();
            opgRegistros.InitialDirectory = AppDomain.CurrentDomain.BaseDirectory;
            opgRegistros.FileName = $"RegistroEstadistico_{numero}_{DateTime.Now.ToString("HH:mm:ss")}.txt";
            opgRegistros.Filter = "Archivo de texto|*.txt";
            this.rtxtContenido.Text = calculos.Informacion();
        }

        private void btnImportar_Click(object sender, EventArgs e)
        {
            if (opgRegistros.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    this.rtxtContenido.Text = manejadorTexto.Importar(opgRegistros.FileName);
                }
                catch (ArchivoException ex)
                {
                    MessageBox.Show(ex.Message, "Error al importar el archivo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            try
            {
                string archivo = $"RegistroEstadistico_{numero}_{DateTime.Now.ToString("fffff")}.txt";                

                if (manejadorTexto.Exportar(archivo, this.rtxtContenido.Text))
                {
                    numero++;
                    MessageBox.Show("Análisis exportado exitosamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (ArchivoException ex)
            {
                MessageBox.Show(ex.Message, "Error al exportar el archivo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
