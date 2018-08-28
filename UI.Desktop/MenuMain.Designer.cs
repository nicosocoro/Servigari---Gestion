namespace UI.Desktop
{
    partial class MenuMain
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
            this.btnIngresos = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnGastos = new System.Windows.Forms.Button();
            this.lblMainTitle = new System.Windows.Forms.Label();
            this.lblClientesTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnIngresos
            // 
            this.btnIngresos.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnIngresos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnIngresos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngresos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnIngresos.Location = new System.Drawing.Point(132, 110);
            this.btnIngresos.Name = "btnIngresos";
            this.btnIngresos.Size = new System.Drawing.Size(570, 40);
            this.btnIngresos.TabIndex = 0;
            this.btnIngresos.Text = "Ingresos";
            this.btnIngresos.UseVisualStyleBackColor = false;
            this.btnIngresos.Click += new System.EventHandler(this.btnIngresos_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnClientes.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientes.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClientes.Location = new System.Drawing.Point(132, 316);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(570, 40);
            this.btnClientes.TabIndex = 3;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.UseVisualStyleBackColor = false;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // btnGastos
            // 
            this.btnGastos.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnGastos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnGastos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGastos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGastos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGastos.Location = new System.Drawing.Point(132, 169);
            this.btnGastos.Name = "btnGastos";
            this.btnGastos.Size = new System.Drawing.Size(570, 40);
            this.btnGastos.TabIndex = 4;
            this.btnGastos.Text = "Gastos";
            this.btnGastos.UseVisualStyleBackColor = false;
            this.btnGastos.Click += new System.EventHandler(this.btnGastos_Click);
            // 
            // lblMainTitle
            // 
            this.lblMainTitle.AutoSize = true;
            this.lblMainTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainTitle.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblMainTitle.Location = new System.Drawing.Point(185, 31);
            this.lblMainTitle.Name = "lblMainTitle";
            this.lblMainTitle.Size = new System.Drawing.Size(455, 39);
            this.lblMainTitle.TabIndex = 5;
            this.lblMainTitle.Text = "Servigari - Gestión financiera";
            // 
            // lblClientesTitle
            // 
            this.lblClientesTitle.AutoSize = true;
            this.lblClientesTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientesTitle.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblClientesTitle.Location = new System.Drawing.Point(269, 259);
            this.lblClientesTitle.Name = "lblClientesTitle";
            this.lblClientesTitle.Size = new System.Drawing.Size(306, 39);
            this.lblClientesTitle.TabIndex = 6;
            this.lblClientesTitle.Text = "Gestión de clientes";
            // 
            // MenuMain
            // 
            clienteLogic1._RecordManejador = null;
            clienteLogic1._TiposManejador = null;
            this._CliLogic = clienteLogic1;
            ingresoLogic1._RecordManejador = null;
            ingresoLogic1._TiposManejador = null;
            this._IngLogic = ingresoLogic1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 416);
            this.Controls.Add(this.lblClientesTitle);
            this.Controls.Add(this.lblMainTitle);
            this.Controls.Add(this.btnGastos);
            this.Controls.Add(this.btnClientes);
            this.Controls.Add(this.btnIngresos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MenuMain";
            this.Text = "Menú principal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIngresos;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnGastos;
        private System.Windows.Forms.Label lblMainTitle;
        private System.Windows.Forms.Label lblClientesTitle;
    }
}