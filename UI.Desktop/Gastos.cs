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
    public partial class Gastos : Form1
    {
        public Gastos()
        {
            InitializeComponent();
            ListarGastos();
        }

        private void ListarGastos()
        {
            this.ddlTipo.DataSource = IngLogic.GetTipos(true);
            dgvGastos.DataSource = IngLogic.GetGastos();
        }

        private void lblIngreso_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregarGasto_Click(object sender, EventArgs e)
        {
            string error = "";

            MontoEntities montoEntity = new MontoEntities(TipoMonto.Gasto);
            Utiles.AccionEnum.TipoAccion tipoAccion = Utiles.AccionEnum.TipoAccion.Add;
            
            montoEntity.Descripcion = txtDescripcionGasto.Text;
            montoEntity.Monto = txtGasto.Text;
            montoEntity.Tipo = ddlTipo.SelectedItem.ToString();

            error = Utiles.Validaciones.ValidarCampos(montoEntity.Descripcion, montoEntity.Monto);

            if (error == "")
            {
                IngLogic.Save(montoEntity, tipoAccion);

                txtDescripcionGasto.Clear();
                txtGasto.Clear();

                ListarGastos();
            }

            else
            {
                MessageBox.Show(error, "Campos incompletos", MessageBoxButtons.OK);
            }
        }

        private void btnEditarGasto_Click_1(object sender, EventArgs e)
        {
            MontoEntities montoEntity = new MontoEntities(TipoMonto.Gasto);

            if (dgvGastos.SelectedRows.Count > 0)
            {
                montoEntity.ID = int.Parse(dgvGastos.SelectedCells[0].Value.ToString());
                montoEntity.Descripcion = dgvGastos.SelectedCells[1].Value.ToString();
                montoEntity.Tipo = dgvGastos.SelectedCells[4].Value.ToString();
                montoEntity.Monto = dgvGastos.SelectedCells[2].Value.ToString();
                                
                CambiarDatos cambiarDatos = new CambiarDatos(montoEntity);
                cambiarDatos.ShowDialog();

                this.ListarGastos();
            }
        }

        private void btnBorrarGasto_Click_1(object sender, EventArgs e)
        {
            MontoEntities montoEntity = new MontoEntities(TipoMonto.Gasto);

            if (dgvGastos.SelectedRows.Count > 0)
            {
                montoEntity.ID = int.Parse(dgvGastos.SelectedCells[0].Value.ToString());
            }

            IngLogic.Save(montoEntity, Utiles.AccionEnum.TipoAccion.Delete);
            ListarGastos();
        }

        private void btnVolverGasto_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalcularIngresos_Click(object sender, EventArgs e)
        {
            CalcularTotal calTotal = new CalcularTotal("Gastos.xml");
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
    }
}
