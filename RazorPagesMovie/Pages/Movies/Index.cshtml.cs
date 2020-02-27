using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RazorPagesMovie.Data;
using RazorPagesMovie.Models;

namespace RazorPagesMovie.Pages.Movies
{
    public class IndexModel : PageModel
    {
        //Используя внедрение зависимостей, конструктор добавляет на страницу RazorPagesMovieContext. 
        private readonly RazorPagesMovie.Data.RazorPagesMovieContext _context; 

        public IndexModel(RazorPagesMovie.Data.RazorPagesMovieContext context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; }

       
        [BindProperty(SupportsGet = true)]
        /*связывает значения из формы и строки запроса с тем же именем, что и у свойства. 
        * (SupportsGet = true) является обязательным для привязки в запросах GET.
        */
        public string SearchString { get; set; }
        // Requires using Microsoft.AspNetCore.Mvc.Rendering;
        public SelectList Genres { get; set; }
        [BindProperty(SupportsGet = true)]
        public string MovieGenre { get; set; }

        /*
        public async Task OnGetAsync()
        {
            Movie = await _context.Movie.ToListAsync();
        }
        /* Когда OnGet возвращает void или OnGetAsync возвращает Task, оператор return не используется. 
         * Если возвращаемый тип — IActionResult или Task<IActionResult>, необходимо предоставить оператор return. Например, метод OnPostAsync
         */

        public async Task OnGetAsync()
        {

            //конструирование составного запрос LINQ
            var movies = from m in _context.Movie
                         select m;
            if (!string.IsNullOrEmpty(SearchString))
            {
                movies = movies.Where(s => s.Title.Contains(SearchString));
            }
            //Movie = await movies.ToListAsync(); //запрос выполняется только здесь

            //добавляем поиск по жанру
            IQueryable<string> genreQuery = from m in _context.Movie
                                            orderby m.Genre
                                            select m.Genre;

            if (!string.IsNullOrEmpty(MovieGenre))
            {
                movies = movies.Where(x => x.Genre == MovieGenre);
            }
            Genres = new SelectList(await genreQuery.Distinct().ToListAsync());
            Movie = await movies.ToListAsync();
        }
    }
}
