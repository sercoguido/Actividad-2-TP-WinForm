﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using dominio;


namespace servicio
{
    public class MarcaServicio
    {
        public List<Marca> listar()
        {
            List<Marca> lista = new List<Marca>();  
            AccesoDatos datos = new AccesoDatos();
            
            try
            {
                datos.SetearConsulta("SELECT Id,Descripcion FROM MARCAS");
                datos.EjecutarLectura();

                while (datos.Lector.Read())
                {
                    Marca aux = new Marca();

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

    }
}