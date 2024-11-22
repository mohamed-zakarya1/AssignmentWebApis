using SaifMalbinandHoda.Models;

namespace SaifMalbinandHoda.DTOs
{
    public class DirectorDtoMovie
    {
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public NationalityDto? Nationalities { get; set; }
    }
}