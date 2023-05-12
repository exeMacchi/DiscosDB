namespace Vista
{
    partial class frmPrincipal
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
            this.pboxPortadas = new System.Windows.Forms.PictureBox();
            this.dgvDiscos = new System.Windows.Forms.DataGridView();
            this.btnAgregarDisco = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnBorrarDisco = new System.Windows.Forms.Button();
            this.lbBuscar = new System.Windows.Forms.Label();
            this.txboxBuscar = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.rbtnTitulo = new System.Windows.Forms.RadioButton();
            this.rbtnEstilo = new System.Windows.Forms.RadioButton();
            this.rbtnEdicion = new System.Windows.Forms.RadioButton();
            this.lbResultados = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pboxPortadas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiscos)).BeginInit();
            this.SuspendLayout();
            // 
            // pboxPortadas
            // 
            this.pboxPortadas.Location = new System.Drawing.Point(835, 143);
            this.pboxPortadas.Name = "pboxPortadas";
            this.pboxPortadas.Size = new System.Drawing.Size(369, 323);
            this.pboxPortadas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxPortadas.TabIndex = 0;
            this.pboxPortadas.TabStop = false;
            // 
            // dgvDiscos
            // 
            this.dgvDiscos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDiscos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvDiscos.Location = new System.Drawing.Point(14, 112);
            this.dgvDiscos.MultiSelect = false;
            this.dgvDiscos.Name = "dgvDiscos";
            this.dgvDiscos.RowHeadersWidth = 51;
            this.dgvDiscos.RowTemplate.Height = 24;
            this.dgvDiscos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDiscos.Size = new System.Drawing.Size(790, 384);
            this.dgvDiscos.TabIndex = 1;
            this.dgvDiscos.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvDiscos_CellFormatting);
            this.dgvDiscos.SelectionChanged += new System.EventHandler(this.dgvDiscos_SelectionChanged);
            // 
            // btnAgregarDisco
            // 
            this.btnAgregarDisco.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnAgregarDisco.Location = new System.Drawing.Point(15, 516);
            this.btnAgregarDisco.Name = "btnAgregarDisco";
            this.btnAgregarDisco.Size = new System.Drawing.Size(171, 49);
            this.btnAgregarDisco.TabIndex = 2;
            this.btnAgregarDisco.Text = "Agregar nuevo disco";
            this.btnAgregarDisco.UseVisualStyleBackColor = true;
            this.btnAgregarDisco.Click += new System.EventHandler(this.btnAgregarDisco_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnModificar.Location = new System.Drawing.Point(316, 516);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(171, 49);
            this.btnModificar.TabIndex = 3;
            this.btnModificar.Text = "Modificar disco";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnBorrarDisco
            // 
            this.btnBorrarDisco.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnBorrarDisco.Location = new System.Drawing.Point(633, 517);
            this.btnBorrarDisco.Name = "btnBorrarDisco";
            this.btnBorrarDisco.Size = new System.Drawing.Size(171, 49);
            this.btnBorrarDisco.TabIndex = 4;
            this.btnBorrarDisco.Text = "Borrar disco";
            this.btnBorrarDisco.UseVisualStyleBackColor = true;
            this.btnBorrarDisco.Click += new System.EventHandler(this.btnBorrarDisco_Click);
            // 
            // lbBuscar
            // 
            this.lbBuscar.AutoSize = true;
            this.lbBuscar.Location = new System.Drawing.Point(12, 41);
            this.lbBuscar.Name = "lbBuscar";
            this.lbBuscar.Size = new System.Drawing.Size(52, 16);
            this.lbBuscar.TabIndex = 5;
            this.lbBuscar.Text = "Buscar:";
            // 
            // txboxBuscar
            // 
            this.txboxBuscar.Location = new System.Drawing.Point(70, 39);
            this.txboxBuscar.Name = "txboxBuscar";
            this.txboxBuscar.Size = new System.Drawing.Size(342, 22);
            this.txboxBuscar.TabIndex = 6;
            this.txboxBuscar.TextChanged += new System.EventHandler(this.txboxBuscar_TextChanged);
            this.txboxBuscar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txboxBuscar_KeyDown);
            // 
            // btnBuscar
            // 
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnBuscar.Location = new System.Drawing.Point(429, 39);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(149, 22);
            this.btnBuscar.TabIndex = 7;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // rbtnTitulo
            // 
            this.rbtnTitulo.AutoSize = true;
            this.rbtnTitulo.Checked = true;
            this.rbtnTitulo.Location = new System.Drawing.Point(70, 70);
            this.rbtnTitulo.Name = "rbtnTitulo";
            this.rbtnTitulo.Size = new System.Drawing.Size(61, 20);
            this.rbtnTitulo.TabIndex = 8;
            this.rbtnTitulo.TabStop = true;
            this.rbtnTitulo.Text = "Titulo";
            this.rbtnTitulo.UseVisualStyleBackColor = true;
            // 
            // rbtnEstilo
            // 
            this.rbtnEstilo.AutoSize = true;
            this.rbtnEstilo.Location = new System.Drawing.Point(204, 70);
            this.rbtnEstilo.Name = "rbtnEstilo";
            this.rbtnEstilo.Size = new System.Drawing.Size(61, 20);
            this.rbtnEstilo.TabIndex = 9;
            this.rbtnEstilo.Text = "Estilo";
            this.rbtnEstilo.UseVisualStyleBackColor = true;
            // 
            // rbtnEdicion
            // 
            this.rbtnEdicion.AutoSize = true;
            this.rbtnEdicion.Location = new System.Drawing.Point(339, 70);
            this.rbtnEdicion.Name = "rbtnEdicion";
            this.rbtnEdicion.Size = new System.Drawing.Size(73, 20);
            this.rbtnEdicion.TabIndex = 10;
            this.rbtnEdicion.Text = "Edición";
            this.rbtnEdicion.UseVisualStyleBackColor = true;
            // 
            // lbResultados
            // 
            this.lbResultados.AutoSize = true;
            this.lbResultados.Location = new System.Drawing.Point(700, 93);
            this.lbResultados.Name = "lbResultados";
            this.lbResultados.Size = new System.Drawing.Size(79, 16);
            this.lbResultados.TabIndex = 11;
            this.lbResultados.Text = "Resultados:";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1235, 577);
            this.Controls.Add(this.lbResultados);
            this.Controls.Add(this.rbtnEdicion);
            this.Controls.Add(this.rbtnEstilo);
            this.Controls.Add(this.rbtnTitulo);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txboxBuscar);
            this.Controls.Add(this.lbBuscar);
            this.Controls.Add(this.btnBorrarDisco);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregarDisco);
            this.Controls.Add(this.dgvDiscos);
            this.Controls.Add(this.pboxPortadas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmPrincipal";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Discos";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pboxPortadas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiscos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pboxPortadas;
        private System.Windows.Forms.DataGridView dgvDiscos;
        private System.Windows.Forms.Button btnAgregarDisco;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnBorrarDisco;
        private System.Windows.Forms.Label lbBuscar;
        private System.Windows.Forms.TextBox txboxBuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.RadioButton rbtnTitulo;
        private System.Windows.Forms.RadioButton rbtnEstilo;
        private System.Windows.Forms.RadioButton rbtnEdicion;
        private System.Windows.Forms.Label lbResultados;
    }
}

