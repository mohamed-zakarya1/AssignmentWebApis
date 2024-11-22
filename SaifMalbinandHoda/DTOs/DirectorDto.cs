using SaifMalbinandHoda.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace SaifMalbinandHoda.DTOs
{
    public class DirectorDto
    {
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public IList<MovieDtoUpdate>? Movies { get; set; }
        public NationalityDto? Nationalities { get; set; }
    }
}
