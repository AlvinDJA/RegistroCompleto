using System.ComponentModel.DataAnnotations;
using System;

namespace RegistroCompleto.Entidades
{
    public class Personas
    {
        [Key]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public string Cedula { get; set; }
        public string Direccion { get; set; }
        public DateTime Fecha { get; set; }
    }
}
