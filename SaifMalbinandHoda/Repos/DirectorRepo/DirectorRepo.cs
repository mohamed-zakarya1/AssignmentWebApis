using Microsoft.EntityFrameworkCore;
using SaifMalbinandHoda.Data;
using SaifMalbinandHoda.DTOs;
using SaifMalbinandHoda.Models;

namespace SaifMalbinandHoda.Repos.DirectorRepo
{
    public class DirectorRepo : IDirectorRepo
    {
        private readonly AppDbContext _context;
        public DirectorRepo(AppDbContext context)
        {
            _context = context;
        }

        public void Delete(int id)
        {
            var dircts = _context.Directos.Include(x => x.Nationalities).Include(x => x.Movies).ThenInclude(x => x.Categories).FirstOrDefault(x => x.Id == id);
            _context.Remove(dircts);
            _context.SaveChanges();
        }

        public void Update(int id, DirectorDto directorDto)
        {
            var dircts = _context.Directos.Include(x => x.Nationalities).Include(x => x.Movies).ThenInclude(x => x.Categories).FirstOrDefault(x => x.Id == id);
            dircts.Name = directorDto.Name;
            dircts.Email = directorDto.Email;
            dircts.Phone = directorDto.Phone;
            dircts.Nationalities = new Models.Nationalities
            {
                Name = directorDto.Nationalities.Name,
            };
            dircts.Movies = directorDto.Movies.Select(x => new Movies
            {
                Name = x.Name,
                Published_year = x.Published_year,
                Categories = new Categories
                {
                    Name = x.Categories.Name,
                }
            }).ToList();
            _context.Directos.Update(dircts);
            _context.SaveChanges();
        }
    }
}
