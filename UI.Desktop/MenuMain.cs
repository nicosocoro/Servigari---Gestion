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

namespace UI.Desktop
{
    public partial class MenuMain: Form1
    {
        public MenuMain()
        {
            InitializeComponent();
        }

        


        //---------FORM INGRESOS---------
        private void btnIngresos_Click(object sender, EventArgs e)
        {
            OpenIngresosForm();
        }

        //private void ingresosToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    OpenIngresosForm();
        //}

        private void OpenIngresosForm()
        {
            Ingresos ingresos = new Ingresos();
            OpenForm(ingresos);
        }


        #region Form Gastos
        private void btnGastos_Click(object sender, EventArgs e)
        {
            OpenGastosForm();
        }

        //private void gastosToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    OpenGastosForm();
        //}

        private void OpenGastosForm()
        {
            Gastos gastos = new Gastos();
            OpenForm(gastos);
        }
        #endregion

        private void OpenClientesForm()
        {
            MainClientes mainClientes = new MainClientes();
            OpenForm(mainClientes);
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            OpenClientesForm();
        }
    }
}
