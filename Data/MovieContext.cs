using Microsoft.EntityFrameworkCore;
using RazorPageMovie.Models;

namespace RazorPageMovie.Data
{
    public class MovieContext: DbContext
    {
        public MovieContext( DbContextOptions<MovieContext> options): base(options)
        {

        }

        public DbSet<Movie> Movies { get; set; }
    }
}