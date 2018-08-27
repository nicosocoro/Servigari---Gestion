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
    public class IngresoLogic: LogicBase
    {
        #region Registros
        public DataTable GetIngresos()
        {
            return RecordManejador.GetIngresos();
        }

        public DataTable GetGastos()
        {
            return RecordManejador.GetGastos();
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
