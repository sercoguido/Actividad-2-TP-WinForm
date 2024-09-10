using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace dominio
{
    public class articulo
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        [DisplayName("Código")]//Para que en GridView se pueda visualizar con acento
        public string Codigo { get; set; }
        [DisplayName("Descripción")]//Para que en GridView se pueda visualizar con acento
        public string Descripcion { get; set; }
        public Marca Marca { get; set; }
        public Categoria Categoria { get; set; }
        public string Imagen { get; set; }
        //public List<imagen> Imagenes { get; set; }
        public decimal Precio { get; set; }

        //public articulo()
        //{
        //   Imagenes = new List<imagen>();
        //}

    }
}
