using SaifMalbinandHoda.DTOs;

namespace SaifMalbinandHoda.Repos.MovieRepo
{
    public interface IMovieRepo
    {
        void AddMovie(MovieDto movieDto);
        IList<MovieDto> GetAll();
        MovieDto GetById(int id);
    }
}