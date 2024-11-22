namespace SaifMalbinandHoda.Models
{
    public class Categories
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public IList<Movies>? Movies { get; set; }
    }
}
