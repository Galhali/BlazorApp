using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorApp1.Data
{
    [Table("Studenci")]
    public class Student
    {
        public int Id { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public string? Email { get; set; }
        public int Semestr {  get; set; }
        public string? Avatar { get; set; }
        public int? Wiek {  get; set; }
    }
}
