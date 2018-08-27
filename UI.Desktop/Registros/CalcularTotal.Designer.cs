namespace UI.Desktop
{
    partial class CalcularTotal
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
            Bussiness.Logic.IngresoLogic ingresoLogic1 = new Bussiness.Logic.IngresoLogic();
            this.ddlMeses = new System.Windows.Forms.ComboBox();
            this.lblTittleCalculo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.ddlTipos = new System.Windows.Forms.ComboBox();
            this.btnTotal = new System.Windows.Forms.Button();
            this.ddlAños = new System.Windows.Forms.ComboBox();
            this.lblAño = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ddlMeses
            // 
            this.ddlMeses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlMeses.FormattingEnabled = true;
            this.ddlMeses.Items.AddRange(new object[] {
            "Todo",
            "Enero",
            "Febrero",
            "Marzo",
            "Abril",
            "Mayo",
            "Junio",
            "Julio",
            "Agosto",
            "Septiembre",
            "Octubre",
            "Noviembre",
            "Diciembre"});
            this.ddlMeses.Location = new System.Drawing.Point(33, 117);
            this.ddlMeses.Margin = new System.Windows.Forms.Padding(4);
            this.ddlMeses.Name = "ddlMeses";
            this.ddlMeses.Size = new System.Drawing.Size(177, 24);
            this.ddlMeses.TabIndex = 0;
            this.ddlMeses.SelectedIndexChanged += new System.EventHandler(this.ddlMeses_SelectedIndexChanged);
            // 
            // lblTittleCalculo
            // 
            this.lblTittleCalculo.AutoSize = true;
            this.lblTittleCalculo.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTittleCalculo.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblTittleCalculo.Location = new System.Drawing.Point(25, 11);
            this.lblTittleCalculo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTittleCalculo.Name = "lblTittleCalculo";
            this.lblTittleCalculo.Size = new System.Drawing.Size(140, 43);
            this.lblTittleCalculo.TabIndex = 12;
            this.lblTittleCalculo.Text = "Calculo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 81);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Elige mes";
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtTotal.Location = new System.Drawing.Point(648, 182);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(4);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(99, 22);
            this.txtTotal.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(580, 182);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Total:";
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(33, 174);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(4);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(100, 28);
            this.btnVolver.TabIndex = 16;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(432, 81);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "Tipo";
            // 
            // ddlTipos
            // 
            this.ddlTipos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlTipos.FormattingEnabled = true;
            this.ddlTipos.Location = new System.Drawing.Point(436, 117);
            this.ddlTipos.Margin = new System.Windows.Forms.Padding(4);
            this.ddlTipos.Name = "ddlTipos";
            this.ddlTipos.Size = new System.Drawing.Size(160, 24);
            this.ddlTipos.TabIndex = 18;
            // 
            // btnTotal
            // 
            this.btnTotal.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnTotal.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnTotal.FlatAppearance.BorderSize = 0;
            this.btnTotal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTotal.Location = new System.Drawing.Point(648, 117);
            this.btnTotal.Margin = new System.Windows.Forms.Padding(4);
            this.btnTotal.Name = "btnTotal";
            this.btnTotal.Size = new System.Drawing.Size(100, 26);
            this.btnTotal.TabIndex = 19;
            this.btnTotal.Text = "Total";
            this.btnTotal.UseVisualStyleBackColor = false;
            this.btnTotal.Click += new System.EventHandler(this.btnTotal_Click);
            // 
            // ddlAños
            // 
            this.ddlAños.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlAños.FormattingEnabled = true;
            this.ddlAños.Location = new System.Drawing.Point(244, 117);
            this.ddlAños.Margin = new System.Windows.Forms.Padding(4);
            this.ddlAños.Name = "ddlAños";
            this.ddlAños.Size = new System.Drawing.Size(160, 24);
            this.ddlAños.TabIndex = 21;
            this.ddlAños.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lblAño
            // 
            this.lblAño.AutoSize = true;
            this.lblAño.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAño.Location = new System.Drawing.Point(240, 81);
            this.lblAño.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAño.Name = "lblAño";
            this.lblAño.Size = new System.Drawing.Size(38, 20);
            this.lblAño.TabIndex = 20;
            this.lblAño.Text = "Año";
            // 
            // CalcularTotal
            //            
            this._IngLogic = ingresoLogic1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 233);
            this.Controls.Add(this.ddlAños);
            this.Controls.Add(this.lblAño);
            this.Controls.Add(this.btnTotal);
            this.Controls.Add(this.ddlTipos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTittleCalculo);
            this.Controls.Add(this.ddlMeses);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "CalcularTotal";
            this.Text = "CalcularTotal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ddlMeses;
        private System.Windows.Forms.Label lblTittleCalculo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox ddlTipos;
        private System.Windows.Forms.Button btnTotal;
        private System.Windows.Forms.ComboBox ddlAños;
        private System.Windows.Forms.Label lblAño;
    }
}