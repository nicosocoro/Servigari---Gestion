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

        public Iniciador _Iniciador { get; set; }
        public Iniciador Iniciador
        {
            get
            {
                if(_Iniciador == null)
                {
                    _Iniciador = new Iniciador();
                }

                return _Iniciador;
            }
        }
    }
}
