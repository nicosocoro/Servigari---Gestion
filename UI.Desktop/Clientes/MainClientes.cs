using Bussines.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.Desktop.Clientes;

namespace UI.Desktop.Clientes
{
    public partial class MainClientes : Form1
    {
        #region PROPIEDADES
        private int CeldaID
        {
            get
            {
                return dgvClientes.Columns["ID"].Index;
            }
        }
        private string SelectedID
        {
            get
            {
                return dgvClientes.SelectedCells[CeldaID].Value.ToString();
            }
        }
        #endregion

        #region EVENTOS
        public MainClientes()
        {
            InitializeComponent();
            dgvClientes.AutoGenerateColumns = false;

            CargarClientes();
        }

        //CONSULTA
        private void btnConsultarDatos_Click(object sender, EventArgs e)
        {
            ClientesEntity cli = CliLogic.GetCliente_ID(SelectedID);

            DatosCliente datosCliente = new DatosCliente(cli, Utiles.AccionEnum.TipoAccion.Consult);
            OpenForm(datosCliente);
        }

        //ALTA
        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            DatosCliente datosCliente = new DatosCliente();
            OpenForm(datosCliente);

            CargarClientes();
        }

        private void btnVolverCliente_Click(object sender, EventArgs e)
        {
            CloseForm(this);
        }

        //BAJA

        private void btnBorrarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr = MessageBox.Show("¿Estás seguro de borrar este cliente? No podrá deshacerlo luego", "¿Estás seguro?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                switch (dr)
                {
                    case DialogResult.Yes:
                        CliLogic.Save(SelectedID);
                        break;

                    case DialogResult.Cancel:
                        break;
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar cliente con ID " + SelectedID, "ERROR", MessageBoxButtons.OK);
            }

            finally
            {
                CargarClientes();
            }
        }

        //MODIFICACION

        private void btnEditarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                ClientesEntity cli = new ClientesEntity();

                if (dgvClientes.SelectedRows.Count > 0)
                {
                    string ID = dgvClientes.SelectedCells[CeldaID].Value.ToString();

                    cli = CliLogic.GetCliente_ID(ID);
                    DatosCliente datosCliente = new DatosCliente(cli, Utiles.AccionEnum.TipoAccion.Modify);
                    OpenForm(datosCliente);
                    //CliLogic.Save(cli, Utiles.AccionEnum.TipoAccion.Modify);
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error, intente de nuevo.", "ERROR", MessageBoxButtons.OK);
            }

            finally
            {
                CargarClientes();

            }
        }

        public void CargarClientes()
        {
            dgvClientes.DataSource = CliLogic.GetClientes();

        }
        #endregion

        #region FUNCIONES
        private void dgvClientes_SelectionChanged(object sender, EventArgs e)
        {
            List<Button> list = new List<Button> { btnConsultarDatos, btnEditarCliente, btnBorrarCliente };

            if (dgvClientes.SelectedRows.Count > 0)
                btn_Habilitado(list);

            else
                btn_Inhabilitado(list);

            if (btnConsultarDatos.Enabled)
            {
                btnConsultarDatos.BackColor = blanco;
                btnConsultarDatos.ForeColor = negro;
            }

        }
        #endregion
    }
}
