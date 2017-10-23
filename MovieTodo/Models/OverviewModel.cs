using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MovieTodo.Models
{
    public class OverviewModel
    {
        /// The list of all movies.
        public List<Movie> movies;

        /// The title of the movie.
        [StringLength(60, MinimumLength = 3), Required]
        public string Title { get; set; }
        
        /// String yes or no if the movie has been watched.
        public string Watched { get; set; }
    }
}
