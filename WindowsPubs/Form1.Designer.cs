namespace WindowsPubs
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
            this.btnMostrarTiendas = new System.Windows.Forms.Button();
            this.gridPubs = new System.Windows.Forms.DataGridView();
            this.btnTraerAutorPorId = new System.Windows.Forms.Button();
            this.btnTraerAutoresPorCiudad = new System.Windows.Forms.Button();
            this.btnTraerTodosPubs = new System.Windows.Forms.Button();
            this.btnTraerTodosAutores = new System.Windows.Forms.Button();
            this.btnTraerPubPorNombre = new System.Windows.Forms.Button();
            this.btnMostrarPublicadoresYEmpleados = new System.Windows.Forms.Button();
            this.btnFiltrarEmpleadosPublicadores = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridPubs)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMostrarTiendas
            // 
            this.btnMostrarTiendas.Location = new System.Drawing.Point(54, 231);
            this.btnMostrarTiendas.Name = "btnMostrarTiendas";
            this.btnMostrarTiendas.Size = new System.Drawing.Size(163, 23);
            this.btnMostrarTiendas.TabIndex = 11;
            this.btnMostrarTiendas.Text = "Mostrar Tiendas y Ventas";
            this.btnMostrarTiendas.UseVisualStyleBackColor = true;
            this.btnMostrarTiendas.Click += new System.EventHandler(this.btnMostrarTiendas_Click);
            // 
            // gridPubs
            // 
            this.gridPubs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPubs.Location = new System.Drawing.Point(282, 62);
            this.gridPubs.Name = "gridPubs";
            this.gridPubs.Size = new System.Drawing.Size(879, 344);
            this.gridPubs.TabIndex = 10;
            // 
            // btnTraerAutorPorId
            // 
            this.btnTraerAutorPorId.Location = new System.Drawing.Point(54, 173);
            this.btnTraerAutorPorId.Name = "btnTraerAutorPorId";
            this.btnTraerAutorPorId.Size = new System.Drawing.Size(163, 23);
            this.btnTraerAutorPorId.TabIndex = 9;
            this.btnTraerAutorPorId.Text = "Traer autor por id";
            this.btnTraerAutorPorId.UseVisualStyleBackColor = true;
            this.btnTraerAutorPorId.Click += new System.EventHandler(this.btnTraerAutorPorId_Click);
            // 
            // btnTraerAutoresPorCiudad
            // 
            this.btnTraerAutoresPorCiudad.Location = new System.Drawing.Point(54, 144);
            this.btnTraerAutoresPorCiudad.Name = "btnTraerAutoresPorCiudad";
            this.btnTraerAutoresPorCiudad.Size = new System.Drawing.Size(163, 23);
            this.btnTraerAutoresPorCiudad.TabIndex = 8;
            this.btnTraerAutoresPorCiudad.Text = "Traer autores por ciudad";
            this.btnTraerAutoresPorCiudad.UseVisualStyleBackColor = true;
            this.btnTraerAutoresPorCiudad.Click += new System.EventHandler(this.btnTraerAutoresPorCiudad_Click);
            // 
            // btnTraerTodosPubs
            // 
            this.btnTraerTodosPubs.Location = new System.Drawing.Point(54, 115);
            this.btnTraerTodosPubs.Name = "btnTraerTodosPubs";
            this.btnTraerTodosPubs.Size = new System.Drawing.Size(163, 23);
            this.btnTraerTodosPubs.TabIndex = 7;
            this.btnTraerTodosPubs.Text = "Traer todos los publicadores";
            this.btnTraerTodosPubs.UseVisualStyleBackColor = true;
            this.btnTraerTodosPubs.Click += new System.EventHandler(this.btnTraerTodosPubs_Click);
            // 
            // btnTraerTodosAutores
            // 
            this.btnTraerTodosAutores.Location = new System.Drawing.Point(54, 86);
            this.btnTraerTodosAutores.Name = "btnTraerTodosAutores";
            this.btnTraerTodosAutores.Size = new System.Drawing.Size(163, 23);
            this.btnTraerTodosAutores.TabIndex = 6;
            this.btnTraerTodosAutores.Text = "Traer todos los autores";
            this.btnTraerTodosAutores.UseVisualStyleBackColor = true;
            this.btnTraerTodosAutores.Click += new System.EventHandler(this.btnTraerTodosAutores_Click);
            // 
            // btnTraerPubPorNombre
            // 
            this.btnTraerPubPorNombre.Location = new System.Drawing.Point(54, 202);
            this.btnTraerPubPorNombre.Name = "btnTraerPubPorNombre";
            this.btnTraerPubPorNombre.Size = new System.Drawing.Size(163, 23);
            this.btnTraerPubPorNombre.TabIndex = 12;
            this.btnTraerPubPorNombre.Text = "Traer publicador por nombre";
            this.btnTraerPubPorNombre.UseVisualStyleBackColor = true;
            this.btnTraerPubPorNombre.Click += new System.EventHandler(this.btnTraerPubPorNombre_Click);
            // 
            // btnMostrarPublicadoresYEmpleados
            // 
            this.btnMostrarPublicadoresYEmpleados.Location = new System.Drawing.Point(29, 260);
            this.btnMostrarPublicadoresYEmpleados.Name = "btnMostrarPublicadoresYEmpleados";
            this.btnMostrarPublicadoresYEmpleados.Size = new System.Drawing.Size(188, 23);
            this.btnMostrarPublicadoresYEmpleados.TabIndex = 13;
            this.btnMostrarPublicadoresYEmpleados.Text = "Mostrar empleados y publicadores";
            this.btnMostrarPublicadoresYEmpleados.UseVisualStyleBackColor = true;
            this.btnMostrarPublicadoresYEmpleados.Click += new System.EventHandler(this.btnMostrarPublicadoresYEmpleados_Click);
            // 
            // btnFiltrarEmpleadosPublicadores
            // 
            this.btnFiltrarEmpleadosPublicadores.Location = new System.Drawing.Point(29, 289);
            this.btnFiltrarEmpleadosPublicadores.Name = "btnFiltrarEmpleadosPublicadores";
            this.btnFiltrarEmpleadosPublicadores.Size = new System.Drawing.Size(188, 23);
            this.btnFiltrarEmpleadosPublicadores.TabIndex = 14;
            this.btnFiltrarEmpleadosPublicadores.Text = "Filtrar empleados y publicadores";
            this.btnFiltrarEmpleadosPublicadores.UseVisualStyleBackColor = true;
            this.btnFiltrarEmpleadosPublicadores.Click += new System.EventHandler(this.btnFiltrarEmpleadosPublicadores_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1221, 450);
            this.Controls.Add(this.btnFiltrarEmpleadosPublicadores);
            this.Controls.Add(this.btnMostrarPublicadoresYEmpleados);
            this.Controls.Add(this.btnTraerPubPorNombre);
            this.Controls.Add(this.btnMostrarTiendas);
            this.Controls.Add(this.gridPubs);
            this.Controls.Add(this.btnTraerAutorPorId);
            this.Controls.Add(this.btnTraerAutoresPorCiudad);
            this.Controls.Add(this.btnTraerTodosPubs);
            this.Controls.Add(this.btnTraerTodosAutores);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.gridPubs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMostrarTiendas;
        private System.Windows.Forms.DataGridView gridPubs;
        private System.Windows.Forms.Button btnTraerAutorPorId;
        private System.Windows.Forms.Button btnTraerAutoresPorCiudad;
        private System.Windows.Forms.Button btnTraerTodosPubs;
        private System.Windows.Forms.Button btnTraerTodosAutores;
        private System.Windows.Forms.Button btnTraerPubPorNombre;
        private System.Windows.Forms.Button btnMostrarPublicadoresYEmpleados;
        private System.Windows.Forms.Button btnFiltrarEmpleadosPublicadores;
    }
}

