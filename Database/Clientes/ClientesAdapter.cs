using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bussines.Entities;
using System.Data.SqlClient;
using System.Data;

namespace Database.Clientes
{
    public class ClientesAdapter: Adapter
    {
        #region METODOS SAVE
        public void Add(ClientesEntity oCliente)
        {
            this.OpenConnection();
            
            var query = "INSERT INTO Cliente (Nombre, Apellido, TelefonoFijo, TelefonoCelular, TelefonoAlternativo, Direccion, Comentarios, FechaAlta) VALUES (@Nombre, @Apellido, @TelefonoFijo, @TelefonoCelular, @TelefonoAlternativo, @Direccion, @Comentarios, @FechaAlta) " + " SELECT @@IDENTITY";
            SqlCommand cmdClientes = new SqlCommand(query, SqlConn);
            
            cmdClientes.Parameters.Add("@Nombre", SqlDbType.VarChar, 20).Value = oCliente.Nombre;
            cmdClientes.Parameters.Add("@Apellido", SqlDbType.VarChar, 20).Value = oCliente.Apellido;
            cmdClientes.Parameters.Add("@TelefonoFijo", SqlDbType.VarChar, 10).Value = oCliente.TelefonoFijo;
            cmdClientes.Parameters.Add("@TelefonoCelular", SqlDbType.VarChar, 15).Value = oCliente.TelefonoCeluar;
            cmdClientes.Parameters.Add("@TelefonoAlternativo", SqlDbType.VarChar, 15).Value = oCliente.TelefonoAlternativo;
            cmdClientes.Parameters.Add("@Direccion", SqlDbType.VarChar, 20).Value = oCliente.Direccion;
            cmdClientes.Parameters.Add("@Comentarios", SqlDbType.VarChar, 150).Value = oCliente.Comentarios;
            cmdClientes.Parameters.Add("@FechaAlta", SqlDbType.DateTime).Value = oCliente.FechaAlta;

            oCliente.ID = Convert.ToInt32(cmdClientes.ExecuteScalar());

            this.CloseConnection();
        }

        public void Modify(ClientesEntity oCliente)
        {

        }

        public void Delete(int ID)
        {

        }
        #endregion
    }
}
