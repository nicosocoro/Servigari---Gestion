﻿namespace UI.Desktop
{
    partial class Gastos
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
            this.lblSubtitleGasto = new System.Windows.Forms.Label();
            this.dgvGastos = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAgregarGasto = new System.Windows.Forms.Button();
            this.txtGasto = new System.Windows.Forms.TextBox();
            this.txtDescripcionGasto = new System.Windows.Forms.TextBox();
            this.lblGasto = new System.Windows.Forms.Label();
            this.lblDescripcionGasto = new System.Windows.Forms.Label();
            this.lblTittleGasto = new System.Windows.Forms.Label();
            this.btnEditarGasto = new System.Windows.Forms.Button();
            this.btnBorrarGasto = new System.Windows.Forms.Button();
            this.btnVolverGasto = new System.Windows.Forms.Button();
            this.btnCalcularIngresos = new System.Windows.Forms.Button();
            this.ddlTipo = new System.Windows.Forms.ComboBox();
            this.lblTipo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGastos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSubtitleGasto
            // 
            this.lblSubtitleGasto.AutoSize = true;
            this.lblSubtitleGasto.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtitleGasto.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lblSubtitleGasto.Location = new System.Drawing.Point(17, 167);
            this.lblSubtitleGasto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSubtitleGasto.Name = "lblSubtitleGasto";
            this.lblSubtitleGasto.Size = new System.Drawing.Size(196, 32);
            this.lblSubtitleGasto.TabIndex = 18;
            this.lblSubtitleGasto.Text = "Lista de gastos";
            // 
            // dgvGastos
            // 
            this.dgvGastos.AllowUserToAddRows = false;
            this.dgvGastos.AllowUserToDeleteRows = false;
            this.dgvGastos.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvGastos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGastos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Descripcion,
            this.Tipo,
            this.Monto,
            this.Fecha});
            this.dgvGastos.Location = new System.Drawing.Point(24, 214);
            this.dgvGastos.Margin = new System.Windows.Forms.Padding(4);
            this.dgvGastos.Name = "dgvGastos";
            this.dgvGastos.ReadOnly = true;
            this.dgvGastos.Size = new System.Drawing.Size(1318, 287);
            this.dgvGastos.TabIndex = 17;
            this.dgvGastos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGastos_CellContentClick);
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
            this.Fecha.Width = 150;
            // 
            // btnAgregarGasto
            // 
            this.btnAgregarGasto.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnAgregarGasto.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAgregarGasto.FlatAppearance.BorderSize = 0;
            this.btnAgregarGasto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregarGasto.ForeColor = System.Drawing.SystemColors.Info;
            this.btnAgregarGasto.Location = new System.Drawing.Point(1201, 105);
            this.btnAgregarGasto.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregarGasto.Name = "btnAgregarGasto";
            this.btnAgregarGasto.Size = new System.Drawing.Size(141, 28);
            this.btnAgregarGasto.TabIndex = 16;
            this.btnAgregarGasto.Text = "Agregar";
            this.btnAgregarGasto.UseVisualStyleBackColor = false;
            this.btnAgregarGasto.Click += new System.EventHandler(this.btnAgregarGasto_Click);
            // 
            // txtGasto
            // 
            this.txtGasto.Location = new System.Drawing.Point(1029, 108);
            this.txtGasto.Margin = new System.Windows.Forms.Padding(4);
            this.txtGasto.Name = "txtGasto";
            this.txtGasto.Size = new System.Drawing.Size(137, 22);
            this.txtGasto.TabIndex = 15;
            // 
            // txtDescripcionGasto
            // 
            this.txtDescripcionGasto.Location = new System.Drawing.Point(24, 111);
            this.txtDescripcionGasto.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescripcionGasto.Name = "txtDescripcionGasto";
            this.txtDescripcionGasto.Size = new System.Drawing.Size(789, 22);
            this.txtDescripcionGasto.TabIndex = 14;
            // 
            // lblGasto
            // 
            this.lblGasto.AutoSize = true;
            this.lblGasto.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGasto.Location = new System.Drawing.Point(1025, 76);
            this.lblGasto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGasto.Name = "lblGasto";
            this.lblGasto.Size = new System.Drawing.Size(51, 19);
            this.lblGasto.TabIndex = 13;
            this.lblGasto.Text = "Gasto";
            // 
            // lblDescripcionGasto
            // 
            this.lblDescripcionGasto.AutoSize = true;
            this.lblDescripcionGasto.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcionGasto.Location = new System.Drawing.Point(20, 75);
            this.lblDescripcionGasto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescripcionGasto.Name = "lblDescripcionGasto";
            this.lblDescripcionGasto.Size = new System.Drawing.Size(97, 19);
            this.lblDescripcionGasto.TabIndex = 12;
            this.lblDescripcionGasto.Text = "Descripción";
            // 
            // lblTittleGasto
            // 
            this.lblTittleGasto.AutoSize = true;
            this.lblTittleGasto.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTittleGasto.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblTittleGasto.Location = new System.Drawing.Point(16, 11);
            this.lblTittleGasto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTittleGasto.Name = "lblTittleGasto";
            this.lblTittleGasto.Size = new System.Drawing.Size(128, 43);
            this.lblTittleGasto.TabIndex = 11;
            this.lblTittleGasto.Text = "Gastos";
            this.lblTittleGasto.Click += new System.EventHandler(this.lblTittleGasto_Click);
            // 
            // btnEditarGasto
            // 
            this.btnEditarGasto.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnEditarGasto.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEditarGasto.FlatAppearance.BorderSize = 0;
            this.btnEditarGasto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEditarGasto.ForeColor = System.Drawing.SystemColors.Info;
            this.btnEditarGasto.Location = new System.Drawing.Point(24, 523);
            this.btnEditarGasto.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditarGasto.Name = "btnEditarGasto";
            this.btnEditarGasto.Size = new System.Drawing.Size(208, 28);
            this.btnEditarGasto.TabIndex = 21;
            this.btnEditarGasto.Text = "Editar";
            this.btnEditarGasto.UseVisualStyleBackColor = false;
            this.btnEditarGasto.Click += new System.EventHandler(this.btnEditarGasto_Click_1);
            // 
            // btnBorrarGasto
            // 
            this.btnBorrarGasto.BackColor = System.Drawing.SystemColors.Window;
            this.btnBorrarGasto.Location = new System.Drawing.Point(268, 523);
            this.btnBorrarGasto.Margin = new System.Windows.Forms.Padding(4);
            this.btnBorrarGasto.Name = "btnBorrarGasto";
            this.btnBorrarGasto.Size = new System.Drawing.Size(208, 28);
            this.btnBorrarGasto.TabIndex = 20;
            this.btnBorrarGasto.Text = "Eliminar";
            this.btnBorrarGasto.UseVisualStyleBackColor = false;
            this.btnBorrarGasto.Click += new System.EventHandler(this.btnBorrarGasto_Click_1);
            // 
            // btnVolverGasto
            // 
            this.btnVolverGasto.Location = new System.Drawing.Point(1154, 523);
            this.btnVolverGasto.Margin = new System.Windows.Forms.Padding(4);
            this.btnVolverGasto.Name = "btnVolverGasto";
            this.btnVolverGasto.Size = new System.Drawing.Size(188, 28);
            this.btnVolverGasto.TabIndex = 22;
            this.btnVolverGasto.Text = "Volver";
            this.btnVolverGasto.UseVisualStyleBackColor = true;
            this.btnVolverGasto.Click += new System.EventHandler(this.btnVolverGasto_Click);
            // 
            // btnCalcularIngresos
            // 
            this.btnCalcularIngresos.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnCalcularIngresos.Location = new System.Drawing.Point(323, 172);
            this.btnCalcularIngresos.Margin = new System.Windows.Forms.Padding(4);
            this.btnCalcularIngresos.Name = "btnCalcularIngresos";
            this.btnCalcularIngresos.Size = new System.Drawing.Size(325, 28);
            this.btnCalcularIngresos.TabIndex = 23;
            this.btnCalcularIngresos.Text = "Calcular gastos";
            this.btnCalcularIngresos.UseVisualStyleBackColor = false;
            this.btnCalcularIngresos.Click += new System.EventHandler(this.btnCalcularIngresos_Click);
            // 
            // ddlTipo
            // 
            this.ddlTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlTipo.FormattingEnabled = true;
            this.ddlTipo.Location = new System.Drawing.Point(832, 109);
            this.ddlTipo.Margin = new System.Windows.Forms.Padding(4);
            this.ddlTipo.Name = "ddlTipo";
            this.ddlTipo.Size = new System.Drawing.Size(177, 24);
            this.ddlTipo.TabIndex = 25;
            this.ddlTipo.SelectedIndexChanged += new System.EventHandler(this.ddlTipo_SelectedIndexChanged);
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.Location = new System.Drawing.Point(831, 76);
            this.lblTipo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(39, 19);
            this.lblTipo.TabIndex = 26;
            this.lblTipo.Text = "Tipo";
            // 
            // Gastos
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
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.ddlTipo);
            this.Controls.Add(this.btnCalcularIngresos);
            this.Controls.Add(this.btnVolverGasto);
            this.Controls.Add(this.btnEditarGasto);
            this.Controls.Add(this.btnBorrarGasto);
            this.Controls.Add(this.lblSubtitleGasto);
            this.Controls.Add(this.dgvGastos);
            this.Controls.Add(this.btnAgregarGasto);
            this.Controls.Add(this.txtGasto);
            this.Controls.Add(this.txtDescripcionGasto);
            this.Controls.Add(this.lblGasto);
            this.Controls.Add(this.lblDescripcionGasto);
            this.Controls.Add(this.lblTittleGasto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Gastos";
            this.Text = "Gastos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvGastos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblSubtitleGasto;
        private System.Windows.Forms.DataGridView dgvGastos;
        private System.Windows.Forms.Button btnAgregarGasto;
        private System.Windows.Forms.TextBox txtGasto;
        private System.Windows.Forms.TextBox txtDescripcionGasto;
        private System.Windows.Forms.Label lblDescripcionGasto;
        private System.Windows.Forms.Label lblTittleGasto;
        private System.Windows.Forms.Button btnEditarGasto;
        private System.Windows.Forms.Button btnBorrarGasto;
        private System.Windows.Forms.Button btnVolverGasto;
        private System.Windows.Forms.Button btnCalcularIngresos;
        private System.Windows.Forms.ComboBox ddlTipo;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.Label lblGasto;
    }
}