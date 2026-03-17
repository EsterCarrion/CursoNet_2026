using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaModelos
{
    public class Pais
    {
        [Key] public int Id { get; set; }
        public string Nombre_Pais { get; set; }

        //Lista de autores que pertenecen a este país
        List<Autor>? Autores { get; set; } = new List<Autor>(); 
    }
}
