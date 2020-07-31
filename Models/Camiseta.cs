namespace VintageStuff.Models
{
    public class Camiseta
    {
        public Camiseta()
        {
        }
        public Camiseta(string marca, string modelo)
        {
            Marca = marca;
            Modelo = modelo;
        }
        public RopaFoto  Foto { get; set; }
        

        [System.ComponentModel.DataAnnotations.Display(Description = "Esta es la marca")]
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Id { get; set; }
    }
}