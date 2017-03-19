using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random
        public ActionResult Random()
        {
            var movies = GetAllMovies();
            return View(movies);

        }

        public ActionResult Details(int id)
        {
            var movie = GetAllMovies().SingleOrDefault(c => c.Id == id);
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
    }
}