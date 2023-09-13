using IMDB_BackEndApi.Models;

namespace IMDB_BackEndApi.Repositories
{
    public interface IMovieRepository
    {
        public List<Movie> GetAll();
    }
}