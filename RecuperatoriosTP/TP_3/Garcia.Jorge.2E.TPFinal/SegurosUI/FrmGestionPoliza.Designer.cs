
namespace SegurosUI
{
    partial class FrmGestionPoliza
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGestionPoliza));
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptarAgregar = new System.Windows.Forms.Button();
            this.lblDNI = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblEdad = new System.Windows.Forms.Label();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.lblSexo = new System.Windows.Forms.Label();
            this.cmbSexo = new System.Windows.Forms.ComboBox();
            this.cmbSeguro = new System.Windows.Forms.ComboBox();
            this.lblSeguro = new System.Windows.Forms.Label();
            this.lblSumaAsegurada = new System.Windows.Forms.Label();
            this.txtSumaAsegurada = new System.Windows.Forms.TextBox();
            this.grpDatos = new System.Windows.Forms.GroupBox();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.txtAnio = new System.Windows.Forms.TextBox();
            this.lblAnio = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.chkEsFumador = new System.Windows.Forms.CheckBox();
            this.btnAceptarEdit = new System.Windows.Forms.Button();
            this.grpDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCancelar.Location = new System.Drawing.Point(12, 358);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 36);
            this.btnCancelar.TabIndex = 26;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptarAgregar
            // 
            this.btnAceptarAgregar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAceptarAgregar.Location = new System.Drawing.Point(279, 358);
            this.btnAceptarAgregar.Name = "btnAceptarAgregar";
            this.btnAceptarAgregar.Size = new System.Drawing.Size(75, 36);
            this.btnAceptarAgregar.TabIndex = 25;
            this.btnAceptarAgregar.Text = "Aceptar";
            this.btnAceptarAgregar.UseVisualStyleBackColor = true;
            this.btnAceptarAgregar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDNI.Location = new System.Drawing.Point(7, 101);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(30, 17);
            this.lblDNI.TabIndex = 32;
            this.lblDNI.Text = "DNI";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblApellido.Location = new System.Drawing.Point(7, 68);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(56, 17);
            this.lblApellido.TabIndex = 31;
            this.lblApellido.Text = "Apellido";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNombre.Location = new System.Drawing.Point(7, 35);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(57, 17);
            this.lblNombre.TabIndex = 30;
            this.lblNombre.Text = "Nombre";
            // 
            // txtApellido
            // 
            this.txtApellido.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtApellido.Location = new System.Drawing.Point(119, 66);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(202, 22);
            this.txtApellido.TabIndex = 29;
            // 
            // txtDni
            // 
            this.txtDni.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDni.Location = new System.Drawing.Point(119, 99);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(202, 22);
            this.txtDni.TabIndex = 28;
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNombre.Location = new System.Drawing.Point(119, 33);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(202, 22);
            this.txtNombre.TabIndex = 27;
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEdad.Location = new System.Drawing.Point(7, 133);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(38, 17);
            this.lblEdad.TabIndex = 34;
            this.lblEdad.Text = "Edad";
            // 
            // txtEdad
            // 
            this.txtEdad.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEdad.Location = new System.Drawing.Point(119, 130);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(202, 22);
            this.txtEdad.TabIndex = 33;
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSexo.Location = new System.Drawing.Point(7, 164);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(36, 17);
            this.lblSexo.TabIndex = 36;
            this.lblSexo.Text = "Sexo";
            // 
            // cmbSexo
            // 
            this.cmbSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSexo.FormattingEnabled = true;
            this.cmbSexo.Location = new System.Drawing.Point(119, 162);
            this.cmbSexo.Name = "cmbSexo";
            this.cmbSexo.Size = new System.Drawing.Size(202, 25);
            this.cmbSexo.TabIndex = 37;
            // 
            // cmbSeguro
            // 
            this.cmbSeguro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSeguro.FormattingEnabled = true;
            this.cmbSeguro.Location = new System.Drawing.Point(119, 195);
            this.cmbSeguro.Name = "cmbSeguro";
            this.cmbSeguro.Size = new System.Drawing.Size(202, 25);
            this.cmbSeguro.TabIndex = 39;
            this.cmbSeguro.TextChanged += new System.EventHandler(this.cmbSeguro_TextChanged);
            // 
            // lblSeguro
            // 
            this.lblSeguro.AutoSize = true;
            this.lblSeguro.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSeguro.Location = new System.Drawing.Point(7, 197);
            this.lblSeguro.Name = "lblSeguro";
            this.lblSeguro.Size = new System.Drawing.Size(50, 17);
            this.lblSeguro.TabIndex = 38;
            this.lblSeguro.Text = "Seguro";
            // 
            // lblSumaAsegurada
            // 
            this.lblSumaAsegurada.AutoSize = true;
            this.lblSumaAsegurada.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSumaAsegurada.Location = new System.Drawing.Point(7, 230);
            this.lblSumaAsegurada.Name = "lblSumaAsegurada";
            this.lblSumaAsegurada.Size = new System.Drawing.Size(106, 17);
            this.lblSumaAsegurada.TabIndex = 41;
            this.lblSumaAsegurada.Text = "Suma asegurada";
            // 
            // txtSumaAsegurada
            // 
            this.txtSumaAsegurada.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSumaAsegurada.Location = new System.Drawing.Point(119, 228);
            this.txtSumaAsegurada.Name = "txtSumaAsegurada";
            this.txtSumaAsegurada.Size = new System.Drawing.Size(202, 22);
            this.txtSumaAsegurada.TabIndex = 40;
            // 
            // grpDatos
            // 
            this.grpDatos.BackColor = System.Drawing.Color.AliceBlue;
            this.grpDatos.Controls.Add(this.cmbTipo);
            this.grpDatos.Controls.Add(this.txtAnio);
            this.grpDatos.Controls.Add(this.lblAnio);
            this.grpDatos.Controls.Add(this.lblTipo);
            this.grpDatos.Controls.Add(this.chkEsFumador);
            this.grpDatos.Controls.Add(this.lblNombre);
            this.grpDatos.Controls.Add(this.lblSumaAsegurada);
            this.grpDatos.Controls.Add(this.txtNombre);
            this.grpDatos.Controls.Add(this.txtSumaAsegurada);
            this.grpDatos.Controls.Add(this.txtDni);
            this.grpDatos.Controls.Add(this.cmbSeguro);
            this.grpDatos.Controls.Add(this.txtApellido);
            this.grpDatos.Controls.Add(this.lblSeguro);
            this.grpDatos.Controls.Add(this.lblApellido);
            this.grpDatos.Controls.Add(this.cmbSexo);
            this.grpDatos.Controls.Add(this.lblDNI);
            this.grpDatos.Controls.Add(this.lblSexo);
            this.grpDatos.Controls.Add(this.txtEdad);
            this.grpDatos.Controls.Add(this.lblEdad);
            this.grpDatos.Location = new System.Drawing.Point(12, 14);
            this.grpDatos.Name = "grpDatos";
            this.grpDatos.Size = new System.Drawing.Size(341, 338);
            this.grpDatos.TabIndex = 42;
            this.grpDatos.TabStop = false;
            this.grpDatos.Text = "Agregar póliza";
            // 
            // cmbTipo
            // 
            this.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Location = new System.Drawing.Point(119, 261);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(202, 25);
            this.cmbTipo.TabIndex = 46;
            // 
            // txtAnio
            // 
            this.txtAnio.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtAnio.Location = new System.Drawing.Point(117, 295);
            this.txtAnio.Name = "txtAnio";
            this.txtAnio.Size = new System.Drawing.Size(204, 22);
            this.txtAnio.TabIndex = 45;
            // 
            // lblAnio
            // 
            this.lblAnio.AutoSize = true;
            this.lblAnio.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAnio.Location = new System.Drawing.Point(7, 297);
            this.lblAnio.Name = "lblAnio";
            this.lblAnio.Size = new System.Drawing.Size(104, 17);
            this.lblAnio.TabIndex = 44;
            this.lblAnio.Text = "Año del vehiculo";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTipo.Location = new System.Drawing.Point(8, 264);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(104, 17);
            this.lblTipo.TabIndex = 43;
            this.lblTipo.Text = "Tipo de vehiculo";
            // 
            // chkEsFumador
            // 
            this.chkEsFumador.AutoSize = true;
            this.chkEsFumador.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chkEsFumador.Location = new System.Drawing.Point(119, 263);
            this.chkEsFumador.Name = "chkEsFumador";
            this.chkEsFumador.Size = new System.Drawing.Size(106, 21);
            this.chkEsFumador.TabIndex = 42;
            this.chkEsFumador.Text = "¿Es fumador?";
            this.chkEsFumador.UseVisualStyleBackColor = true;
            // 
            // btnAceptarEdit
            // 
            this.btnAceptarEdit.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAceptarEdit.Location = new System.Drawing.Point(278, 358);
            this.btnAceptarEdit.Name = "btnAceptarEdit";
            this.btnAceptarEdit.Size = new System.Drawing.Size(75, 36);
            this.btnAceptarEdit.TabIndex = 43;
            this.btnAceptarEdit.Text = "Aceptar";
            this.btnAceptarEdit.UseVisualStyleBackColor = true;
            this.btnAceptarEdit.Click += new System.EventHandler(this.btnAceptarEdit_Click);
            // 
            // FrmGestionPoliza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(366, 405);
            this.Controls.Add(this.btnAceptarEdit);
            this.Controls.Add(this.grpDatos);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptarAgregar);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmGestionPoliza";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión de póliza";
            this.Load += new System.EventHandler(this.FrmGestionPoliza_Load);
            this.grpDatos.ResumeLayout(false);
            this.grpDatos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptarAgregar;
        public System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.TextBox txtNombre;
        public System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.TextBox txtEdad;
        public System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.ComboBox cmbSexo;
        private System.Windows.Forms.ComboBox cmbSeguro;
        public System.Windows.Forms.Label lblSeguro;
        public System.Windows.Forms.Label lblSumaAsegurada;
        private System.Windows.Forms.TextBox txtSumaAsegurada;
        private System.Windows.Forms.GroupBox grpDatos;
        private System.Windows.Forms.Label lblAnio;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.CheckBox chkEsFumador;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.TextBox txtAnio;
        private System.Windows.Forms.Button btnAceptarEdit;
    }
}