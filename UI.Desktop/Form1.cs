﻿using System;
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
        #region Propiedades
        public bool btnHabilitado;

        public IngresoLogic _IngLogic { get; set; }
        public IngresoLogic IngLogic
        {
            get
            {
                if (_IngLogic == null)
                {
                    _IngLogic = new IngresoLogic();
                }
                return _IngLogic;
            }
        }

        public ClienteLogic _CliLogic { get; set; }
        public ClienteLogic CliLogic
        {
            get
            {
                if (_CliLogic == null)
                    _CliLogic = new ClienteLogic();

                return _CliLogic;
            }
        }


        public int Mes_Actual
        {
            get
            {
                return DateTime.Now.Month;
            }
        }
        #endregion

        #region Colores        
        public Color azul = Color.FromArgb(58, 58, 255);
        public Color blanco = Color.FromArgb(255, 255, 255);
        public Color negro = Color.FromArgb(0, 0, 0);
        public Color gris_deshabilitado = Color.FromArgb(130, 120, 135);
        public Color rojo_error = Color.FromArgb(255, 0, 0);
        public Color grisOscuro = Color.DarkGray;
        #endregion

        #region Funciones
        public Form1()
        {
            InitializeComponent();
        }

        public void OpenForm(Form pForm)
        {
            pForm.ShowDialog();
        }

        public void CloseForm(Form pForm)
        {
            pForm.Close();
        }

        /// <summary>
        /// Muestra un cartel para confirmar el cierre de un formulario. Recibe como parámetro el mensaje a mostrar.
        /// </summary>
        /// <param name="pMessage"></param>
        public void ConfirmCloseForm(string pMessage)
        {
            DialogResult dr = MessageBox.Show(pMessage, "¿Estás seguro?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            switch (dr)
            {
                case DialogResult.Yes:
                    this.Close();
                    break;

                case DialogResult.Cancel:
                    break;
            }
        }

        /// <summary>
        /// Aplica los estilos a botón en estado habilitado
        /// </summary>
        /// <param name="btn"></param>
        /// 
        public void btn_Habilitado(Button btn)
        {
            btnHabilitado = true;
            btn.Enabled = true;

            btn.BackColor = azul;
            btn.ForeColor = blanco;
        }

        public void btn_Habilitado(List<Button> oLista)
        {
            foreach (Button btn in oLista)
                btn_Habilitado(btn);
        }

        /// <summary>
        /// Aplica los estilos a botón en estado inhabilitado
        /// </summary>
        /// <param name="btn"></param>
        public void btn_Inhabilitado(Button btn)
        {
            btnHabilitado = false;
            btn.Enabled = false;

            btn.ForeColor = gris_deshabilitado;
            btn.BackColor = grisOscuro;
        }

        public void btn_Inhabilitado(List<Button> oLista)
        {
            foreach (Button btn in oLista)
                btn_Inhabilitado(btn);
        }


        /// <summary>
        /// Devuelve FALSE si alguno de los textbox de la lista está vacíos. Caso contrario, devuelve TRUE.
        /// </summary>
        public bool ValidarTXT(List<TextBox> pListaTextbox)
        {
            bool band = true;

            foreach (var item in pListaTextbox)
            {
                if (string.IsNullOrEmpty(item.Text))
                {
                    band = false;
                    break;
                }
            }

            return band;
        }

        #endregion  
    }
}