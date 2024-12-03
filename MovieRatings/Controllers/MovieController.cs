using Microsoft.AspNetCore.Mvc;
using MovieRatings.Models;
using MovieRatings.Models.DTO;

namespace MovieRatings.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : Controller
    {
        private readonly AppDbContext _context;
        public MovieController(AppDbContext context)
        {
            _context = context;
        }


        [HttpPost(nameof(AddMovies))]
        public async Task<IActionResult> AddMovies(AddMoviesDTO request)
        {
            _context.Movies.Add(new Movies
            {
                Title = request.Title,
                Genre = request.Genre,
                Year = request.Year,
                Director = request.Director,
                Actors = request.Actors,
                Plot = request.Plot,
                Poster = request.Poster
            });
            var count = _context.SaveChanges();

            if (count > 0)
            {
                return Ok("Movie added successfully");
            }
            else
            {
                return BadRequest("Failed to add movie");
            }
        }
    }
}
