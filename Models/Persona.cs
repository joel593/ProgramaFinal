using System.Collections.Generic;

namespace VintageStuff.Models
{
    public class Persona
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public List<Camiseta> Camisetas { get; set; } = new List<Camiseta>();
    }
}