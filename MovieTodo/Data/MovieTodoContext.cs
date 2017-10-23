using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MovieTodo.Models
{
    public class MovieTodoContext : DbContext
    {
        public MovieTodoContext (DbContextOptions<MovieTodoContext> options)
            : base(options)
        {
        }

        public DbSet<MovieTodo.Models.Movie> Movie { get; set; }
    }
}
