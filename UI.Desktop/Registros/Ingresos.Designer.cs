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
            Bussiness.Logic.Clientes.ClienteLogic clienteLogic1 = new Bussiness.Logic.Clientes.ClienteLogic();
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
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblSubtitle1 = new System.Windows.Forms.Label();
            this.btnBorrarIngreso = new System.Windows.Forms.Button();
            this.btnEditarIngreso = new System.Windows.Forms.Button();
            this.btnCalcularIngresos = new System.Windows.Forms.Button();
            this.btnVolverIngreso = new System.Windows.Forms.Button();
            this.ddlTipo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
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
            this.lblDescripcionIngreso.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcionIngreso.Location = new System.Drawing.Point(20, 75);
            this.lblDescripcionIngreso.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescripcionIngreso.Name = "lblDescripcionIngreso";
            this.lblDescripcionIngreso.Size = new System.Drawing.Size(97, 19);
            this.lblDescripcionIngreso.TabIndex = 1;
            this.lblDescripcionIngreso.Text = "Descripción";
            // 
            // lblIngreso
            // 
            this.lblIngreso.AutoSize = true;
            this.lblIngreso.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngreso.Location = new System.Drawing.Point(1025, 75);
            this.lblIngreso.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIngreso.Name = "lblIngreso";
            this.lblIngreso.Size = new System.Drawing.Size(64, 19);
            this.lblIngreso.TabIndex = 2;
            this.lblIngreso.Text = "Ingreso";
            this.lblIngreso.Click += new System.EventHandler(this.lblIngreso_Click);
            // 
            // txtDescripcionIngreso
            // 
            this.txtDescripcionIngreso.Location = new System.Drawing.Point(24, 111);
            this.txtDescripcionIngreso.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDescripcionIngreso.Name = "txtDescripcionIngreso";
            this.txtDescripcionIngreso.Size = new System.Drawing.Size(789, 22);
            this.txtDescripcionIngreso.TabIndex = 3;
            this.txtDescripcionIngreso.TextChanged += new System.EventHandler(this.txtDescripcionIngreso_TextChanged);
            // 
            // txtIngreso
            // 
            this.txtIngreso.Location = new System.Drawing.Point(1029, 108);
            this.txtIngreso.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtIngreso.Name = "txtIngreso";
            this.txtIngreso.Size = new System.Drawing.Size(137, 22);
            this.txtIngreso.TabIndex = 4;
            // 
            // btnAgregarIngreso
            // 
            this.btnAgregarIngreso.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnAgregarIngreso.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAgregarIngreso.FlatAppearance.BorderSize = 0;
            this.btnAgregarIngreso.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregarIngreso.ForeColor = System.Drawing.SystemColors.Info;
            this.btnAgregarIngreso.Location = new System.Drawing.Point(1174, 105);
            this.btnAgregarIngreso.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAgregarIngreso.Name = "btnAgregarIngreso";
            this.btnAgregarIngreso.Size = new System.Drawing.Size(168, 28);
            this.btnAgregarIngreso.TabIndex = 5;
            this.btnAgregarIngreso.Text = "Agregar";
            this.btnAgregarIngreso.UseVisualStyleBackColor = false;
            this.btnAgregarIngreso.Click += new System.EventHandler(this.btnAgregarIngreso_Click);
            // 
            // dgvIngresos
            // 
            this.dgvIngresos.AllowUserToAddRows = false;
            this.dgvIngresos.AllowUserToDeleteRows = false;
            this.dgvIngresos.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvIngresos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIngresos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Descripcion,
            this.Tipo,
            this.Monto,
            this.Fecha});
            this.dgvIngresos.Location = new System.Drawing.Point(24, 214);
            this.dgvIngresos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvIngresos.Name = "dgvIngresos";
            this.dgvIngresos.ReadOnly = true;
            this.dgvIngresos.Size = new System.Drawing.Size(1318, 287);
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
            this.lblSubtitle1.Location = new System.Drawing.Point(17, 167);
            this.lblSubtitle1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSubtitle1.Name = "lblSubtitle1";
            this.lblSubtitle1.Size = new System.Drawing.Size(220, 32);
            this.lblSubtitle1.TabIndex = 7;
            this.lblSubtitle1.Text = "Lista de ingresos";
            // 
            // btnBorrarIngreso
            // 
            this.btnBorrarIngreso.BackColor = System.Drawing.SystemColors.Window;
            this.btnBorrarIngreso.Location = new System.Drawing.Point(268, 523);
            this.btnBorrarIngreso.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBorrarIngreso.Name = "btnBorrarIngreso";
            this.btnBorrarIngreso.Size = new System.Drawing.Size(208, 28);
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
            this.btnEditarIngreso.ForeColor = System.Drawing.SystemColors.Info;
            this.btnEditarIngreso.Location = new System.Drawing.Point(24, 523);
            this.btnEditarIngreso.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEditarIngreso.Name = "btnEditarIngreso";
            this.btnEditarIngreso.Size = new System.Drawing.Size(208, 28);
            this.btnEditarIngreso.TabIndex = 9;
            this.btnEditarIngreso.Text = "Editar";
            this.btnEditarIngreso.UseVisualStyleBackColor = false;
            this.btnEditarIngreso.Click += new System.EventHandler(this.btnEditarIngreso_Click);
            // 
            // btnCalcularIngresos
            // 
            this.btnCalcularIngresos.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnCalcularIngresos.Location = new System.Drawing.Point(323, 169);
            this.btnCalcularIngresos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCalcularIngresos.Name = "btnCalcularIngresos";
            this.btnCalcularIngresos.Size = new System.Drawing.Size(325, 28);
            this.btnCalcularIngresos.TabIndex = 10;
            this.btnCalcularIngresos.Text = "Calcular ingresos";
            this.btnCalcularIngresos.UseVisualStyleBackColor = false;
            this.btnCalcularIngresos.Click += new System.EventHandler(this.btnCalcularIngresos_Click);
            // 
            // btnVolverIngreso
            // 
            this.btnVolverIngreso.Location = new System.Drawing.Point(1154, 523);
            this.btnVolverIngreso.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnVolverIngreso.Name = "btnVolverIngreso";
            this.btnVolverIngreso.Size = new System.Drawing.Size(188, 28);
            this.btnVolverIngreso.TabIndex = 23;
            this.btnVolverIngreso.Text = "Volver";
            this.btnVolverIngreso.UseVisualStyleBackColor = true;
            this.btnVolverIngreso.Click += new System.EventHandler(this.btnVolverIngreso_Click);
            // 
            // ddlTipo
            // 
            this.ddlTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlTipo.FormattingEnabled = true;
            this.ddlTipo.Location = new System.Drawing.Point(832, 109);
            this.ddlTipo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ddlTipo.Name = "ddlTipo";
            this.ddlTipo.Size = new System.Drawing.Size(177, 24);
            this.ddlTipo.TabIndex = 27;
            this.ddlTipo.SelectedIndexChanged += new System.EventHandler(this.ddlTipo_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(831, 76);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 19);
            this.label1.TabIndex = 28;
            this.label1.Text = "Tipo";
            // 
            // Ingresos
            // 
            clienteLogic1._RecordManejador = null;
            clienteLogic1._TiposManejador = null;
            this._CliLogic = clienteLogic1;
            ingresoLogic1._RecordManejador = null;
            ingresoLogic1._TiposManejador = null;
            this._IngLogic = ingresoLogic1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1371, 570);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "Ingresos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
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
        private System.Windows.Forms.Label lblSubtitle1;
        private System.Windows.Forms.Button btnBorrarIngreso;
        private System.Windows.Forms.Button btnEditarIngreso;
        private System.Windows.Forms.Button btnCalcularIngresos;
        private System.Windows.Forms.Button btnVolverIngreso;
        private System.Windows.Forms.ComboBox ddlTipo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
    }
}