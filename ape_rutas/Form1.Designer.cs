namespace ape_rutas
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblMinutosDesdeBaseAnterior = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtMinutosDesdeBaseAnterior = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAgregarEnInicio = new System.Windows.Forms.Button();
            this.btnRecorrido = new System.Windows.Forms.Button();
            this.btnInsertarDespuesDe = new System.Windows.Forms.Button();
            this.btnReporte = new System.Windows.Forms.Button();
            this.txtReporte = new System.Windows.Forms.TextBox();
            this.txtInsertarDespuesDe = new System.Windows.Forms.TextBox();
            this.lblInsertarDespuesDe = new System.Windows.Forms.Label();
            this.dtpHoraInicio = new System.Windows.Forms.DateTimePicker();
            this.txtNombreRecorrido = new System.Windows.Forms.TextBox();
            this.lblNombreRecorrido = new System.Windows.Forms.Label();
            this.lblHoraInicio = new System.Windows.Forms.Label();
            this.lblHoraFin = new System.Windows.Forms.Label();
            this.dtpHoraFin = new System.Windows.Forms.DateTimePicker();
            this.btnEliminarPrimero = new System.Windows.Forms.Button();
            this.btnEliminarUltimo = new System.Windows.Forms.Button();
            this.txtMinAInsertar = new System.Windows.Forms.TextBox();
            this.txtBaseAInsertar = new System.Windows.Forms.TextBox();
            this.lblMinAInsertar = new System.Windows.Forms.Label();
            this.lblBaseAInsertar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(69, 19);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblMinutosDesdeBaseAnterior
            // 
            this.lblMinutosDesdeBaseAnterior.Location = new System.Drawing.Point(214, 16);
            this.lblMinutosDesdeBaseAnterior.Name = "lblMinutosDesdeBaseAnterior";
            this.lblMinutosDesdeBaseAnterior.Size = new System.Drawing.Size(118, 27);
            this.lblMinutosDesdeBaseAnterior.TabIndex = 1;
            this.lblMinutosDesdeBaseAnterior.Text = "Minutos desde la base anterior:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(72, 46);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(118, 20);
            this.txtNombre.TabIndex = 2;
            // 
            // txtMinutosDesdeBaseAnterior
            // 
            this.txtMinutosDesdeBaseAnterior.Location = new System.Drawing.Point(217, 46);
            this.txtMinutosDesdeBaseAnterior.Name = "txtMinutosDesdeBaseAnterior";
            this.txtMinutosDesdeBaseAnterior.Size = new System.Drawing.Size(107, 20);
            this.txtMinutosDesdeBaseAnterior.TabIndex = 3;
            // 
            // btnAgregar
            // 
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Location = new System.Drawing.Point(72, 85);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 38);
            this.btnAgregar.TabIndex = 4;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Location = new System.Drawing.Point(160, 85);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 38);
            this.btnBuscar.TabIndex = 5;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Location = new System.Drawing.Point(72, 138);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 38);
            this.btnEliminar.TabIndex = 6;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnAgregarEnInicio
            // 
            this.btnAgregarEnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarEnInicio.Location = new System.Drawing.Point(248, 85);
            this.btnAgregarEnInicio.Name = "btnAgregarEnInicio";
            this.btnAgregarEnInicio.Size = new System.Drawing.Size(75, 38);
            this.btnAgregarEnInicio.TabIndex = 7;
            this.btnAgregarEnInicio.Text = "Agregar en inicio";
            this.btnAgregarEnInicio.UseVisualStyleBackColor = true;
            this.btnAgregarEnInicio.Click += new System.EventHandler(this.btnAgregarEnInicio_Click);
            // 
            // btnRecorrido
            // 
            this.btnRecorrido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecorrido.Location = new System.Drawing.Point(345, 336);
            this.btnRecorrido.Name = "btnRecorrido";
            this.btnRecorrido.Size = new System.Drawing.Size(75, 38);
            this.btnRecorrido.TabIndex = 8;
            this.btnRecorrido.Text = "Recorrido";
            this.btnRecorrido.UseVisualStyleBackColor = true;
            this.btnRecorrido.Click += new System.EventHandler(this.btnRecorrido_Click);
            // 
            // btnInsertarDespuesDe
            // 
            this.btnInsertarDespuesDe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsertarDespuesDe.Location = new System.Drawing.Point(128, 309);
            this.btnInsertarDespuesDe.Name = "btnInsertarDespuesDe";
            this.btnInsertarDespuesDe.Size = new System.Drawing.Size(139, 34);
            this.btnInsertarDespuesDe.TabIndex = 9;
            this.btnInsertarDespuesDe.Text = "Insertar después de...";
            this.btnInsertarDespuesDe.UseVisualStyleBackColor = true;
            this.btnInsertarDespuesDe.Click += new System.EventHandler(this.btnInsertarDespuesDe_Click);
            // 
            // btnReporte
            // 
            this.btnReporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReporte.Location = new System.Drawing.Point(160, 357);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(75, 38);
            this.btnReporte.TabIndex = 10;
            this.btnReporte.Text = "Reporte";
            this.btnReporte.UseVisualStyleBackColor = true;
            this.btnReporte.Click += new System.EventHandler(this.btnReporte_Click);
            // 
            // txtReporte
            // 
            this.txtReporte.Font = new System.Drawing.Font("Monospac821 BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReporte.Location = new System.Drawing.Point(345, 16);
            this.txtReporte.Multiline = true;
            this.txtReporte.Name = "txtReporte";
            this.txtReporte.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtReporte.Size = new System.Drawing.Size(272, 282);
            this.txtReporte.TabIndex = 11;
            // 
            // txtInsertarDespuesDe
            // 
            this.txtInsertarDespuesDe.Location = new System.Drawing.Point(142, 218);
            this.txtInsertarDespuesDe.Name = "txtInsertarDespuesDe";
            this.txtInsertarDespuesDe.Size = new System.Drawing.Size(111, 20);
            this.txtInsertarDespuesDe.TabIndex = 14;
            // 
            // lblInsertarDespuesDe
            // 
            this.lblInsertarDespuesDe.AutoSize = true;
            this.lblInsertarDespuesDe.Location = new System.Drawing.Point(174, 202);
            this.lblInsertarDespuesDe.Name = "lblInsertarDespuesDe";
            this.lblInsertarDespuesDe.Size = new System.Drawing.Size(47, 13);
            this.lblInsertarDespuesDe.TabIndex = 12;
            this.lblInsertarDespuesDe.Text = "Nombre:";
            // 
            // dtpHoraInicio
            // 
            this.dtpHoraInicio.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHoraInicio.Location = new System.Drawing.Point(506, 341);
            this.dtpHoraInicio.MinDate = new System.DateTime(2017, 1, 1, 0, 0, 0, 0);
            this.dtpHoraInicio.Name = "dtpHoraInicio";
            this.dtpHoraInicio.ShowUpDown = true;
            this.dtpHoraInicio.Size = new System.Drawing.Size(111, 20);
            this.dtpHoraInicio.TabIndex = 16;
            this.dtpHoraInicio.Value = new System.DateTime(2017, 5, 11, 22, 49, 18, 0);
            // 
            // txtNombreRecorrido
            // 
            this.txtNombreRecorrido.Location = new System.Drawing.Point(506, 311);
            this.txtNombreRecorrido.Name = "txtNombreRecorrido";
            this.txtNombreRecorrido.Size = new System.Drawing.Size(111, 20);
            this.txtNombreRecorrido.TabIndex = 18;
            // 
            // lblNombreRecorrido
            // 
            this.lblNombreRecorrido.AutoSize = true;
            this.lblNombreRecorrido.Location = new System.Drawing.Point(444, 314);
            this.lblNombreRecorrido.Name = "lblNombreRecorrido";
            this.lblNombreRecorrido.Size = new System.Drawing.Size(47, 13);
            this.lblNombreRecorrido.TabIndex = 17;
            this.lblNombreRecorrido.Text = "Nombre:";
            // 
            // lblHoraInicio
            // 
            this.lblHoraInicio.AutoSize = true;
            this.lblHoraInicio.Location = new System.Drawing.Point(444, 347);
            this.lblHoraInicio.Name = "lblHoraInicio";
            this.lblHoraInicio.Size = new System.Drawing.Size(60, 13);
            this.lblHoraInicio.TabIndex = 19;
            this.lblHoraInicio.Text = "Hora inicio:";
            // 
            // lblHoraFin
            // 
            this.lblHoraFin.AutoSize = true;
            this.lblHoraFin.Location = new System.Drawing.Point(444, 378);
            this.lblHoraFin.Name = "lblHoraFin";
            this.lblHoraFin.Size = new System.Drawing.Size(47, 13);
            this.lblHoraFin.TabIndex = 21;
            this.lblHoraFin.Text = "Hora fin:";
            // 
            // dtpHoraFin
            // 
            this.dtpHoraFin.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHoraFin.Location = new System.Drawing.Point(506, 372);
            this.dtpHoraFin.MinDate = new System.DateTime(2017, 1, 1, 0, 0, 0, 0);
            this.dtpHoraFin.Name = "dtpHoraFin";
            this.dtpHoraFin.ShowUpDown = true;
            this.dtpHoraFin.Size = new System.Drawing.Size(111, 20);
            this.dtpHoraFin.TabIndex = 20;
            this.dtpHoraFin.Value = new System.DateTime(2017, 5, 11, 22, 49, 18, 0);
            // 
            // btnEliminarPrimero
            // 
            this.btnEliminarPrimero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarPrimero.Location = new System.Drawing.Point(160, 138);
            this.btnEliminarPrimero.Name = "btnEliminarPrimero";
            this.btnEliminarPrimero.Size = new System.Drawing.Size(75, 38);
            this.btnEliminarPrimero.TabIndex = 22;
            this.btnEliminarPrimero.Text = "Eliminar primero";
            this.btnEliminarPrimero.UseVisualStyleBackColor = true;
            this.btnEliminarPrimero.Click += new System.EventHandler(this.btnEliminarPrimero_Click);
            // 
            // btnEliminarUltimo
            // 
            this.btnEliminarUltimo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarUltimo.Location = new System.Drawing.Point(248, 138);
            this.btnEliminarUltimo.Name = "btnEliminarUltimo";
            this.btnEliminarUltimo.Size = new System.Drawing.Size(75, 38);
            this.btnEliminarUltimo.TabIndex = 23;
            this.btnEliminarUltimo.Text = "Eliminar último";
            this.btnEliminarUltimo.UseVisualStyleBackColor = true;
            this.btnEliminarUltimo.Click += new System.EventHandler(this.btnEliminarUltimo_Click);
            // 
            // txtMinAInsertar
            // 
            this.txtMinAInsertar.Location = new System.Drawing.Point(217, 278);
            this.txtMinAInsertar.Name = "txtMinAInsertar";
            this.txtMinAInsertar.Size = new System.Drawing.Size(107, 20);
            this.txtMinAInsertar.TabIndex = 27;
            // 
            // txtBaseAInsertar
            // 
            this.txtBaseAInsertar.Location = new System.Drawing.Point(72, 278);
            this.txtBaseAInsertar.Name = "txtBaseAInsertar";
            this.txtBaseAInsertar.Size = new System.Drawing.Size(118, 20);
            this.txtBaseAInsertar.TabIndex = 26;
            // 
            // lblMinAInsertar
            // 
            this.lblMinAInsertar.Location = new System.Drawing.Point(214, 248);
            this.lblMinAInsertar.Name = "lblMinAInsertar";
            this.lblMinAInsertar.Size = new System.Drawing.Size(118, 27);
            this.lblMinAInsertar.TabIndex = 25;
            this.lblMinAInsertar.Text = "Minutos desde la base anterior:";
            // 
            // lblBaseAInsertar
            // 
            this.lblBaseAInsertar.AutoSize = true;
            this.lblBaseAInsertar.Location = new System.Drawing.Point(69, 251);
            this.lblBaseAInsertar.Name = "lblBaseAInsertar";
            this.lblBaseAInsertar.Size = new System.Drawing.Size(80, 13);
            this.lblBaseAInsertar.TabIndex = 24;
            this.lblBaseAInsertar.Text = "Base a insertar:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(686, 412);
            this.Controls.Add(this.txtMinAInsertar);
            this.Controls.Add(this.txtBaseAInsertar);
            this.Controls.Add(this.lblMinAInsertar);
            this.Controls.Add(this.lblBaseAInsertar);
            this.Controls.Add(this.btnEliminarUltimo);
            this.Controls.Add(this.btnEliminarPrimero);
            this.Controls.Add(this.lblHoraFin);
            this.Controls.Add(this.dtpHoraFin);
            this.Controls.Add(this.lblHoraInicio);
            this.Controls.Add(this.txtNombreRecorrido);
            this.Controls.Add(this.lblNombreRecorrido);
            this.Controls.Add(this.dtpHoraInicio);
            this.Controls.Add(this.txtInsertarDespuesDe);
            this.Controls.Add(this.lblInsertarDespuesDe);
            this.Controls.Add(this.txtReporte);
            this.Controls.Add(this.btnReporte);
            this.Controls.Add(this.btnInsertarDespuesDe);
            this.Controls.Add(this.btnRecorrido);
            this.Controls.Add(this.btnAgregarEnInicio);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtMinutosDesdeBaseAnterior);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblMinutosDesdeBaseAnterior);
            this.Controls.Add(this.lblNombre);
            this.Name = "Form1";
            this.Text = "Lista Circular";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblMinutosDesdeBaseAnterior;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtMinutosDesdeBaseAnterior;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnAgregarEnInicio;
        private System.Windows.Forms.Button btnRecorrido;
        private System.Windows.Forms.Button btnInsertarDespuesDe;
        private System.Windows.Forms.Button btnReporte;
        private System.Windows.Forms.TextBox txtReporte;
        private System.Windows.Forms.TextBox txtInsertarDespuesDe;
        private System.Windows.Forms.Label lblInsertarDespuesDe;
        private System.Windows.Forms.DateTimePicker dtpHoraInicio;
        private System.Windows.Forms.TextBox txtNombreRecorrido;
        private System.Windows.Forms.Label lblNombreRecorrido;
        private System.Windows.Forms.Label lblHoraInicio;
        private System.Windows.Forms.Label lblHoraFin;
        private System.Windows.Forms.DateTimePicker dtpHoraFin;
        private System.Windows.Forms.Button btnEliminarPrimero;
        private System.Windows.Forms.Button btnEliminarUltimo;
        private System.Windows.Forms.TextBox txtMinAInsertar;
        private System.Windows.Forms.TextBox txtBaseAInsertar;
        private System.Windows.Forms.Label lblMinAInsertar;
        private System.Windows.Forms.Label lblBaseAInsertar;
    }
}

