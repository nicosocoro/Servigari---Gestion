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
        public DataTable GetIngresos()
        {
            return Manejador.GetIngresos();
        }

        public DataTable GetGastos()
        {
            return Manejador.GetGastos();
        }
    
        public List<string> GetTipos(bool pFlag)
        {
            List<string> listTipos = Manejador.GetTipos();

            if(pFlag)
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

            foreach(string s in listTipos)
            {
                if(pDescripcion == s)
                {
                    error = "Ya existe ese Tipo, ingrese otro";
                    break;
                }
            }

            return error;
        }

        public void NuevoTipo(string pDescripcion)
        {
            Manejador.NuevoTipo(pDescripcion);
        }

        public void BorrarTipo(string pDescripcion)
        {
            Manejador.BorrarTipo(pDescripcion);
        }

        public void AddRowIngresos(MontoEntities montoEntity, string filePath)
        {
            Manejador.AdNuedRowIngresos(montoEntity, filePath);
        }

        public void ModifyRow(MontoEntities montoEntity, string filePath, string subPath)
        {
            Manejador.ModifyRow(montoEntity, filePath, subPath);
        }

        public void DeleteRow(int pIDEntity, string filePath, string subPath)
        {
            Manejador.DeleteRow(pIDEntity, filePath, subPath);
        }
        
        //SAVE METHODS

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


        //CALCULAR MONTO TOTAL
        public int CalcularTotalMonto(int pMonth, string pYear, string pDescripcion, string pPath)
        {
            return Manejador.CalcularTotalMonto(pMonth, pYear, pDescripcion, pPath);
        }
    }
}
