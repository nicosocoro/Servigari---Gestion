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

        public string ID { get; set; }

        public Utiles.AccionEnum.TipoAccion tipoAccion;

        public DatosCliente()
        {
            InitializeComponent();
            btnAceptar.Text = "Agregar";
            CargarListaTXT();
            btn_Inhabilitado(btnAceptar);

            lblError.ForeColor = rojo_error;
        }

        public DatosCliente(Utiles.AccionEnum.TipoAccion oTipoAccion)
            : this()
        {
            tipoAccion = oTipoAccion;
        }

        public DatosCliente(ClientesEntity oCliente, Utiles.AccionEnum.TipoAccion oTipoAccion)
            : this(oTipoAccion)
        {
            txtNombre.Text = oCliente.Nombre;
            txtApellido.Text = oCliente.Apellido;
            txtFijo.Text = oCliente.TelefonoFijo;
            txtCelular.Text = oCliente.TelefonoCelular;
            txtCelAlternativo.Text = oCliente.TelefonoAlternativo;
            txtDireccion.Text = oCliente.Direccion;
            txtComentarios.Text = oCliente.Comentarios;

            switch (tipoAccion)
            {
                case Utiles.AccionEnum.TipoAccion.Consult:
                    EnableTextBox(false);
                    btnAceptar.Visible = false;
                    break;

                case Utiles.AccionEnum.TipoAccion.Modify:
                    EnableTextBox(true);
                    btnAceptar.Text = "Editar";
                    btn_Habilitado(btnAceptar);
                    ID = oCliente.ID;
                    break;
            }
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
            if (tipoAccion == Utiles.AccionEnum.TipoAccion.Add || tipoAccion == Utiles.AccionEnum.TipoAccion.Modify)
            {
                if (ValidarTXT(listTextbox))
                {
                    btn_Habilitado(btnAceptar);
                    lblError.Visible = false;
                }
                else
                    btn_Inhabilitado(btnAceptar);
            }
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
                    cli.TelefonoCelular = txtCelular.Text;
                    cli.TelefonoAlternativo = txtCelAlternativo.Text;
                    cli.Comentarios = txtComentarios.Text;
                    cli.FechaAlta = DateTime.Now.ToString();

                    if (tipoAccion == Utiles.AccionEnum.TipoAccion.Add)
                        cli.ID = CliLogic.GetLastID();

                    if (tipoAccion == Utiles.AccionEnum.TipoAccion.Modify)
                        cli.ID = ID;

                    cliLogic.Save(cli, tipoAccion);
                }
            }

            catch (Exception ex)
            {
                throw ex;
            }

            finally
            {
                CloseForm(this);
                CargarListaTXT();
            }
        }

        private void EnableTextBox(bool oBand)
        {
            txtNombre.Enabled = oBand;
            txtApellido.Enabled = oBand;
            txtFijo.Enabled = oBand;
            txtCelular.Enabled = oBand;
            txtCelAlternativo.Enabled = oBand;
            txtDireccion.Enabled = oBand;
            txtComentarios.Enabled = oBand;
        }
    }
}
