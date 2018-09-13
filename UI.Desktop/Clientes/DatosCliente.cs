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
using Bussiness.Logic.Clientes;

namespace UI.Desktop.Clientes
{
    public partial class DatosCliente : Form1
    {
        private List<TextBox> listTextbox;
        private ClienteLogic _cliLogic;
        public ClienteLogic cliLogic
        {
            get
            {
                if (_cliLogic == null)
                    _cliLogic = new ClienteLogic();

                return _cliLogic;
            }

            set
            {
                _cliLogic = value;
            }
        }

        public DatosCliente()
        {
            InitializeComponent();

            CargarListaTXT();
            btn_Inhabilitado(btnAceptar);

            lblError.ForeColor = rojo_error;
        }

        private void CargarListaTXT()
        {
            listTextbox = new List<TextBox> { txtNombre, txtApellido };
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (btnHabilitado)
                ConfirmCloseForm("¿Estás seguro que desea salir? ¡Se perderán todos los datos!");

            else
                this.Close();
        }

        private void textbox_Changed(object sender, EventArgs e)
        {
            if (ValidarTXT(listTextbox))
            {
                btn_Habilitado(btnAceptar);
                lblError.Visible = false;
            }
            else
                btn_Inhabilitado(btnAceptar);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnHabilitado)
                {
                    ClientesEntity cli = new ClientesEntity();

                    //cli.ID = cliLogic.GetLastID();
                    cli.Nombre = txtNombre.Text;
                    cli.Apellido = txtApellido.Text;
                    cli.Direccion = txtDireccion.Text;
                    cli.TelefonoFijo = txtFijo.Text;
                    cli.TelefonoCeluar = txtCelular.Text;
                    cli.TelefonoAlternativo = txtCelAlternativo.Text;
                    cli.Comentarios = txtComentarios.Text;
                    cli.FechaAlta = DateTime.Now;

                    cliLogic.Save(cli, Utiles.AccionEnum.TipoAccion.Add);
                }
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
