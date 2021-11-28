
namespace SegurosUI
{
    partial class FrmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.dgvPolizas = new System.Windows.Forms.DataGridView();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEstadisticas = new System.Windows.Forms.Button();
            this.btnListarTodos = new System.Windows.Forms.Button();
            this.btnListarVida = new System.Windows.Forms.Button();
            this.btnListarVehiculos = new System.Windows.Forms.Button();
            this.btnExportXml = new System.Windows.Forms.Button();
            this.btnExportJson = new System.Windows.Forms.Button();
            this.grpFiltros = new System.Windows.Forms.GroupBox();
            this.btnFumadores = new System.Windows.Forms.Button();
            this.btnHombresAsegurados = new System.Windows.Forms.Button();
            this.btnMoto = new System.Windows.Forms.Button();
            this.btnTodoMujeres = new System.Windows.Forms.Button();
            this.btnNoFumadores = new System.Windows.Forms.Button();
            this.btnAuto = new System.Windows.Forms.Button();
            this.lblExportar = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lbl_TituloSeguro = new System.Windows.Forms.Label();
            this.picSeguro = new System.Windows.Forms.PictureBox();
            this.lblMostrar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPolizas)).BeginInit();
            this.grpFiltros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSeguro)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPolizas
            // 
            this.dgvPolizas.AllowUserToAddRows = false;
            this.dgvPolizas.AllowUserToDeleteRows = false;
            this.dgvPolizas.AllowUserToOrderColumns = true;
            this.dgvPolizas.AllowUserToResizeColumns = false;
            this.dgvPolizas.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightBlue;
            this.dgvPolizas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPolizas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPolizas.BackgroundColor = System.Drawing.Color.White;
            this.dgvPolizas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgvPolizas.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPolizas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPolizas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPolizas.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvPolizas.Location = new System.Drawing.Point(11, 179);
            this.dgvPolizas.MultiSelect = false;
            this.dgvPolizas.Name = "dgvPolizas";
            this.dgvPolizas.ReadOnly = true;
            this.dgvPolizas.RowTemplate.Height = 25;
            this.dgvPolizas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPolizas.Size = new System.Drawing.Size(728, 254);
            this.dgvPolizas.TabIndex = 12;
            this.dgvPolizas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPolizas_CellDoubleClick);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.LimeGreen;
            this.btnAgregar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAgregar.Location = new System.Drawing.Point(12, 443);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(120, 47);
            this.btnAgregar.TabIndex = 13;
            this.btnAgregar.Text = "Agregar póliza";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.Khaki;
            this.btnModificar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnModificar.Location = new System.Drawing.Point(132, 443);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(120, 47);
            this.btnModificar.TabIndex = 14;
            this.btnModificar.Text = "Modificar póliza";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.IndianRed;
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEliminar.Location = new System.Drawing.Point(252, 443);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(120, 47);
            this.btnEliminar.TabIndex = 15;
            this.btnEliminar.Text = "Eliminar póliza";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnEstadisticas
            // 
            this.btnEstadisticas.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEstadisticas.Location = new System.Drawing.Point(12, 145);
            this.btnEstadisticas.Name = "btnEstadisticas";
            this.btnEstadisticas.Size = new System.Drawing.Size(194, 28);
            this.btnEstadisticas.TabIndex = 16;
            this.btnEstadisticas.Text = "Estadísticas";
            this.btnEstadisticas.UseVisualStyleBackColor = true;
            this.btnEstadisticas.Click += new System.EventHandler(this.btnEstadisticas_Click);
            // 
            // btnListarTodos
            // 
            this.btnListarTodos.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnListarTodos.Location = new System.Drawing.Point(11, 58);
            this.btnListarTodos.Name = "btnListarTodos";
            this.btnListarTodos.Size = new System.Drawing.Size(195, 28);
            this.btnListarTodos.TabIndex = 17;
            this.btnListarTodos.Text = "Listar todas las pólizas";
            this.btnListarTodos.UseVisualStyleBackColor = true;
            this.btnListarTodos.Click += new System.EventHandler(this.btnListarTodos_Click);
            // 
            // btnListarVida
            // 
            this.btnListarVida.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnListarVida.Location = new System.Drawing.Point(12, 87);
            this.btnListarVida.Name = "btnListarVida";
            this.btnListarVida.Size = new System.Drawing.Size(194, 28);
            this.btnListarVida.TabIndex = 18;
            this.btnListarVida.Text = "Listar pólizas de vida";
            this.btnListarVida.UseVisualStyleBackColor = true;
            this.btnListarVida.Click += new System.EventHandler(this.btn_ListarSegurosVida_Click);
            // 
            // btnListarVehiculos
            // 
            this.btnListarVehiculos.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnListarVehiculos.Location = new System.Drawing.Point(12, 116);
            this.btnListarVehiculos.Name = "btnListarVehiculos";
            this.btnListarVehiculos.Size = new System.Drawing.Size(194, 28);
            this.btnListarVehiculos.TabIndex = 19;
            this.btnListarVehiculos.Text = "Listar pólizas de vehiculos";
            this.btnListarVehiculos.UseVisualStyleBackColor = true;
            this.btnListarVehiculos.Click += new System.EventHandler(this.btnListarVehiculos_Click);
            // 
            // btnExportXml
            // 
            this.btnExportXml.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnExportXml.Location = new System.Drawing.Point(458, 461);
            this.btnExportXml.Name = "btnExportXml";
            this.btnExportXml.Size = new System.Drawing.Size(139, 23);
            this.btnExportXml.TabIndex = 20;
            this.btnExportXml.Text = "Exportar a XML";
            this.btnExportXml.UseVisualStyleBackColor = true;
            this.btnExportXml.Click += new System.EventHandler(this.btnExportXml_Click);
            // 
            // btnExportJson
            // 
            this.btnExportJson.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnExportJson.Location = new System.Drawing.Point(602, 461);
            this.btnExportJson.Name = "btnExportJson";
            this.btnExportJson.Size = new System.Drawing.Size(139, 23);
            this.btnExportJson.TabIndex = 21;
            this.btnExportJson.Text = "Exportar a JSON";
            this.btnExportJson.UseVisualStyleBackColor = true;
            this.btnExportJson.Click += new System.EventHandler(this.btnExportJson_Click);
            // 
            // grpFiltros
            // 
            this.grpFiltros.Controls.Add(this.btnFumadores);
            this.grpFiltros.Controls.Add(this.btnHombresAsegurados);
            this.grpFiltros.Controls.Add(this.btnMoto);
            this.grpFiltros.Controls.Add(this.btnTodoMujeres);
            this.grpFiltros.Controls.Add(this.btnNoFumadores);
            this.grpFiltros.Controls.Add(this.btnAuto);
            this.grpFiltros.Font = new System.Drawing.Font("Segoe UI", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.grpFiltros.Location = new System.Drawing.Point(212, 33);
            this.grpFiltros.Name = "grpFiltros";
            this.grpFiltros.Size = new System.Drawing.Size(527, 140);
            this.grpFiltros.TabIndex = 22;
            this.grpFiltros.TabStop = false;
            this.grpFiltros.Text = "Filtros";
            // 
            // btnFumadores
            // 
            this.btnFumadores.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnFumadores.Location = new System.Drawing.Point(270, 32);
            this.btnFumadores.Name = "btnFumadores";
            this.btnFumadores.Size = new System.Drawing.Size(240, 28);
            this.btnFumadores.TabIndex = 27;
            this.btnFumadores.Text = "Fumadores asegurados";
            this.btnFumadores.UseVisualStyleBackColor = true;
            this.btnFumadores.Click += new System.EventHandler(this.btnFumadores_Click);
            // 
            // btnHombresAsegurados
            // 
            this.btnHombresAsegurados.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnHombresAsegurados.Location = new System.Drawing.Point(24, 66);
            this.btnHombresAsegurados.Name = "btnHombresAsegurados";
            this.btnHombresAsegurados.Size = new System.Drawing.Size(240, 28);
            this.btnHombresAsegurados.TabIndex = 26;
            this.btnHombresAsegurados.Text = "Hombres asegurados";
            this.btnHombresAsegurados.UseVisualStyleBackColor = true;
            this.btnHombresAsegurados.Click += new System.EventHandler(this.btnHombresAsegurados_Click);
            // 
            // btnMoto
            // 
            this.btnMoto.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMoto.Location = new System.Drawing.Point(270, 100);
            this.btnMoto.Name = "btnMoto";
            this.btnMoto.Size = new System.Drawing.Size(240, 28);
            this.btnMoto.TabIndex = 33;
            this.btnMoto.Text = "Pólizas de moto";
            this.btnMoto.UseVisualStyleBackColor = true;
            this.btnMoto.Click += new System.EventHandler(this.btnMoto_Click);
            // 
            // btnTodoMujeres
            // 
            this.btnTodoMujeres.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTodoMujeres.Location = new System.Drawing.Point(24, 32);
            this.btnTodoMujeres.Name = "btnTodoMujeres";
            this.btnTodoMujeres.Size = new System.Drawing.Size(240, 28);
            this.btnTodoMujeres.TabIndex = 25;
            this.btnTodoMujeres.Text = "Mujeres aseguradas";
            this.btnTodoMujeres.UseVisualStyleBackColor = true;
            this.btnTodoMujeres.Click += new System.EventHandler(this.btnTodoMujeres_Click);
            // 
            // btnNoFumadores
            // 
            this.btnNoFumadores.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnNoFumadores.Location = new System.Drawing.Point(270, 66);
            this.btnNoFumadores.Name = "btnNoFumadores";
            this.btnNoFumadores.Size = new System.Drawing.Size(240, 28);
            this.btnNoFumadores.TabIndex = 28;
            this.btnNoFumadores.Text = "No fumadores";
            this.btnNoFumadores.UseVisualStyleBackColor = true;
            this.btnNoFumadores.Click += new System.EventHandler(this.btnNoFumadores_Click);
            // 
            // btnAuto
            // 
            this.btnAuto.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAuto.Location = new System.Drawing.Point(24, 100);
            this.btnAuto.Name = "btnAuto";
            this.btnAuto.Size = new System.Drawing.Size(240, 28);
            this.btnAuto.TabIndex = 32;
            this.btnAuto.Text = "Pólizas de auto";
            this.btnAuto.UseVisualStyleBackColor = true;
            this.btnAuto.Click += new System.EventHandler(this.btnAuto_Click);
            // 
            // lblExportar
            // 
            this.lblExportar.AutoSize = true;
            this.lblExportar.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblExportar.Location = new System.Drawing.Point(539, 443);
            this.lblExportar.Name = "lblExportar";
            this.lblExportar.Size = new System.Drawing.Size(115, 15);
            this.lblExportar.TabIndex = 23;
            this.lblExportar.Text = "Exportar lista actual";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.Location = new System.Drawing.Point(13, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(61, 25);
            this.lblTitulo.TabIndex = 24;
            this.lblTitulo.Text = "Titulo";
            // 
            // lbl_TituloSeguro
            // 
            this.lbl_TituloSeguro.AutoSize = true;
            this.lbl_TituloSeguro.Font = new System.Drawing.Font("Segoe UI", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbl_TituloSeguro.Location = new System.Drawing.Point(420, 9);
            this.lbl_TituloSeguro.Name = "lbl_TituloSeguro";
            this.lbl_TituloSeguro.Size = new System.Drawing.Size(107, 25);
            this.lbl_TituloSeguro.TabIndex = 25;
            this.lbl_TituloSeguro.Text = "Seguros JG";
            // 
            // picSeguro
            // 
            this.picSeguro.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picSeguro.BackgroundImage")));
            this.picSeguro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picSeguro.Location = new System.Drawing.Point(13, 12);
            this.picSeguro.Name = "picSeguro";
            this.picSeguro.Size = new System.Drawing.Size(193, 40);
            this.picSeguro.TabIndex = 26;
            this.picSeguro.TabStop = false;
            // 
            // lblMostrar
            // 
            this.lblMostrar.AutoSize = true;
            this.lblMostrar.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblMostrar.Location = new System.Drawing.Point(252, 427);
            this.lblMostrar.Name = "lblMostrar";
            this.lblMostrar.Size = new System.Drawing.Size(251, 13);
            this.lblMostrar.TabIndex = 28;
            this.lblMostrar.Text = "Para exportar una póliza hacer doble click en la fila";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Ivory;
            this.ClientSize = new System.Drawing.Size(755, 500);
            this.Controls.Add(this.lblMostrar);
            this.Controls.Add(this.picSeguro);
            this.Controls.Add(this.lbl_TituloSeguro);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblExportar);
            this.Controls.Add(this.grpFiltros);
            this.Controls.Add(this.btnExportJson);
            this.Controls.Add(this.btnExportXml);
            this.Controls.Add(this.btnListarVehiculos);
            this.Controls.Add(this.btnListarVida);
            this.Controls.Add(this.btnListarTodos);
            this.Controls.Add(this.btnEstadisticas);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dgvPolizas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seguros JG";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPolizas)).EndInit();
            this.grpFiltros.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picSeguro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPolizas;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEstadisticas;
        private System.Windows.Forms.Button btnListarTodos;
        private System.Windows.Forms.Button btnListarVida;
        private System.Windows.Forms.Button btnListarVehiculos;
        private System.Windows.Forms.Button btnExportXml;
        private System.Windows.Forms.Button btnExportJson;
        private System.Windows.Forms.GroupBox grpFiltros;
        private System.Windows.Forms.Label lblExportar;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnNoFumadores;
        private System.Windows.Forms.Button btnFumadores;
        private System.Windows.Forms.Button btnHombresAsegurados;
        private System.Windows.Forms.Button btnTodoMujeres;
        private System.Windows.Forms.Label lbl_TituloSeguro;
        private System.Windows.Forms.PictureBox picSeguro;
        private System.Windows.Forms.Button btnMoto;
        private System.Windows.Forms.Button btnAuto;
        private System.Windows.Forms.Label lblMostrar;
    }
}

