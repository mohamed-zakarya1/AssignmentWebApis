using System.ComponentModel.DataAnnotations.Schema;

namespace SaifMalbinandHoda.Models
{
    public class Directos
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public IList<Movies>? Movies { get; set; }
        [ForeignKey("NationalityId")]
        public Nationalities? Nationalities { get; set; }
        public int? NationalityId { get; set; }
    }
}