using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Database;
using Bussines.Entities;
using System.Data;

namespace Bussiness.Logic
{
    public class IngresoLogic : LogicBase
    {
        #region Registros
        public DataTable GetIngresos()
        {
            return RecordManejador.GetIngresos();
        }

        public DataTable GetIngresos(string oMes)
        {
            var dt = GetIngresos_Clientes();

            GetRegistro_Mes(dt, oMes);

            return dt;            
        }

        public DataTable GetIngresos_Clientes()
        {
            DataTable dtIngresos = GetIngresos();
            //DataTable dtClientes = GetClientes();

            Clientes.ClienteLogic cliLogic = new Clientes.ClienteLogic();

            dtIngresos.Columns.Add("Nombre_Apellido", typeof(string));

            int cliID = dtIngresos.Columns.IndexOf("ID_Cliente");
            int cli_Nombre = dtIngresos.Columns.IndexOf("Nombre_Apellido");

            foreach (DataRow dr in dtIngresos.Rows)
            {
                string ID_Cli = dr[cliID].ToString();
                ClientesEntity cli = cliLogic.GetCliente_ID(ID_Cli);

                dr[cli_Nombre] = cli.Apellido + ", " + cli.Nombre;
            }

            return dtIngresos;
        }

        public void GetRegistro_Mes(DataTable dt, string oMes)
        {
            if (oMes.Length == 1)
                oMes = "0" + oMes;

            for(var i = dt.Rows.Count - 1; i >= 0 ; i--)
            {
                DataRow row = dt.Rows[i];
                string dr_mes = row[3].ToString();
                string mes_dt = dr_mes.Substring(3, 2);

                if (mes_dt != oMes)
                {
                    dt.Rows[i].Delete();
                }
            }

            dt.AcceptChanges();
            //foreach(DataRow dr in dt.Rows)
            //{
            //    string dr_mes = dr[3].ToString();
            //    string mes_dt = dr_mes.Substring(3,2);

            //    if (mes_dt != oMes)
            //    {
            //        dt.Rows.Remove(dr);                    
            //    }
            //}
        }

        public DataTable GetGastos()
        {
            return RecordManejador.GetGastos();
        }

        public DataTable GetGastos(string oMes)
        {
            var dt = GetGastos_Clientes();

            GetRegistro_Mes(dt, oMes);

            return dt;
        }

        public DataTable GetGastos_Clientes()
        {
            DataTable dtGastos = GetGastos();
            //DataTable dtClientes = GetClientes();

            Clientes.ClienteLogic cliLogic = new Clientes.ClienteLogic();

            dtGastos.Columns.Add("Nombre_Apellido", typeof(string));

            int cliID = dtGastos.Columns.IndexOf("ID_Cliente");
            int cli_Nombre = dtGastos.Columns.IndexOf("Nombre_Apellido");

            foreach (DataRow dr in dtGastos.Rows)
            {
                string ID_Cli = dr[cliID].ToString();
                ClientesEntity cli = cliLogic.GetCliente_ID(ID_Cli);

                dr[cli_Nombre] = cli.Apellido + ", " + cli.Nombre;
            }

            return dtGastos;
        }
        
        public DataTable GetClientes()
        {
            Clientes.ClienteLogic cliLogic = new Clientes.ClienteLogic();
            DataTable dtClientes = cliLogic.GetClientes();

            DataTable dt = new DataTable();
            dt.Columns.Add("ID", typeof(string));
            dt.Columns.Add("Nombre_Apellido", typeof(string));

            dt.Rows.Add("0", "PROPIO");

            foreach (DataRow dr in dtClientes.Rows)
            {
                DataRow drNew = dt.NewRow();

                drNew[0] = dr[0];
                drNew[1] = dr[1] + " " + dr[2];

                dt.Rows.Add(drNew);
            }

            return dt;
        }

        public void AddRowIngresos(MontoEntities montoEntity, string filePath)
        {
            RecordManejador.AdNuedRowIngresos(montoEntity, filePath);
        }

        public void ModifyRow(MontoEntities montoEntity, string filePath, string subPath)
        {
            RecordManejador.ModifyRow(montoEntity, filePath, subPath);
        }

        public void DeleteRow(int pIDEntity, string filePath, string subPath)
        {
            RecordManejador.DeleteRow(pIDEntity, filePath, subPath);
        }
        #endregion

        #region Tipos
        public List<string> GetTipos(bool pFlag)
        {
            List<string> listTipos = TiposManejador.GetTipos();

            if (pFlag)
            {
                listTipos.Add("Agregar nuevo...");
                listTipos.Add("Borrar existente...");
            }

            return listTipos;
        }

        public string ExisteTipo(string pDescripcion)
        {
            List<string> listTipos = this.GetTipos(false);
            string error = "";

            foreach (string s in listTipos)
            {
                if (pDescripcion == s)
                {
                    error = "Ya existe ese Tipo, ingrese otro";
                    break;
                }
            }

            return error;
        }

        public void NuevoTipo(string pDescripcion)
        {
            TiposManejador.NuevoTipo(pDescripcion);
        }

        public void BorrarTipo(string pDescripcion)
        {
            TiposManejador.BorrarTipo(pDescripcion);
        }
        #endregion

        #region SAVE METHODS
        public void Save(MontoEntities montoEntity, Utiles.AccionEnum.TipoAccion tipoAccion)
        {
            string filePath = "";
            string subPath = "";

            switch (montoEntity.TipoMonto)
            {
                case TipoMonto.Ingreso:
                    filePath = "connectionIngresos";
                    subPath = "registros/ingreso";
                    break;

                case TipoMonto.Gasto:
                    filePath = "connectionGastos";
                    subPath = "registros/gasto";
                    break;
            }

            switch (tipoAccion)
            {
                case Utiles.AccionEnum.TipoAccion.Add:
                    this.AddRowIngresos(montoEntity, filePath);
                    break;

                case Utiles.AccionEnum.TipoAccion.Modify:
                    this.ModifyRow(montoEntity, filePath, subPath);
                    break;

                case Utiles.AccionEnum.TipoAccion.Delete:
                    this.DeleteRow(montoEntity.ID, filePath, subPath);
                    break;
            }
        }
        #endregion

        #region Utiles
        public int CalcularTotalMonto(int pMonth, string pYear, string pTipo, string pPath)
        {
            return RecordManejador.CalcularTotalMonto(pMonth, pYear, pTipo, pPath);
        }
        #endregion  
    }
}
