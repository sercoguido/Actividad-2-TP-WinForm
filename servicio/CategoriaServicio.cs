using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using dominio;
using servicio;


namespace servicio
{
    public class CategoriaServicio
    {
        public List<Categoria> listar()
        {
            List<Categoria> lista = new List<Categoria>();  
            AccesoDatos datos = new AccesoDatos();
            
            try
            {
                datos.SetearConsulta("SELECT Id,Descripcion FROM CATEGORIAS");
                datos.EjecutarLectura();

                while (datos.Lector.Read())
                {
                    Categoria aux = new Categoria();

                    aux.Id = (int)datos.Lector["Id"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];

                    lista.Add(aux);
                }
                   



                return lista;
            }
            catch (Exception ex)    
            {

                throw ex;
            }
            finally
            {
                datos.CerrarConexion();
            }


        }

        public void agregar(Categoria cat)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.SetearConsulta("INSERT into categorias (descripcion) values ('" + cat.Descripcion + "')");
                datos.EjecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.CerrarConexion();
            }

        }

    }


}