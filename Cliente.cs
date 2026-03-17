using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaModelos
{
    public class Cliente
    {
        [Key] public int Id { get; set; }
        public string Nombre_Cliente { get; set; }
        public string Apellido_Cliente { get; set; }
        public string Correo_Cliente { get; set; }
        public string Nombre_Usuario { get; set; }
        public string Contrasenia_Cliente { get; set; }

        List<Prestamo>? Prestamos { get; set; } = new List<Prestamo>();
    }
}
