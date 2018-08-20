using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utiles;
using Bussiness.Logic;

namespace UI.Desktop
{
    public partial class CalcularTotal : Form1
    {
        public string Path { get; set; }

        public CalcularTotal()
        {
            InitializeComponent();

            List<string> listTipos = IngLogic.GetTipos(false);
            List<string> listMeses = Calendario.GetMeses();
            List<string> listAños = Calendario.GetAños();

            listTipos.Add("Todo");
            listMeses.Add("Todo");
            listAños.Add("Todo"); 

            this.ddlTipos.DataSource = listTipos;
            this.ddlAños.DataSource = listAños;
            this.ddlMeses.DataSource = listMeses;

            //pongo como seleccionado el mes actual
            int month = DateTime.Today.Month;
            ddlMeses.SelectedIndex = month - 1;
        }

        public CalcularTotal(string pPath)
            : this()
        {
            this.Path = pPath;

            switch (Path)
            {
                case "Ingresos.xml":
                    lblTittleCalculo.Text = "Cálculo Ingresos";
                    this.Text = "Cálculo total de Ingresos";
                    break;

                case "Gastos.xml":
                    lblTittleCalculo.Text = "Cálculo Gastos";
                    this.Text = "Cálculo total de Gastos";
                    break;
            }
        }

        private void ddlMeses_SelectedIndexChanged(object sender, EventArgs e)
        {
            //    int month = 0;
            //    string selectedValue = ddlMeses.Text;

            //    switch (selectedValue)
            //    {
            //        case "Todo":
            //            month = 0;
            //            break;

            //        case "Enero":
            //            month = 01;
            //            break;

            //        case "Febrero":
            //            month = 02;
            //            break;

            //        case "Marzo":
            //            month = 03;
            //            break;

            //        case "Abril":
            //            month = 04;
            //            break;

            //        case "Mayo":
            //            month = 05;
            //            break;

            //        case "Junio":
            //            month = 06;
            //            break;

            //        case "Julio":
            //            month = 07;
            //            break;

            //        case "Agosto":
            //            month = 08;
            //            break;

            //        case "Septiembre":
            //            month = 09;
            //            break;

            //        case "Octubre":
            //            month = 10;
            //            break;

            //        case "Noviembre":
            //            month = 11;
            //            break;

            //        case "Diciembre":
            //            month = 12;
            //            break;


            //    }

            //    int result = this.CalcularTotalMonto(month, Path);
            //    this.txtTotal.Text = "$" + result.ToString();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }        

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnTotal_Click(object sender, EventArgs e)
        {

            int month = 0;

            string selectedValueMeses = ddlMeses.SelectedItem.ToString();
            string selectedValueAños = ddlAños.SelectedValue.ToString();

            string tipo = ddlTipos.SelectedItem.ToString();

            switch (selectedValueMeses)
            {
                case "Todo":
                    month = 0;
                    break;

                case "Enero":
                    month = 01;
                    break;

                case "Febrero":
                    month = 02;
                    break;

                case "Marzo":
                    month = 03;
                    break;

                case "Abril":
                    month = 04;
                    break;

                case "Mayo":
                    month = 05;
                    break;

                case "Junio":
                    month = 06;
                    break;

                case "Julio":
                    month = 07;
                    break;

                case "Agosto":
                    month = 08;
                    break;

                case "Septiembre":
                    month = 09;
                    break;

                case "Octubre":
                    month = 10;
                    break;

                case "Noviembre":
                    month = 11;
                    break;

                case "Diciembre":
                    month = 12;
                    break;

                default:
                    month = 0;
                    break;
            }

            int result = IngLogic.CalcularTotalMonto(month, selectedValueAños, ddlTipos.SelectedItem.ToString(), Path);

            this.txtTotal.Text = "$" + result.ToString();
        }
    }
}
