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
    public partial class BorrarTipo : Form1
    {
        public BorrarTipo()
        {
            InitializeComponent();

            this.ddlTipos.DataSource = IngLogic.GetTipos(false);
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            string desc = ddlTipos.SelectedItem.ToString();
            IngLogic.BorrarTipo(desc);

            this.Close();
        }
    }
}
