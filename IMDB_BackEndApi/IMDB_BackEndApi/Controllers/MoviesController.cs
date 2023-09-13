using IMDB_BackEndApi.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
namespace IMDB_BackEndApi.Controllers
{
    public class MoviesController : ControllerBase
    {
        private readonly IMovieRepository movieRepository;

        public MoviesController(IMovieRepository movieRepository) 
        {
            this.movieRepository = movieRepository;
        }

        public IActionResult GetMovies()
        {
            var movies = movieRepository.GetAll();
            return Ok(movies);
        }
    }
}