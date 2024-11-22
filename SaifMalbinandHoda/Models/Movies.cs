namespace SaifMalbinandHoda.Models
{
    public class Movies
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public DateTime Published_year { get; set; }
        public IList<Directos>? Directos { get; set; }
        public Categories? Categories { get; set; }
        public int? CategoryId { get; set; }
    }
}
