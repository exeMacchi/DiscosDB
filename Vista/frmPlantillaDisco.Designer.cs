namespace Vista
{
    partial class frmPlantillaDisco
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
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.lbFechaLanzamiento = new System.Windows.Forms.Label();
            this.lbCantidadCanciones = new System.Windows.Forms.Label();
            this.lbUrlImagen = new System.Windows.Forms.Label();
            this.lbEstilo = new System.Windows.Forms.Label();
            this.lbEdicion = new System.Windows.Forms.Label();
            this.txbxTitulo = new System.Windows.Forms.TextBox();
            this.dtpFechaLanzamiento = new System.Windows.Forms.DateTimePicker();
            this.txbxCantidadCanciones = new System.Windows.Forms.TextBox();
            this.txbxPortada = new System.Windows.Forms.TextBox();
            this.comboxEstilo = new System.Windows.Forms.ComboBox();
            this.comboxEdicion = new System.Windows.Forms.ComboBox();
            this.pboxPortada = new System.Windows.Forms.PictureBox();
            this.ofdPortada = new System.Windows.Forms.OpenFileDialog();
            this.btnPortada = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pboxPortada)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnAgregar.Location = new System.Drawing.Point(160, 304);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(115, 37);
            this.btnAgregar.TabIndex = 7;
            this.btnAgregar.Text = "AGREGAR";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCancelar.Location = new System.Drawing.Point(347, 304);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(115, 37);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Location = new System.Drawing.Point(111, 54);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(43, 16);
            this.lbTitulo.TabIndex = 2;
            this.lbTitulo.Text = "Título:";
            // 
            // lbFechaLanzamiento
            // 
            this.lbFechaLanzamiento.AutoSize = true;
            this.lbFechaLanzamiento.Location = new System.Drawing.Point(12, 95);
            this.lbFechaLanzamiento.Name = "lbFechaLanzamiento";
            this.lbFechaLanzamiento.Size = new System.Drawing.Size(142, 16);
            this.lbFechaLanzamiento.TabIndex = 3;
            this.lbFechaLanzamiento.Text = "Fecha de lanzamiento:";
            // 
            // lbCantidadCanciones
            // 
            this.lbCantidadCanciones.AutoSize = true;
            this.lbCantidadCanciones.Location = new System.Drawing.Point(6, 131);
            this.lbCantidadCanciones.Name = "lbCantidadCanciones";
            this.lbCantidadCanciones.Size = new System.Drawing.Size(148, 16);
            this.lbCantidadCanciones.TabIndex = 4;
            this.lbCantidadCanciones.Text = "Cantidad de canciones:";
            // 
            // lbUrlImagen
            // 
            this.lbUrlImagen.AutoSize = true;
            this.lbUrlImagen.Location = new System.Drawing.Point(49, 168);
            this.lbUrlImagen.Name = "lbUrlImagen";
            this.lbUrlImagen.Size = new System.Drawing.Size(105, 16);
            this.lbUrlImagen.TabIndex = 5;
            this.lbUrlImagen.Text = "Imagen portada:";
            // 
            // lbEstilo
            // 
            this.lbEstilo.AutoSize = true;
            this.lbEstilo.Location = new System.Drawing.Point(111, 204);
            this.lbEstilo.Name = "lbEstilo";
            this.lbEstilo.Size = new System.Drawing.Size(43, 16);
            this.lbEstilo.TabIndex = 6;
            this.lbEstilo.Text = "Estilo:";
            // 
            // lbEdicion
            // 
            this.lbEdicion.AutoSize = true;
            this.lbEdicion.Location = new System.Drawing.Point(99, 238);
            this.lbEdicion.Name = "lbEdicion";
            this.lbEdicion.Size = new System.Drawing.Size(55, 16);
            this.lbEdicion.TabIndex = 7;
            this.lbEdicion.Text = "Edición:";
            // 
            // txbxTitulo
            // 
            this.txbxTitulo.Location = new System.Drawing.Point(160, 48);
            this.txbxTitulo.Name = "txbxTitulo";
            this.txbxTitulo.Size = new System.Drawing.Size(302, 22);
            this.txbxTitulo.TabIndex = 0;
            this.txbxTitulo.TextChanged += new System.EventHandler(this.txbxTitulo_TextChanged);
            // 
            // dtpFechaLanzamiento
            // 
            this.dtpFechaLanzamiento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaLanzamiento.Location = new System.Drawing.Point(160, 90);
            this.dtpFechaLanzamiento.MaxDate = new System.DateTime(2029, 12, 25, 23, 59, 59, 0);
            this.dtpFechaLanzamiento.Name = "dtpFechaLanzamiento";
            this.dtpFechaLanzamiento.Size = new System.Drawing.Size(302, 22);
            this.dtpFechaLanzamiento.TabIndex = 1;
            // 
            // txbxCantidadCanciones
            // 
            this.txbxCantidadCanciones.Location = new System.Drawing.Point(160, 131);
            this.txbxCantidadCanciones.MaxLength = 10;
            this.txbxCantidadCanciones.Name = "txbxCantidadCanciones";
            this.txbxCantidadCanciones.Size = new System.Drawing.Size(302, 22);
            this.txbxCantidadCanciones.TabIndex = 2;
            this.txbxCantidadCanciones.TextChanged += new System.EventHandler(this.txbxCantidadCanciones_TextChanged);
            this.txbxCantidadCanciones.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbxCantidadCanciones_KeyPress);
            // 
            // txbxPortada
            // 
            this.txbxPortada.Location = new System.Drawing.Point(160, 168);
            this.txbxPortada.Name = "txbxPortada";
            this.txbxPortada.Size = new System.Drawing.Size(214, 22);
            this.txbxPortada.TabIndex = 4;
            this.txbxPortada.TextChanged += new System.EventHandler(this.txbxPortada_TextChanged);
            this.txbxPortada.Leave += new System.EventHandler(this.txbxPortada_Leave);
            // 
            // comboxEstilo
            // 
            this.comboxEstilo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboxEstilo.FormattingEnabled = true;
            this.comboxEstilo.Location = new System.Drawing.Point(160, 205);
            this.comboxEstilo.Name = "comboxEstilo";
            this.comboxEstilo.Size = new System.Drawing.Size(302, 24);
            this.comboxEstilo.TabIndex = 5;
            // 
            // comboxEdicion
            // 
            this.comboxEdicion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboxEdicion.FormattingEnabled = true;
            this.comboxEdicion.Location = new System.Drawing.Point(160, 235);
            this.comboxEdicion.Name = "comboxEdicion";
            this.comboxEdicion.Size = new System.Drawing.Size(302, 24);
            this.comboxEdicion.TabIndex = 6;
            // 
            // pboxPortada
            // 
            this.pboxPortada.Location = new System.Drawing.Point(494, 48);
            this.pboxPortada.Name = "pboxPortada";
            this.pboxPortada.Size = new System.Drawing.Size(324, 293);
            this.pboxPortada.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxPortada.TabIndex = 8;
            this.pboxPortada.TabStop = false;
            // 
            // ofdPortada
            // 
            this.ofdPortada.FileName = "openFileDialog1";
            // 
            // btnPortada
            // 
            this.btnPortada.Location = new System.Drawing.Point(386, 168);
            this.btnPortada.Name = "btnPortada";
            this.btnPortada.Size = new System.Drawing.Size(76, 23);
            this.btnPortada.TabIndex = 3;
            this.btnPortada.Text = "Buscar";
            this.btnPortada.UseVisualStyleBackColor = true;
            this.btnPortada.Click += new System.EventHandler(this.btnPortada_Click);
            // 
            // frmPlantillaDisco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 374);
            this.Controls.Add(this.btnPortada);
            this.Controls.Add(this.pboxPortada);
            this.Controls.Add(this.comboxEdicion);
            this.Controls.Add(this.comboxEstilo);
            this.Controls.Add(this.txbxPortada);
            this.Controls.Add(this.txbxCantidadCanciones);
            this.Controls.Add(this.dtpFechaLanzamiento);
            this.Controls.Add(this.txbxTitulo);
            this.Controls.Add(this.lbEdicion);
            this.Controls.Add(this.lbEstilo);
            this.Controls.Add(this.lbUrlImagen);
            this.Controls.Add(this.lbCantidadCanciones);
            this.Controls.Add(this.lbFechaLanzamiento);
            this.Controls.Add(this.lbTitulo);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAgregar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmPlantillaDisco";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo Disco";
            this.Load += new System.EventHandler(this.frmPlantillaDisco_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pboxPortada)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.Label lbFechaLanzamiento;
        private System.Windows.Forms.Label lbCantidadCanciones;
        private System.Windows.Forms.Label lbUrlImagen;
        private System.Windows.Forms.Label lbEstilo;
        private System.Windows.Forms.Label lbEdicion;
        private System.Windows.Forms.TextBox txbxTitulo;
        private System.Windows.Forms.DateTimePicker dtpFechaLanzamiento;
        private System.Windows.Forms.TextBox txbxCantidadCanciones;
        private System.Windows.Forms.TextBox txbxPortada;
        private System.Windows.Forms.ComboBox comboxEstilo;
        private System.Windows.Forms.ComboBox comboxEdicion;
        private System.Windows.Forms.PictureBox pboxPortada;
        private System.Windows.Forms.OpenFileDialog ofdPortada;
        private System.Windows.Forms.Button btnPortada;
    }
}