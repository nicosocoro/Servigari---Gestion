using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bussiness.Logic;
using Bussines.Entities;

namespace UI.Desktop
{
    public partial class Ingresos : Form1
    {
        public Ingresos()
        {
            InitializeComponent();
            ListarIngresos();
        }

        private void ListarIngresos()
        {
            this.ddlTipo.DataSource = IngLogic.GetTipos(true);
            dgvIngresos.DataSource = IngLogic.GetIngresos();
        }

        private void lblIngreso_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregarIngreso_Click(object sender, EventArgs e)
        {
            string error = "";

            MontoEntities montoEntity = new MontoEntities(TipoMonto.Ingreso);
            Utiles.AccionEnum.TipoAccion tipoAccion = Utiles.AccionEnum.TipoAccion.Add;

            montoEntity.Descripcion = Utiles.FirstToUpper.ToUpper(txtDescripcionIngreso.Text);
            montoEntity.Monto = txtIngreso.Text;
            montoEntity.Tipo = ddlTipo.SelectedItem.ToString();

            error = Utiles.Validaciones.ValidarCampos(montoEntity.Descripcion, montoEntity.Monto);

            if (this.ddlTipo.SelectedItem.ToString() == "Agregar nuevo...")
            {
                error += "Seleccione otro Tipo";
            }

            if (error == "")
            {
                IngLogic.Save(montoEntity, tipoAccion);

                txtDescripcionIngreso.Clear();
                txtIngreso.Clear();

                ListarIngresos();
            }

            else
            {
                MessageBox.Show(error, "Campos incompletos", MessageBoxButtons.OK);
            }
        }

        private void btnEditarIngreso_Click(object sender, EventArgs e)
        {
            MontoEntities montoEntity = new MontoEntities(TipoMonto.Ingreso);

            if (dgvIngresos.SelectedRows.Count > 0)
            {
                montoEntity.ID = int.Parse(dgvIngresos.SelectedCells[0].Value.ToString());
                montoEntity.Descripcion = dgvIngresos.SelectedCells[1].Value.ToString();
                montoEntity.Tipo = dgvIngresos.SelectedCells[4].Value.ToString();
                montoEntity.Monto = dgvIngresos.SelectedCells[2].Value.ToString();

                CambiarDatos cambiarDatos = new CambiarDatos(montoEntity);
                cambiarDatos.ShowDialog();

                this.ListarIngresos();
            }
        }

        private void btnBorrarIngreso_Click(object sender, EventArgs e)
        {
            MontoEntities montoEntity = new MontoEntities(TipoMonto.Ingreso);

            if (dgvIngresos.SelectedRows.Count > 0)
            {
                montoEntity.ID = int.Parse(dgvIngresos.SelectedCells[0].Value.ToString());
            }

            DialogResult dr = MessageBox.Show("¿Estás seguro de borrar este registro? No podrá deshacerlo luego", "¿Estás seguro?",  MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            switch(dr)
            {
                case DialogResult.Yes:
                    IngLogic.Save(montoEntity, Utiles.AccionEnum.TipoAccion.Delete);
                    ListarIngresos();
                    break;

                case DialogResult.Cancel:
                    break;
            }
        }

        private void btnActualizarIngresos_Click(object sender, EventArgs e)
        {
            this.ListarIngresos();
        }

        private void CambiarDatos_FormClosing(object sender, FormClosedEventArgs e)
        {
            this.ListarIngresos();
        }

        private void btnVolverIngreso_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalcularIngresos_Click(object sender, EventArgs e)
        {
            CalcularTotal calTotal = new CalcularTotal("Ingresos.xml");
            calTotal.ShowDialog();
        }

        private void ddlTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlTipo.SelectedItem.ToString() == "Agregar nuevo...")
            {
                AgregarTipo agTipo = new AgregarTipo();
                agTipo.ShowDialog();

                this.ddlTipo.DataSource = IngLogic.GetTipos(true);
            }

            if (ddlTipo.SelectedItem.ToString() == "Borrar existente...")
            {
                BorrarTipo borrarTipo = new BorrarTipo();
                borrarTipo.ShowDialog();

                this.ddlTipo.DataSource = IngLogic.GetTipos(true);
            }
        }

        private void txtDescripcionIngreso_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
