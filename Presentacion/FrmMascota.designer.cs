namespace ABMMascotas.Presentacion
{
    partial class FrmMascota
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblEspecie = new System.Windows.Forms.Label();
            this.lblSexo = new System.Windows.Forms.Label();
            this.cboEspecie = new System.Windows.Forms.ComboBox();
            this.rbtMacho = new System.Windows.Forms.RadioButton();
            this.rbtHembra = new System.Windows.Forms.RadioButton();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.grpFiltros = new System.Windows.Forms.GroupBox();
            this.chkTodos = new System.Windows.Forms.CheckBox();
            this.dgvMascotas = new System.Windows.Forms.DataGridView();
            this.btnDetalles = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.grpFiltros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMascotas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEspecie
            // 
            this.lblEspecie.AutoSize = true;
            this.lblEspecie.Location = new System.Drawing.Point(45, 29);
            this.lblEspecie.Name = "lblEspecie";
            this.lblEspecie.Size = new System.Drawing.Size(45, 13);
            this.lblEspecie.TabIndex = 2;
            this.lblEspecie.Text = "Especie";
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Location = new System.Drawing.Point(59, 58);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(31, 13);
            this.lblSexo.TabIndex = 3;
            this.lblSexo.Text = "Sexo";
            // 
            // cboEspecie
            // 
            this.cboEspecie.FormattingEnabled = true;
            this.cboEspecie.Location = new System.Drawing.Point(94, 26);
            this.cboEspecie.Name = "cboEspecie";
            this.cboEspecie.Size = new System.Drawing.Size(163, 21);
            this.cboEspecie.TabIndex = 2;
            this.cboEspecie.SelectedIndexChanged += new System.EventHandler(this.cboEspecie_SelectedIndexChanged);
            // 
            // rbtMacho
            // 
            this.rbtMacho.AutoSize = true;
            this.rbtMacho.Location = new System.Drawing.Point(94, 57);
            this.rbtMacho.Name = "rbtMacho";
            this.rbtMacho.Size = new System.Drawing.Size(73, 17);
            this.rbtMacho.TabIndex = 3;
            this.rbtMacho.TabStop = true;
            this.rbtMacho.Text = "1 - Macho";
            this.rbtMacho.UseVisualStyleBackColor = true;
            // 
            // rbtHembra
            // 
            this.rbtHembra.AutoSize = true;
            this.rbtHembra.Location = new System.Drawing.Point(182, 57);
            this.rbtHembra.Name = "rbtHembra";
            this.rbtHembra.Size = new System.Drawing.Size(77, 17);
            this.rbtHembra.TabIndex = 4;
            this.rbtHembra.TabStop = true;
            this.rbtHembra.Text = "2 - Hembra";
            this.rbtHembra.UseVisualStyleBackColor = true;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(29, 309);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnNuevo.TabIndex = 6;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(464, 75);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(75, 23);
            this.btnConsultar.TabIndex = 7;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(474, 309);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 8;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // grpFiltros
            // 
            this.grpFiltros.Controls.Add(this.chkTodos);
            this.grpFiltros.Controls.Add(this.dgvMascotas);
            this.grpFiltros.Controls.Add(this.cboEspecie);
            this.grpFiltros.Controls.Add(this.btnConsultar);
            this.grpFiltros.Controls.Add(this.lblEspecie);
            this.grpFiltros.Controls.Add(this.lblSexo);
            this.grpFiltros.Controls.Add(this.rbtMacho);
            this.grpFiltros.Controls.Add(this.rbtHembra);
            this.grpFiltros.Location = new System.Drawing.Point(10, 11);
            this.grpFiltros.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpFiltros.Name = "grpFiltros";
            this.grpFiltros.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpFiltros.Size = new System.Drawing.Size(554, 281);
            this.grpFiltros.TabIndex = 9;
            this.grpFiltros.TabStop = false;
            this.grpFiltros.Text = "Filtros";
            this.grpFiltros.Enter += new System.EventHandler(this.grpFiltros_Enter);
            // 
            // chkTodos
            // 
            this.chkTodos.AutoSize = true;
            this.chkTodos.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkTodos.Location = new System.Drawing.Point(54, 84);
            this.chkTodos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkTodos.Name = "chkTodos";
            this.chkTodos.Size = new System.Drawing.Size(56, 17);
            this.chkTodos.TabIndex = 8;
            this.chkTodos.Text = "Todos";
            this.chkTodos.UseVisualStyleBackColor = true;
            this.chkTodos.CheckedChanged += new System.EventHandler(this.chkTodos_CheckedChanged);
            // 
            // dgvMascotas
            // 
            this.dgvMascotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMascotas.Location = new System.Drawing.Point(19, 116);
            this.dgvMascotas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvMascotas.Name = "dgvMascotas";
            this.dgvMascotas.RowHeadersWidth = 51;
            this.dgvMascotas.RowTemplate.Height = 24;
            this.dgvMascotas.Size = new System.Drawing.Size(520, 152);
            this.dgvMascotas.TabIndex = 5;
            this.dgvMascotas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMascotas_CellContentClick);
            // 
            // btnDetalles
            // 
            this.btnDetalles.Location = new System.Drawing.Point(303, 309);
            this.btnDetalles.Name = "btnDetalles";
            this.btnDetalles.Size = new System.Drawing.Size(75, 23);
            this.btnDetalles.TabIndex = 10;
            this.btnDetalles.Text = "Detalles";
            this.btnDetalles.UseVisualStyleBackColor = true;
            this.btnDetalles.Click += new System.EventHandler(this.btnDetalles_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(110, 309);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 11;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(194, 309);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(75, 23);
            this.btnBorrar.TabIndex = 12;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // FrmMascota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 346);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnDetalles);
            this.Controls.Add(this.grpFiltros);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnNuevo);
            this.Name = "FrmMascota";
            this.Text = "Mascotas";
            this.Load += new System.EventHandler(this.FrmMascota_Load);
            this.grpFiltros.ResumeLayout(false);
            this.grpFiltros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMascotas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblEspecie;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.ComboBox cboEspecie;
        private System.Windows.Forms.RadioButton rbtMacho;
        private System.Windows.Forms.RadioButton rbtHembra;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.GroupBox grpFiltros;
        private System.Windows.Forms.DataGridView dgvMascotas;
        private System.Windows.Forms.CheckBox chkTodos;
        private System.Windows.Forms.Button btnDetalles;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnBorrar;
    }
}

