using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorApp1.Data
{
    [Table("Przedmioty")]
    public class Przedmiot
    {
        public int Id { get; set; }
        public string NazwaPrzedmiotu { get; set; }
        public string OpisPrzedmiotu { get; set; }
    }
}
