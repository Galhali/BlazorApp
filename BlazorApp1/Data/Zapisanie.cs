using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorApp1.Data
{
    [Table("Zapisania")]
    public class Zapisanie
    {
        public int Id { get; set; }
        public Student Student { get; set; }
        public Przedmiot Przedmiot { get; set; }
        public DateTime DataZapisania { get; set; }
    }
}
