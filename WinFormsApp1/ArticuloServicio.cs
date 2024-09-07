using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace GestionCatalogo
{
    class ArticuloServicio
    {
        public List<articulo> listar()
        {
            List<articulo> lista = new List<articulo>();

            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;

            try
            {
                conexion.ConnectionString = "server = .\\SQLEXPRESS; database = CATALOGO_P3_DB; integrated security = true; TrustServerCertificate=True;";

                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "SELECT Id,Nombre,Descripcion FROM ARTICULOS";
                comando.Connection = conexion;

                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    articulo aux = new articulo();
                    aux.Id = lector.GetInt32(0);
                    aux.Nombre = (string)lector["Nombre"];
                    aux.Descripcion = (string)lector["Descripcion"];

                    lista.Add(aux);
                }

                conexion.Close();
                return lista;
            }
            catch (Exception)
            {

                throw;
            }


        }

    }
}