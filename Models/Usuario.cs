using VintageStuff.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VintageStuff.Web.Models
{
    public class Usuario
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Ingrese su nombre")]
        [Display(Name = "Nombre")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "Ingrese su apellido")]
        [Display(Name = "Apellido")]
        public string Apellido { get; set; }
        [Display(Name = "NombreCompleto")]
        public string NombreCompleto { get; set; }
        [Display(Name = "Telefono")]
        public int Telefono { get; set; }
        [Display(Name = "Correo")]
        public string Correo { get; set; }
        [Display(Name = "ImagenPerfil")]
        public string ImagenPerfil { get; set; }

        public Usuario()
        {
            NombreCompleto = Nombre + " " + Apellido;
        }
    }
}