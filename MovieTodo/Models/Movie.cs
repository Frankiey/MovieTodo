using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MovieTodo.Models
{
    public class Movie
    {
        /// The Id of the movie
        public int ID { get; set; }

        /// The title of the movie.
        [StringLength(60, MinimumLength = 3), Required]
        public string Title { get; set; }

        /// String yes or no if the movie has been watched.
        public string Watched { get; set; }
    }
}
