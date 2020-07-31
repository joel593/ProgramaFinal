using VintageStuff.Data;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace VintageStuff.Web.ViewModels
{
    public class UsuarioViewModel
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
        [Required(ErrorMessage = "Escoge una imagen")]
        [Display(Name = "ImagenPerfil")]
        public IFormFile ImagenPerfil { get; set; }
    }
}