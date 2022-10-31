
namespace pry_Agenda
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txbTelefono = new System.Windows.Forms.TextBox();
            this.txbNombre = new System.Windows.Forms.TextBox();
            this.lstContactos = new System.Windows.Forms.ListBox();
            this.txbNombreBuscar = new System.Windows.Forms.TextBox();
            this.txbTelefonoBuscar = new System.Windows.Forms.TextBox();
            this.lblTelefonoBuscar = new System.Windows.Forms.Label();
            this.lblNombreBuscar = new System.Windows.Forms.Label();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblCapacidad = new System.Windows.Forms.Label();
            this.lblContactosDisponibles = new System.Windows.Forms.Label();
            this.lblContacto_s = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblMas56 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDatosdecontacto
            // 
            this.lblDatosdecontacto.AutoSize = true;
            this.lblDatosdecontacto.Location = new System.Drawing.Point(162, 446);
            this.lblDatosdecontacto.Name = "lblDatosdecontacto";
            this.lblDatosdecontacto.Size = new System.Drawing.Size(90, 13);
            this.lblDatosdecontacto.TabIndex = 0;
            this.lblDatosdecontacto.Text = "Agregar Contacto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 474);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 498);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "N° Telefónico";
            // 
            // txbTelefono
            // 
            this.txbTelefono.Location = new System.Drawing.Point(131, 495);
            this.txbTelefono.Name = "txbTelefono";
            this.txbTelefono.Size = new System.Drawing.Size(172, 20);
            this.txbTelefono.TabIndex = 3;
            // 
            // txbNombre
            // 
            this.txbNombre.Location = new System.Drawing.Point(103, 471);
            this.txbNombre.Name = "txbNombre";
            this.txbNombre.Size = new System.Drawing.Size(200, 20);
            this.txbNombre.TabIndex = 4;
            // 
            // lstContactos
            // 
            this.lstContactos.FormattingEnabled = true;
            this.lstContactos.Location = new System.Drawing.Point(15, 94);
            this.lstContactos.Name = "lstContactos";
            this.lstContactos.Size = new System.Drawing.Size(369, 303);
            this.lstContactos.TabIndex = 5;
            // 
            // txbNombreBuscar
            // 
            this.txbNombreBuscar.Location = new System.Drawing.Point(101, 34);
            this.txbNombreBuscar.Name = "txbNombreBuscar";
            this.txbNombreBuscar.Size = new System.Drawing.Size(200, 20);
            this.txbNombreBuscar.TabIndex = 10;
            // 
            // txbTelefonoBuscar
            // 
            this.txbTelefonoBuscar.Location = new System.Drawing.Point(131, 58);
            this.txbTelefonoBuscar.Name = "txbTelefonoBuscar";
            this.txbTelefonoBuscar.Size = new System.Drawing.Size(170, 20);
            this.txbTelefonoBuscar.TabIndex = 9;
            // 
            // lblTelefonoBuscar
            // 
            this.lblTelefonoBuscar.AutoSize = true;
            this.lblTelefonoBuscar.Location = new System.Drawing.Point(22, 61);
            this.lblTelefonoBuscar.Name = "lblTelefonoBuscar";
            this.lblTelefonoBuscar.Size = new System.Drawing.Size(72, 13);
            this.lblTelefonoBuscar.TabIndex = 8;
            this.lblTelefonoBuscar.Text = "N° Telefónico";
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
            this.btnBuscar.Size = new System.Drawing.Size(75, 44);
            this.btnBuscar.TabIndex = 11;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(309, 471);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 44);
            this.btnAgregar.TabIndex = 12;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // lblCapacidad
            // 
            this.lblCapacidad.AutoSize = true;
            this.lblCapacidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCapacidad.Location = new System.Drawing.Point(191, 539);
            this.lblCapacidad.Name = "lblCapacidad";
            this.lblCapacidad.Size = new System.Drawing.Size(98, 13);
            this.lblCapacidad.TabIndex = 13;
            this.lblCapacidad.Text = "Espacio disponible:";
            // 
            // lblContactosDisponibles
            // 
            this.lblContactosDisponibles.AutoSize = true;
            this.lblContactosDisponibles.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContactosDisponibles.Location = new System.Drawing.Point(295, 539);
            this.lblContactosDisponibles.Name = "lblContactosDisponibles";
            this.lblContactosDisponibles.Size = new System.Drawing.Size(30, 13);
            this.lblContactosDisponibles.TabIndex = 14;
            this.lblContactosDisponibles.Text = "0/32";
            // 
            // lblContacto_s
            // 
            this.lblContacto_s.AutoSize = true;
            this.lblContacto_s.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContacto_s.Location = new System.Drawing.Point(329, 539);
            this.lblContacto_s.Name = "lblContacto_s";
            this.lblContacto_s.Size = new System.Drawing.Size(55, 13);
            this.lblContacto_s.TabIndex = 15;
            this.lblContacto_s.Text = "Contactos";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(234, 403);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(150, 20);
            this.btnEliminar.TabIndex = 16;
            this.btnEliminar.Text = "Eliminar Contacto";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // lblMas56
            // 
            this.lblMas56.AutoSize = true;
            this.lblMas56.Location = new System.Drawing.Point(100, 61);
            this.lblMas56.Name = "lblMas56";
            this.lblMas56.Size = new System.Drawing.Size(25, 13);
            this.lblMas56.TabIndex = 17;
            this.lblMas56.Text = "+56";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(100, 498);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "+56";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 561);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblMas56);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.lblContacto_s);
            this.Controls.Add(this.lblContactosDisponibles);
            this.Controls.Add(this.lblCapacidad);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txbNombreBuscar);
            this.Controls.Add(this.txbTelefonoBuscar);
            this.Controls.Add(this.lblTelefonoBuscar);
            this.Controls.Add(this.lblNombreBuscar);
            this.Controls.Add(this.lblBuscar);
            this.Controls.Add(this.lstContactos);
            this.Controls.Add(this.txbNombre);
            this.Controls.Add(this.txbTelefono);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDatosdecontacto);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDatosdecontacto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbTelefono;
        private System.Windows.Forms.TextBox txbNombre;
        private System.Windows.Forms.ListBox lstContactos;
        private System.Windows.Forms.TextBox txbNombreBuscar;
        private System.Windows.Forms.TextBox txbTelefonoBuscar;
        private System.Windows.Forms.Label lblTelefonoBuscar;
        private System.Windows.Forms.Label lblNombreBuscar;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblCapacidad;
        private System.Windows.Forms.Label lblContactosDisponibles;
        private System.Windows.Forms.Label lblContacto_s;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblMas56;
        private System.Windows.Forms.Label label3;
    }
}

