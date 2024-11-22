namespace SaifMalbinandHoda.DTOs
{
    public class MovieDtoUpdate
    {
        public string? Name { get; set; }
        public DateTime Published_year { get; set; }
        public CategoryDto? Categories { get; set; }
    }
}
