using SaifMalbinandHoda.Models;
using System.ComponentModel.DataAnnotations;

namespace SaifMalbinandHoda.DTOs
{
    public class MovieDto
    {
        public string? Name { get; set; }
        public DateTime Published_year { get; set; }
        public IList<DirectorDtoMovie>? Directos { get; set; }
        public CategoryDto? Categories { get; set; }
    }
}
