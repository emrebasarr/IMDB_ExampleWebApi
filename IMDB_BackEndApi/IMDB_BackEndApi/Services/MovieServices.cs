using IMDB_BackEndApi.Models;
using IMDB_BackEndApi.Repositories;

namespace IMDB_BackEndApi.Services
{
    public class MovieServices : IMovieRepository
    {
        private readonly ImdbDataContext imdbDataContext;

        public MovieServices(ImdbDataContext imdbDataContext) 
        {
            this.imdbDataContext = imdbDataContext;
        }

        public List<Movie> GetAll()
        {
            return imdbDataContext.Movies.ToList();
        }
    }
}