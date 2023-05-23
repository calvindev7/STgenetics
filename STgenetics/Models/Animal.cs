using System.ComponentModel.DataAnnotations;

namespace STgenetics.Models
{
    public class Animal
    {
        [Key]
        public int AnimalId { get; set; }
        public string Nombre { get; set; }
        public string Raza { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Sexo { get; set; }
        public float Precio { get; set; }
        public string Estado { get; set; }
    }
}
