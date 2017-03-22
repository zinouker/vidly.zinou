using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using System.Data.Entity;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        private readonly ApplicationDbContext _context;
        public MoviesController()
        {
            _context = new ApplicationDbContext();
        }
        // GET: Movies/Random
        public ActionResult Random()
        {
            var movies = GetMovies();
            return View(movies);

        }

        public ActionResult Details(int id)
        {
            var movie = GetMovies().SingleOrDefault(c => c.Id == id);
            return View(movie);
        }

        public IEnumerable<Movie> GetAllMovies()
        {
            // first method
            IList<Movie> movies = new List<Movie>
            {
                new Movie {Id = 1, Name = "The Wolverine" },
                new Movie {Id = 2, Name = "The Prestige" }
            };
            // first method

            // second method
            movies.Add(new Movie { Id = 3, Name = "La la land" });
            // second method

            //thid method
            var movie = new Movie();
            movie.Id = 4;
            movie.Name = "Harry Potter";
            movies.Add(movie);
            //thid method

            return movies;
        }

        public IEnumerable<Movie> GetMovies()
        {
            return _context.Movies.Include(c => c.Genre).ToList();
        }
    }
}