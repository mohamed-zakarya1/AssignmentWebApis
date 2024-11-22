using Microsoft.EntityFrameworkCore;
using SaifMalbinandHoda.Data;
using SaifMalbinandHoda.DTOs;
using SaifMalbinandHoda.Models;

namespace SaifMalbinandHoda.Repos.MovieRepo
{
    public class MovieRepo : IMovieRepo
    {
        private readonly AppDbContext _context;
        public MovieRepo(AppDbContext context)
        {
            _context = context;
        }
        public void AddMovie(MovieDto movieDto)
        {
            var Movies = new Movies
            {
                Name = movieDto.Name,
                Published_year = movieDto.Published_year,
                Directos = movieDto.Directos.Select(x => new Directos
                {
                    Email = x.Email,
                    Name = x.Name,
                    Phone = x.Phone,
                    Nationalities = new Nationalities
                    {
                        Name = x.Nationalities.Name
                    },
                }).ToList(),
                Categories = new Categories
                {
                    Name = movieDto.Categories.Name
                },
            };
            _context.Movies.Add(Movies);
            _context.SaveChanges();
        }

        public IList<MovieDto> GetAll()
        {
            var movs = _context.Movies.Include(x => x.Directos).ThenInclude(x => x.Nationalities).Include(x => x.Categories).Select(x => new MovieDto
            {
                Name = x.Name,
                Published_year = x.Published_year,
                Directos = x.Directos.Select(x => new DirectorDtoMovie
                {
                    Name = x.Name,
                    Nationalities = new NationalityDto
                    {
                        Name = x.Nationalities.Name
                    }
                }).ToList(),
                Categories = new CategoryDto
                {
                    Name = x.Categories.Name
                }
            }).ToList();
            return movs;
        }

        public MovieDto GetById(int id)
        {
            var movs = _context.Movies.Include(x => x.Categories).Include(x => x.Directos).ThenInclude(x => x.Nationalities).FirstOrDefault(x => x.Id == id);
            if (movs == null)
            {
                return null;
            }
            return new MovieDto
            {
                Name = movs.Name,
                Published_year = movs.Published_year,
                Directos = movs.Directos.Select(x => new DirectorDtoMovie
                {
                    Name = x.Name,
                    Nationalities = new NationalityDto
                    {
                        Name = x.Nationalities.Name
                    },
                }).ToList(),
                Categories = new CategoryDto
                {
                    Name = movs.Categories.Name
                }
            };
        }
    }
}
