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
using Utiles;

namespace UI.Desktop
{
    public partial class AgregarTipo : Form1
    {
        public AgregarTipo()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string error = Validaciones.ValidarTipo(this.txtDescripcion.Text);
                   error += IngLogic.ExisteTipo(txtDescripcion.Text);
            
            if(error == "")
            {
                string desc = Utiles.FirstToUpper.ToUpper(txtDescripcion.Text);
                IngLogic.NuevoTipo(desc);
                this.txtDescripcion.Clear();

                this.Close();
            }

            else
            {
                MessageBox.Show(error, "Error al ingresar nuevo tipo", MessageBoxButtons.OK);
            }

            
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
