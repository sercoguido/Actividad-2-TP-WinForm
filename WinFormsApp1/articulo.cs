﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace GestionCatalogo
{
    internal class articulo
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string Marca { get; set; }
        public string Categoria { get; set; }
        public string Imagen { get; set; }
        //public List<imagen> Imagenes { get; set; }
        public decimal Precio { get; set; }

        //public articulo()
        //{
        //   Imagenes = new List<imagen>();
        //}

    }
}
