using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorPagesMovie.Models;

namespace RazorPagesMovie.Data
{
    public class RazorPagesMovieContext : DbContext
    {
        public RazorPagesMovieContext (DbContextOptions<RazorPagesMovieContext> options)
            : base(options)
        {
        }

        public DbSet<RazorPagesMovie.Models.Movie> Movie { get; set; }
        /* Представленный выше код создает свойство DbSet<Movie> для набора сущностей. 
         * В терминологии Entity Framework набор сущностей обычно соответствует таблице базы данных. 
         * Сущность соответствует строке в таблице.*/
    }
}
