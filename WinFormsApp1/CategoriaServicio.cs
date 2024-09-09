using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace GestionCatalogo
{
    public class CategoriaServicio
    {
        public void Agregar(categoria nuevaCategoria)
        {
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();

            try
            {
                conexion.ConnectionString = "server = .\\SQLEXPRESS; database = CATALOGO_P3_DB; integrated security = true; TrustServerCertificate=True;";
                comando.Connection = conexion;

                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "INSERT INTO CATEGORIAS (Nombre) VALUES (@Nombre)";
                comando.Parameters.AddWithValue("@Nombre", nuevaCategoria.Nombre);

                conexion.Open();
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conexion.Close();
            }
        }
    }
}
