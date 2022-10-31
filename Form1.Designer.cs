
namespace pry_Agenda
{
    partial class frmSulaco
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblDatosdecontacto = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblNumero_Telefonico = new System.Windows.Forms.Label();
            this.txbTelefono = new System.Windows.Forms.TextBox();
            this.txbNombre = new System.Windows.Forms.TextBox();
            this.lstContactos = new System.Windows.Forms.ListBox();
            this.txbNombreBuscar = new System.Windows.Forms.TextBox();
            this.lblNombreBuscar = new System.Windows.Forms.Label();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblCapacidad = new System.Windows.Forms.Label();
            this.lblContacto_s = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lbl56 = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDatosdecontacto
            // 
            this.lblDatosdecontacto.AutoSize = true;
            this.lblDatosdecontacto.Location = new System.Drawing.Point(162, 308);
            this.lblDatosdecontacto.Name = "lblDatosdecontacto";
            this.lblDatosdecontacto.Size = new System.Drawing.Size(90, 13);
            this.lblDatosdecontacto.TabIndex = 0;
            this.lblDatosdecontacto.Text = "Agregar Contacto";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(24, 336);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre";
            // 
            // lblNumero_Telefonico
            // 
            this.lblNumero_Telefonico.AutoSize = true;
            this.lblNumero_Telefonico.Location = new System.Drawing.Point(24, 360);
            this.lblNumero_Telefonico.Name = "lblNumero_Telefonico";
            this.lblNumero_Telefonico.Size = new System.Drawing.Size(72, 13);
            this.lblNumero_Telefonico.TabIndex = 2;
            this.lblNumero_Telefonico.Text = "N° Telefónico";
            // 
            // txbTelefono
            // 
            this.txbTelefono.Location = new System.Drawing.Point(131, 357);
            this.txbTelefono.Name = "txbTelefono";
            this.txbTelefono.Size = new System.Drawing.Size(172, 20);
            this.txbTelefono.TabIndex = 6;
            // 
            // txbNombre
            // 
            this.txbNombre.Location = new System.Drawing.Point(103, 333);
            this.txbNombre.Name = "txbNombre";
            this.txbNombre.Size = new System.Drawing.Size(200, 20);
            this.txbNombre.TabIndex = 5;
            // 
            // lstContactos
            // 
            this.lstContactos.ColumnWidth = 10;
            this.lstContactos.FormattingEnabled = true;
            this.lstContactos.Location = new System.Drawing.Point(15, 68);
            this.lstContactos.Name = "lstContactos";
            this.lstContactos.Size = new System.Drawing.Size(369, 186);
            this.lstContactos.Sorted = true;
            this.lstContactos.TabIndex = 3;
            // 
            // txbNombreBuscar
            // 
            this.txbNombreBuscar.Location = new System.Drawing.Point(101, 34);
            this.txbNombreBuscar.Name = "txbNombreBuscar";
            this.txbNombreBuscar.Size = new System.Drawing.Size(200, 20);
            this.txbNombreBuscar.TabIndex = 0;
            // 
            // lblNombreBuscar
            // 
            this.lblNombreBuscar.AutoSize = true;
            this.lblNombreBuscar.Location = new System.Drawing.Point(22, 37);
            this.lblNombreBuscar.Name = "lblNombreBuscar";
            this.lblNombreBuscar.Size = new System.Drawing.Size(44, 13);
            this.lblNombreBuscar.TabIndex = 7;
            this.lblNombreBuscar.Text = "Nombre";
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Location = new System.Drawing.Point(160, 9);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(86, 13);
            this.lblBuscar.TabIndex = 6;
            this.lblBuscar.Text = "Buscar Contacto";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(309, 34);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 20);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(309, 333);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 44);
            this.btnAgregar.TabIndex = 7;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblCapacidad
            // 
            this.lblCapacidad.AutoSize = true;
            this.lblCapacidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCapacidad.Location = new System.Drawing.Point(191, 401);
            this.lblCapacidad.Name = "lblCapacidad";
            this.lblCapacidad.Size = new System.Drawing.Size(98, 13);
            this.lblCapacidad.TabIndex = 13;
            this.lblCapacidad.Text = "Espacio disponible:";
            // 
            // lblContacto_s
            // 
            this.lblContacto_s.AutoSize = true;
            this.lblContacto_s.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContacto_s.Location = new System.Drawing.Point(314, 401);
            this.lblContacto_s.Name = "lblContacto_s";
            this.lblContacto_s.Size = new System.Drawing.Size(55, 13);
            this.lblContacto_s.TabIndex = 15;
            this.lblContacto_s.Text = "Contactos";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(194, 265);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(190, 20);
            this.btnEliminar.TabIndex = 4;
            this.btnEliminar.Text = "Eliminar contacto seleccionado";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // lbl56
            // 
            this.lbl56.AutoSize = true;
            this.lbl56.Location = new System.Drawing.Point(100, 360);
            this.lbl56.Name = "lbl56";
            this.lbl56.Size = new System.Drawing.Size(25, 13);
            this.lbl56.TabIndex = 18;
            this.lbl56.Text = "+56";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.Location = new System.Drawing.Point(295, 401);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(19, 13);
            this.lblCantidad.TabIndex = 19;
            this.lblCantidad.Text = "32";
            this.lblCantidad.Click += new System.EventHandler(this.lblCantidad_Click);
            // 
            // frmSulaco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 431);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.lbl56);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.lblContacto_s);
            this.Controls.Add(this.lblCapacidad);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txbNombreBuscar);
            this.Controls.Add(this.lblNombreBuscar);
            this.Controls.Add(this.lblBuscar);
            this.Controls.Add(this.lstContactos);
            this.Controls.Add(this.txbNombre);
            this.Controls.Add(this.txbTelefono);
            this.Controls.Add(this.lblNumero_Telefonico);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblDatosdecontacto);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "frmSulaco";
            this.Text = "Agenda SULACO ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDatosdecontacto;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblNumero_Telefonico;
        private System.Windows.Forms.TextBox txbTelefono;
        private System.Windows.Forms.TextBox txbNombre;
        private System.Windows.Forms.ListBox lstContactos;
        private System.Windows.Forms.TextBox txbNombreBuscar;
        private System.Windows.Forms.Label lblNombreBuscar;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblCapacidad;
        private System.Windows.Forms.Label lblContacto_s;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lbl56;
        private System.Windows.Forms.Label lblCantidad;
    }
}

