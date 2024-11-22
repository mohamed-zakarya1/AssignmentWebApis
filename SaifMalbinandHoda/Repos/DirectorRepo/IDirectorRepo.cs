using SaifMalbinandHoda.DTOs;

namespace SaifMalbinandHoda.Repos.DirectorRepo
{
    public interface IDirectorRepo
    {
        void Update(int id, DirectorDto directorDto);
        void Delete(int id);
    }
}
