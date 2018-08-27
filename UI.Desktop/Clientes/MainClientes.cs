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
        public MainClientes()
        {
            InitializeComponent();
        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            DatosCliente datosCliente = new DatosCliente();
            OpenForm(datosCliente);
        }
    }
}
