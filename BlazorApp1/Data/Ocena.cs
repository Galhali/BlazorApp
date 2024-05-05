using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorApp1.Data
{
    [Table("Oceny")]
    public class Ocena
    {
        public int Id { get; set; }
        public Zapisanie Zapisanie { get; set; }
        public decimal OcenaCwiczenia { get; set; }
        public decimal OcenaWyklady {  get; set; }
        public decimal OcenaKoncowa {  get; set; }
    }
}
