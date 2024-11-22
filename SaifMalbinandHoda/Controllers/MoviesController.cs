using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SaifMalbinandHoda.DTOs;
using SaifMalbinandHoda.Repos.MovieRepo;

namespace SaifMalbinandHoda.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private readonly IMovieRepo _repo;
        public MoviesController(IMovieRepo repo)
        {
            _repo = repo;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_repo.GetAll());
        }
        [HttpGet("GetById")]
        public IActionResult GetById(int id)
        {
            var x = _repo.GetById(id);
            if (x == null)
            {
                return NotFound();
            }
            return Ok(x);
        }
        [HttpPost]
        public IActionResult AddMovie(MovieDto movieDto)
        {
            _repo.AddMovie(movieDto);
            return Ok();
        }
    }
}
