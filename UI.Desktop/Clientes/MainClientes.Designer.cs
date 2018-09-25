namespace UI.Desktop.Clientes
{
    partial class MainClientes
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
            Bussiness.Logic.Clientes.ClienteLogic clienteLogic1 = new Bussiness.Logic.Clientes.ClienteLogic();
            Database.Clientes.ClientesAdapter clientesAdapter1 = new Database.Clientes.ClientesAdapter();
            Bussiness.Logic.IngresoLogic ingresoLogic1 = new Bussiness.Logic.IngresoLogic();
            this.btnAgregarCliente = new System.Windows.Forms.Button();
            this.btnVolverCliente = new System.Windows.Forms.Button();
            this.btnEditarCliente = new System.Windows.Forms.Button();
            this.btnBorrarCliente = new System.Windows.Forms.Button();
            this.lblTitleListado = new System.Windows.Forms.Label();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.btnConsultarDatos = new System.Windows.Forms.Button();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TelFijo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Celular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgregarCliente
            // 
            this.btnAgregarCliente.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnAgregarCliente.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAgregarCliente.FlatAppearance.BorderSize = 0;
            this.btnAgregarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregarCliente.ForeColor = System.Drawing.SystemColors.Info;
            this.btnAgregarCliente.Location = new System.Drawing.Point(1200, 25);
            this.btnAgregarCliente.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregarCliente.Name = "btnAgregarCliente";
            this.btnAgregarCliente.Size = new System.Drawing.Size(324, 28);
            this.btnAgregarCliente.TabIndex = 41;
            this.btnAgregarCliente.Text = "Agregar nuevo cliente";
            this.btnAgregarCliente.UseVisualStyleBackColor = false;
            this.btnAgregarCliente.Click += new System.EventHandler(this.btnAgregarCliente_Click);
            // 
            // btnVolverCliente
            // 
            this.btnVolverCliente.Location = new System.Drawing.Point(1204, 533);
            this.btnVolverCliente.Margin = new System.Windows.Forms.Padding(4);
            this.btnVolverCliente.Name = "btnVolverCliente";
            this.btnVolverCliente.Size = new System.Drawing.Size(324, 28);
            this.btnVolverCliente.TabIndex = 40;
            this.btnVolverCliente.Text = "Volver";
            this.btnVolverCliente.UseVisualStyleBackColor = true;
            this.btnVolverCliente.Click += new System.EventHandler(this.btnVolverCliente_Click);
            // 
            // btnEditarCliente
            // 
            this.btnEditarCliente.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnEditarCliente.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEditarCliente.FlatAppearance.BorderSize = 0;
            this.btnEditarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEditarCliente.ForeColor = System.Drawing.SystemColors.Info;
            this.btnEditarCliente.Location = new System.Drawing.Point(25, 533);
            this.btnEditarCliente.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditarCliente.Name = "btnEditarCliente";
            this.btnEditarCliente.Size = new System.Drawing.Size(208, 28);
            this.btnEditarCliente.TabIndex = 39;
            this.btnEditarCliente.Text = "Editar";
            this.btnEditarCliente.UseVisualStyleBackColor = false;
            this.btnEditarCliente.Click += new System.EventHandler(this.btnEditarCliente_Click);
            // 
            // btnBorrarCliente
            // 
            this.btnBorrarCliente.BackColor = System.Drawing.SystemColors.Window;
            this.btnBorrarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBorrarCliente.Location = new System.Drawing.Point(269, 533);
            this.btnBorrarCliente.Margin = new System.Windows.Forms.Padding(4);
            this.btnBorrarCliente.Name = "btnBorrarCliente";
            this.btnBorrarCliente.Size = new System.Drawing.Size(208, 28);
            this.btnBorrarCliente.TabIndex = 38;
            this.btnBorrarCliente.Text = "Eliminar";
            this.btnBorrarCliente.UseVisualStyleBackColor = false;
            this.btnBorrarCliente.Click += new System.EventHandler(this.btnBorrarCliente_Click);
            // 
            // lblTitleListado
            // 
            this.lblTitleListado.AutoSize = true;
            this.lblTitleListado.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleListado.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lblTitleListado.Location = new System.Drawing.Point(19, 19);
            this.lblTitleListado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitleListado.Name = "lblTitleListado";
            this.lblTitleListado.Size = new System.Drawing.Size(210, 32);
            this.lblTitleListado.TabIndex = 37;
            this.lblTitleListado.Text = "Lista de clientes";
            // 
            // dgvClientes
            // 
            this.dgvClientes.AllowUserToAddRows = false;
            this.dgvClientes.AllowUserToDeleteRows = false;
            this.dgvClientes.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nombre,
            this.Tipo,
            this.Monto,
            this.TelFijo,
            this.Celular});
            this.dgvClientes.Location = new System.Drawing.Point(25, 76);
            this.dgvClientes.Margin = new System.Windows.Forms.Padding(4);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.ReadOnly = true;
            this.dgvClientes.Size = new System.Drawing.Size(1499, 440);
            this.dgvClientes.TabIndex = 36;
            this.dgvClientes.SelectionChanged += new System.EventHandler(this.dgvClientes_SelectionChanged);
            // 
            // btnConsultarDatos
            // 
            this.btnConsultarDatos.BackColor = System.Drawing.SystemColors.Window;
            this.btnConsultarDatos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConsultarDatos.Location = new System.Drawing.Point(319, 25);
            this.btnConsultarDatos.Margin = new System.Windows.Forms.Padding(4);
            this.btnConsultarDatos.Name = "btnConsultarDatos";
            this.btnConsultarDatos.Size = new System.Drawing.Size(388, 28);
            this.btnConsultarDatos.TabIndex = 42;
            this.btnConsultarDatos.Text = "Ver datos";
            this.btnConsultarDatos.UseVisualStyleBackColor = false;
            this.btnConsultarDatos.Click += new System.EventHandler(this.btnConsultarDatos_Click);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 350;
            // 
            // Tipo
            // 
            this.Tipo.DataPropertyName = "Apellido";
            this.Tipo.HeaderText = "Apellido";
            this.Tipo.Name = "Tipo";
            this.Tipo.ReadOnly = true;
            // 
            // Monto
            // 
            this.Monto.DataPropertyName = "Direccion";
            this.Monto.HeaderText = "Dirección";
            this.Monto.Name = "Monto";
            this.Monto.ReadOnly = true;
            // 
            // TelFijo
            // 
            this.TelFijo.DataPropertyName = "TelefonoFijo";
            this.TelFijo.HeaderText = "Teléfono Fijo";
            this.TelFijo.Name = "TelFijo";
            this.TelFijo.ReadOnly = true;
            // 
            // Celular
            // 
            this.Celular.DataPropertyName = "TelefonoCelular";
            this.Celular.HeaderText = "Celular";
            this.Celular.Name = "Celular";
            this.Celular.ReadOnly = true;
            this.Celular.Width = 150;
            // 
            // MainClientes
            // 
            clienteLogic1._RecordManejador = null;
            clienteLogic1._TiposManejador = null;
            clienteLogic1.ClienteAdapter = clientesAdapter1;
            this._CliLogic = clienteLogic1;
            ingresoLogic1._RecordManejador = null;
            ingresoLogic1._TiposManejador = null;
            this._IngLogic = ingresoLogic1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1550, 574);
            this.Controls.Add(this.btnConsultarDatos);
            this.Controls.Add(this.btnAgregarCliente);
            this.Controls.Add(this.btnVolverCliente);
            this.Controls.Add(this.btnEditarCliente);
            this.Controls.Add(this.btnBorrarCliente);
            this.Controls.Add(this.lblTitleListado);
            this.Controls.Add(this.dgvClientes);
            this.Name = "MainClientes";
            this.Text = "Listado clientes";
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregarCliente;
        private System.Windows.Forms.Button btnVolverCliente;
        private System.Windows.Forms.Button btnEditarCliente;
        private System.Windows.Forms.Button btnBorrarCliente;
        private System.Windows.Forms.Label lblTitleListado;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.Button btnConsultarDatos;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monto;
        private System.Windows.Forms.DataGridViewTextBoxColumn TelFijo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Celular;
    }
}