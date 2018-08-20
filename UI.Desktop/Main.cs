using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Desktop
{
    public partial class Main : Form1
    {
        public Main()
        {            
            InitializeComponent();
            Iniciador.CheckNodeTipo();
        }

        private void OpenForm(Form pForm)
        {
            pForm.ShowDialog();
        }


        //---------FORM INGRESOS---------
        private void btnIngreso_Click(object sender, EventArgs e)
        {
            OpenIngresosForm();
        }

        private void ingresosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenIngresosForm();
        }

        private void OpenIngresosForm()
        {
            Ingresos ingresos = new Ingresos();
            OpenForm(ingresos);
        }


        //---------FORM GASTOS---------
        private void btnGastos_Click(object sender, EventArgs e)
        {
            OpenGastosForm();
        }

        private void gastosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenGastosForm();
        }

        private void OpenGastosForm()
        {
            Gastos gastos = new Gastos();
            OpenForm(gastos);
        }
    }
}
