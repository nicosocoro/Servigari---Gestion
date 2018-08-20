using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bussines.Entities;
using Bussiness.Logic;

namespace UI.Desktop
{
    public partial class CambiarDatos : Form1
    {
        public MontoEntities MontoEntities;

        public CambiarDatos()
        {
            InitializeComponent();
        }

        public CambiarDatos(MontoEntities montoEntity)
            :this()
        {
            MontoEntities = montoEntity;

            switch (montoEntity.TipoMonto)
            {
                case TipoMonto.Ingreso:
                    this.lblTitleChange.Text = "Editar Ingreso";
                    break;
             
                case TipoMonto.Gasto:
                    this.lblTitleChange.Text = "Editar Gasto";
                    break;
            }

            this.txtChangeDescripcion.Text = montoEntity.Descripcion;
            this.txtChangeMonto.Text = montoEntity.Monto;
            
            this.ddlTipo.DataSource = IngLogic.GetTipos(false);
            
            /*
             it's necessary because it may happen a "tipo" item be deleted..
             then if you want to edit some register which has that "tipo"
             it will cause an error because it'll try to select its "tipo" in the combobox
             */
            foreach(var s in ddlTipo.Items)
            {
                if(s.ToString() == montoEntity.Tipo)
                {
                    this.ddlTipo.SelectedItem = montoEntity.Tipo;
                    break;
                }
                /*it's not necessary an "else" statement because ddlTipo.DataSource = ...
                 * already completes the combobox's list and will select the first item in 
                 * the list
                 */
            }
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            string error = "";

            MontoEntities.Descripcion = txtChangeDescripcion.Text;
            MontoEntities.Monto = txtChangeMonto.Text;
            MontoEntities.Tipo = ddlTipo.SelectedItem.ToString();

            error = Utiles.Validaciones.ValidarCampos(MontoEntities.Descripcion, MontoEntities.Monto);

            if(error == "")
            {
                IngLogic.Save(MontoEntities, Utiles.AccionEnum.TipoAccion.Modify);
                this.Close();   
            }

            else
            {
                MessageBox.Show(error, "Campos incompletos", MessageBoxButtons.OK);
            }                     
        }

        private void txtIngreso_TextChanged(object sender, EventArgs e)
        {

        }

        private void CambiarDatos_Load(object sender, EventArgs e)
        {

        }

        private void CambiarDatos_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
    }
}
