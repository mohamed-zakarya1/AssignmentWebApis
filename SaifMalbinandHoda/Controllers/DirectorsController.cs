using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SaifMalbinandHoda.DTOs;
using SaifMalbinandHoda.Repos.DirectorRepo;
using SaifMalbinandHoda.Repos.MovieRepo;

namespace SaifMalbinandHoda.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DirectorsController : ControllerBase
    {
        private readonly IDirectorRepo _repo;
        public DirectorsController(IDirectorRepo repo)
        {
            _repo = repo;
        }
        [HttpPut]
        public IActionResult Update(int id, DirectorDto directorDto)
        {
            _repo.Update(id, directorDto);
            return Accepted();
        }
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            _repo.Delete(id);
            return Accepted();
        }
    }
}
