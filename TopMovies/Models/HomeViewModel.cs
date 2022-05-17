using System.Collections.Generic;

namespace TopMovies.Models
{
    public class HomeViewModel
    {
        public List<Movie> Movies { get; set; }
        public List<GenreVithMovieCountViewModel> Genres { get; set; }
        public int? GenreId { get; set; }



    }
}
