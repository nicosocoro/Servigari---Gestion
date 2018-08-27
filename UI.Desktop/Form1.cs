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
using Bussiness.Logic.Clientes;
using UI.Desktop.Clientes;

namespace UI.Desktop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public IngresoLogic _IngLogic { get; set; }
        public IngresoLogic IngLogic
        {
            get
            {
                if(_IngLogic == null)
                {
                    _IngLogic = new IngresoLogic();
                }
                return _IngLogic;
            }
        }

        public ClienteLogic _CliLogic { get; set; }
        public ClienteLogic CliLogic {
            get
            {
                if (_CliLogic == null)
                    _CliLogic = new ClienteLogic();

                return _CliLogic;
            }
        }

        public void OpenForm(Form pForm)
        {
            pForm.ShowDialog();
        }
    }
}
