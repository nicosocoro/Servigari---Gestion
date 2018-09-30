namespace UI.Desktop
{
    partial class Ingresos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            Bussiness.Logic.Clientes.ClienteLogic clienteLogic1 = new Bussiness.Logic.Clientes.ClienteLogic();
            Database.Clientes.ClientesAdapter clientesAdapter1 = new Database.Clientes.ClientesAdapter();
            Bussiness.Logic.IngresoLogic ingresoLogic1 = new Bussiness.Logic.IngresoLogic();
            this.lblTittle = new System.Windows.Forms.Label();
            this.lblDescripcionIngreso = new System.Windows.Forms.Label();
            this.lblIngreso = new System.Windows.Forms.Label();
            this.txtDescripcionIngreso = new System.Windows.Forms.TextBox();
            this.txtIngreso = new System.Windows.Forms.TextBox();
            this.btnAgregarIngreso = new System.Windows.Forms.Button();
            this.dgvIngresos = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblSubtitle1 = new System.Windows.Forms.Label();
            this.btnBorrarIngreso = new System.Windows.Forms.Button();
            this.btnEditarIngreso = new System.Windows.Forms.Button();
            this.btnCalcularIngresos = new System.Windows.Forms.Button();
            this.btnVolverIngreso = new System.Windows.Forms.Button();
            this.lblCliente = new System.Windows.Forms.Label();
            this.ddlClientes = new System.Windows.Forms.ComboBox();
            this.ddlTipo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMeses = new System.Windows.Forms.Label();
            this.ddlMeses = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIngresos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTittle
            // 
            this.lblTittle.AutoSize = true;
            this.lblTittle.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTittle.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblTittle.Location = new System.Drawing.Point(16, 11);
            this.lblTittle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTittle.Name = "lblTittle";
            this.lblTittle.Size = new System.Drawing.Size(156, 43);
            this.lblTittle.TabIndex = 0;
            this.lblTittle.Text = "Ingresos";
            // 
            // lblDescripcionIngreso
            // 
            this.lblDescripcionIngreso.AutoSize = true;
            this.lblDescripcionIngreso.Font = new System.Drawing.Font("Arial", 14F);
            this.lblDescripcionIngreso.Location = new System.Drawing.Point(20, 75);
            this.lblDescripcionIngreso.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescripcionIngreso.Name = "lblDescripcionIngreso";
            this.lblDescripcionIngreso.Size = new System.Drawing.Size(137, 27);
            this.lblDescripcionIngreso.TabIndex = 1;
            this.lblDescripcionIngreso.Text = "Descripción";
            // 
            // lblIngreso
            // 
            this.lblIngreso.AutoSize = true;
            this.lblIngreso.Font = new System.Drawing.Font("Arial", 12F);
            this.lblIngreso.Location = new System.Drawing.Point(390, 160);
            this.lblIngreso.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIngreso.Name = "lblIngreso";
            this.lblIngreso.Size = new System.Drawing.Size(76, 23);
            this.lblIngreso.TabIndex = 2;
            this.lblIngreso.Text = "Ingreso";
            this.lblIngreso.Click += new System.EventHandler(this.lblIngreso_Click);
            // 
            // txtDescripcionIngreso
            // 
            this.txtDescripcionIngreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtDescripcionIngreso.Location = new System.Drawing.Point(24, 111);
            this.txtDescripcionIngreso.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescripcionIngreso.Name = "txtDescripcionIngreso";
            this.txtDescripcionIngreso.Size = new System.Drawing.Size(1725, 30);
            this.txtDescripcionIngreso.TabIndex = 3;
            this.txtDescripcionIngreso.TextChanged += new System.EventHandler(this.txtDescripcionIngreso_TextChanged);
            // 
            // txtIngreso
            // 
            this.txtIngreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtIngreso.Location = new System.Drawing.Point(394, 187);
            this.txtIngreso.Margin = new System.Windows.Forms.Padding(4);
            this.txtIngreso.Name = "txtIngreso";
            this.txtIngreso.Size = new System.Drawing.Size(289, 30);
            this.txtIngreso.TabIndex = 4;
            // 
            // btnAgregarIngreso
            // 
            this.btnAgregarIngreso.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnAgregarIngreso.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAgregarIngreso.FlatAppearance.BorderSize = 0;
            this.btnAgregarIngreso.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregarIngreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnAgregarIngreso.ForeColor = System.Drawing.SystemColors.Info;
            this.btnAgregarIngreso.Location = new System.Drawing.Point(1292, 184);
            this.btnAgregarIngreso.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregarIngreso.Name = "btnAgregarIngreso";
            this.btnAgregarIngreso.Size = new System.Drawing.Size(457, 40);
            this.btnAgregarIngreso.TabIndex = 5;
            this.btnAgregarIngreso.Text = "Agregar registro";
            this.btnAgregarIngreso.UseVisualStyleBackColor = false;
            this.btnAgregarIngreso.Click += new System.EventHandler(this.btnAgregarIngreso_Click);
            // 
            // dgvIngresos
            // 
            this.dgvIngresos.AllowUserToAddRows = false;
            this.dgvIngresos.AllowUserToDeleteRows = false;
            this.dgvIngresos.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvIngresos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvIngresos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIngresos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Descripcion,
            this.Tipo,
            this.Monto,
            this.Cliente,
            this.Fecha});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvIngresos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvIngresos.Location = new System.Drawing.Point(24, 304);
            this.dgvIngresos.Margin = new System.Windows.Forms.Padding(4);
            this.dgvIngresos.Name = "dgvIngresos";
            this.dgvIngresos.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvIngresos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvIngresos.Size = new System.Drawing.Size(1725, 287);
            this.dgvIngresos.TabIndex = 6;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 60;
            // 
            // Descripcion
            // 
            this.Descripcion.DataPropertyName = "Descripcion";
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            this.Descripcion.Width = 350;
            // 
            // Tipo
            // 
            this.Tipo.DataPropertyName = "Tipo";
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.Name = "Tipo";
            this.Tipo.ReadOnly = true;
            // 
            // Monto
            // 
            this.Monto.DataPropertyName = "Monto";
            this.Monto.HeaderText = "Monto [$]";
            this.Monto.Name = "Monto";
            this.Monto.ReadOnly = true;
            // 
            // Cliente
            // 
            this.Cliente.DataPropertyName = "Nombre_Apellido";
            this.Cliente.HeaderText = "Cliente";
            this.Cliente.Name = "Cliente";
            this.Cliente.ReadOnly = true;
            // 
            // Fecha
            // 
            this.Fecha.DataPropertyName = "Fecha";
            this.Fecha.HeaderText = "Fecha ult. modificación";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            // 
            // lblSubtitle1
            // 
            this.lblSubtitle1.AutoSize = true;
            this.lblSubtitle1.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtitle1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lblSubtitle1.Location = new System.Drawing.Point(21, 259);
            this.lblSubtitle1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSubtitle1.Name = "lblSubtitle1";
            this.lblSubtitle1.Size = new System.Drawing.Size(220, 32);
            this.lblSubtitle1.TabIndex = 7;
            this.lblSubtitle1.Text = "Lista de ingresos";
            // 
            // btnBorrarIngreso
            // 
            this.btnBorrarIngreso.BackColor = System.Drawing.SystemColors.Window;
            this.btnBorrarIngreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnBorrarIngreso.Location = new System.Drawing.Point(268, 609);
            this.btnBorrarIngreso.Margin = new System.Windows.Forms.Padding(4);
            this.btnBorrarIngreso.Name = "btnBorrarIngreso";
            this.btnBorrarIngreso.Size = new System.Drawing.Size(208, 36);
            this.btnBorrarIngreso.TabIndex = 8;
            this.btnBorrarIngreso.Text = "Eliminar";
            this.btnBorrarIngreso.UseVisualStyleBackColor = false;
            this.btnBorrarIngreso.Click += new System.EventHandler(this.btnBorrarIngreso_Click);
            // 
            // btnEditarIngreso
            // 
            this.btnEditarIngreso.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnEditarIngreso.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEditarIngreso.FlatAppearance.BorderSize = 0;
            this.btnEditarIngreso.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEditarIngreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnEditarIngreso.ForeColor = System.Drawing.SystemColors.Info;
            this.btnEditarIngreso.Location = new System.Drawing.Point(24, 609);
            this.btnEditarIngreso.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditarIngreso.Name = "btnEditarIngreso";
            this.btnEditarIngreso.Size = new System.Drawing.Size(208, 36);
            this.btnEditarIngreso.TabIndex = 9;
            this.btnEditarIngreso.Text = "Editar";
            this.btnEditarIngreso.UseVisualStyleBackColor = false;
            this.btnEditarIngreso.Click += new System.EventHandler(this.btnEditarIngreso_Click);
            // 
            // btnCalcularIngresos
            // 
            this.btnCalcularIngresos.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnCalcularIngresos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnCalcularIngresos.Location = new System.Drawing.Point(316, 259);
            this.btnCalcularIngresos.Margin = new System.Windows.Forms.Padding(4);
            this.btnCalcularIngresos.Name = "btnCalcularIngresos";
            this.btnCalcularIngresos.Size = new System.Drawing.Size(480, 32);
            this.btnCalcularIngresos.TabIndex = 10;
            this.btnCalcularIngresos.Text = "Calcular ingresos";
            this.btnCalcularIngresos.UseVisualStyleBackColor = false;
            this.btnCalcularIngresos.Click += new System.EventHandler(this.btnCalcularIngresos_Click);
            // 
            // btnVolverIngreso
            // 
            this.btnVolverIngreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnVolverIngreso.Location = new System.Drawing.Point(1561, 609);
            this.btnVolverIngreso.Margin = new System.Windows.Forms.Padding(4);
            this.btnVolverIngreso.Name = "btnVolverIngreso";
            this.btnVolverIngreso.Size = new System.Drawing.Size(188, 36);
            this.btnVolverIngreso.TabIndex = 23;
            this.btnVolverIngreso.Text = "Volver";
            this.btnVolverIngreso.UseVisualStyleBackColor = true;
            this.btnVolverIngreso.Click += new System.EventHandler(this.btnVolverIngreso_Click);
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Arial", 12F);
            this.lblCliente.Location = new System.Drawing.Point(715, 157);
            this.lblCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(70, 23);
            this.lblCliente.TabIndex = 30;
            this.lblCliente.Text = "Cliente";
            // 
            // ddlClientes
            // 
            this.ddlClientes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ddlClientes.FormattingEnabled = true;
            this.ddlClientes.Location = new System.Drawing.Point(719, 184);
            this.ddlClientes.Margin = new System.Windows.Forms.Padding(4);
            this.ddlClientes.Name = "ddlClientes";
            this.ddlClientes.Size = new System.Drawing.Size(528, 33);
            this.ddlClientes.TabIndex = 29;
            // 
            // ddlTipo
            // 
            this.ddlTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ddlTipo.FormattingEnabled = true;
            this.ddlTipo.Location = new System.Drawing.Point(24, 182);
            this.ddlTipo.Margin = new System.Windows.Forms.Padding(4);
            this.ddlTipo.Name = "ddlTipo";
            this.ddlTipo.Size = new System.Drawing.Size(332, 33);
            this.ddlTipo.TabIndex = 27;
            this.ddlTipo.SelectedIndexChanged += new System.EventHandler(this.ddlTipo_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F);
            this.label1.Location = new System.Drawing.Point(23, 159);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 23);
            this.label1.TabIndex = 28;
            this.label1.Text = "Tipo";
            // 
            // lblMeses
            // 
            this.lblMeses.AutoSize = true;
            this.lblMeses.Font = new System.Drawing.Font("Arial", 12F);
            this.lblMeses.Location = new System.Drawing.Point(914, 235);
            this.lblMeses.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMeses.Name = "lblMeses";
            this.lblMeses.Size = new System.Drawing.Size(48, 23);
            this.lblMeses.TabIndex = 32;
            this.lblMeses.Text = "Mes";
            // 
            // ddlMeses
            // 
            this.ddlMeses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlMeses.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ddlMeses.FormattingEnabled = true;
            this.ddlMeses.Location = new System.Drawing.Point(915, 258);
            this.ddlMeses.Margin = new System.Windows.Forms.Padding(4);
            this.ddlMeses.Name = "ddlMeses";
            this.ddlMeses.Size = new System.Drawing.Size(332, 33);
            this.ddlMeses.TabIndex = 31;
            this.ddlMeses.SelectedIndexChanged += new System.EventHandler(this.ddlMeses_SelectedIndexChanged);
            // 
            // Ingresos
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
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1832, 656);
            this.Controls.Add(this.lblMeses);
            this.Controls.Add(this.ddlMeses);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.ddlClientes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ddlTipo);
            this.Controls.Add(this.btnVolverIngreso);
            this.Controls.Add(this.btnCalcularIngresos);
            this.Controls.Add(this.btnEditarIngreso);
            this.Controls.Add(this.btnBorrarIngreso);
            this.Controls.Add(this.lblSubtitle1);
            this.Controls.Add(this.dgvIngresos);
            this.Controls.Add(this.btnAgregarIngreso);
            this.Controls.Add(this.txtIngreso);
            this.Controls.Add(this.txtDescripcionIngreso);
            this.Controls.Add(this.lblIngreso);
            this.Controls.Add(this.lblDescripcionIngreso);
            this.Controls.Add(this.lblTittle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Ingresos";
            this.Text = "Ingresos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvIngresos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTittle;
        private System.Windows.Forms.Label lblDescripcionIngreso;
        private System.Windows.Forms.Label lblIngreso;
        private System.Windows.Forms.TextBox txtDescripcionIngreso;
        private System.Windows.Forms.TextBox txtIngreso;
        private System.Windows.Forms.Button btnAgregarIngreso;
        private System.Windows.Forms.DataGridView dgvIngresos;
        private System.Windows.Forms.Button btnBorrarIngreso;
        private System.Windows.Forms.Button btnEditarIngreso;
        private System.Windows.Forms.Button btnCalcularIngresos;
        private System.Windows.Forms.Button btnVolverIngreso;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.Label lblSubtitle1;
        private System.Windows.Forms.ComboBox ddlClientes;
        private System.Windows.Forms.ComboBox ddlTipo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMeses;
        private System.Windows.Forms.ComboBox ddlMeses;
    }
}