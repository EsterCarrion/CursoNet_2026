using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaModelos
{
    public class Biblioteca
    {
        //Llave primaria
        [Key] public int Id { get; set; }

        public string Nombre_Biblioteca { get; set; }
        public string Dirección { get; set; }

        List<Libro>? Libros { get; set; } = new List<Libro>();

    }
}
