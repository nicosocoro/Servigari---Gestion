namespace UI.Desktop
{
    partial class CambiarDatos
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
            this.btnChange = new System.Windows.Forms.Button();
            this.txtChangeMonto = new System.Windows.Forms.TextBox();
            this.txtChangeDescripcion = new System.Windows.Forms.TextBox();
            this.lblChangeMonto = new System.Windows.Forms.Label();
            this.lblChangeDesc = new System.Windows.Forms.Label();
            this.lblTitleChange = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.ddlTipo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnChange
            // 
            this.btnChange.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnChange.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnChange.FlatAppearance.BorderSize = 0;
            this.btnChange.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnChange.ForeColor = System.Drawing.SystemColors.Info;
            this.btnChange.Location = new System.Drawing.Point(728, 93);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(106, 23);
            this.btnChange.TabIndex = 11;
            this.btnChange.Text = "Editar";
            this.btnChange.UseVisualStyleBackColor = false;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // txtChangeMonto
            // 
            this.txtChangeMonto.Location = new System.Drawing.Point(629, 95);
            this.txtChangeMonto.Name = "txtChangeMonto";
            this.txtChangeMonto.Size = new System.Drawing.Size(83, 20);
            this.txtChangeMonto.TabIndex = 10;
            this.txtChangeMonto.TextChanged += new System.EventHandler(this.txtIngreso_TextChanged);
            // 
            // txtChangeDescripcion
            // 
            this.txtChangeDescripcion.Location = new System.Drawing.Point(18, 95);
            this.txtChangeDescripcion.Name = "txtChangeDescripcion";
            this.txtChangeDescripcion.Size = new System.Drawing.Size(457, 20);
            this.txtChangeDescripcion.TabIndex = 9;
            // 
            // lblChangeMonto
            // 
            this.lblChangeMonto.AutoSize = true;
            this.lblChangeMonto.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChangeMonto.Location = new System.Drawing.Point(626, 63);
            this.lblChangeMonto.Name = "lblChangeMonto";
            this.lblChangeMonto.Size = new System.Drawing.Size(55, 16);
            this.lblChangeMonto.TabIndex = 8;
            this.lblChangeMonto.Text = "Ingreso";
            // 
            // lblChangeDesc
            // 
            this.lblChangeDesc.AutoSize = true;
            this.lblChangeDesc.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChangeDesc.Location = new System.Drawing.Point(15, 63);
            this.lblChangeDesc.Name = "lblChangeDesc";
            this.lblChangeDesc.Size = new System.Drawing.Size(82, 16);
            this.lblChangeDesc.TabIndex = 7;
            this.lblChangeDesc.Text = "Descripción";
            // 
            // lblTitleChange
            // 
            this.lblTitleChange.AutoSize = true;
            this.lblTitleChange.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleChange.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblTitleChange.Location = new System.Drawing.Point(12, 9);
            this.lblTitleChange.Name = "lblTitleChange";
            this.lblTitleChange.Size = new System.Drawing.Size(125, 35);
            this.lblTitleChange.TabIndex = 6;
            this.lblTitleChange.Text = "Ingresos";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.Location = new System.Drawing.Point(490, 63);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(35, 16);
            this.lblTipo.TabIndex = 12;
            this.lblTipo.Text = "Tipo";
            // 
            // ddlTipo
            // 
            this.ddlTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlTipo.FormattingEnabled = true;
            this.ddlTipo.Location = new System.Drawing.Point(493, 95);
            this.ddlTipo.Name = "ddlTipo";
            this.ddlTipo.Size = new System.Drawing.Size(121, 21);
            this.ddlTipo.TabIndex = 13;
            // 
            // CambiarDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 139);
            this.Controls.Add(this.ddlTipo);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.txtChangeMonto);
            this.Controls.Add(this.txtChangeDescripcion);
            this.Controls.Add(this.lblChangeMonto);
            this.Controls.Add(this.lblChangeDesc);
            this.Controls.Add(this.lblTitleChange);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "CambiarDatos";
            this.Text = "Editar";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CambiarDatos_FormClosing);
            this.Load += new System.EventHandler(this.CambiarDatos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.TextBox txtChangeMonto;
        private System.Windows.Forms.TextBox txtChangeDescripcion;
        private System.Windows.Forms.Label lblChangeMonto;
        private System.Windows.Forms.Label lblChangeDesc;
        private System.Windows.Forms.Label lblTitleChange;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.ComboBox ddlTipo;
    }
}