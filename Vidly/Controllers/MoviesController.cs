﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        //
        // GET: /Movies/Random
        public ActionResult Random()
        {
            var viewModel = FillModel();

            return View(viewModel);
        }

        private static RandomMovieViewModel FillModel()
        {
            var movie = new Movie()
            {
                Name = "shrek!"
            };

            var customers = new List<Customer>
            {
                new Customer { Name = "Customer 1"},
                new Customer { Name = "Customer 2"}
            };

            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };
            return viewModel;
        }

        public ActionResult Index()
        {
            var movies = GetMovies();

            return View(movies);
        }

        [Route("movies/released/{year}/{month:range(1,12):regex(\\d{2})}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);
        }

        private IEnumerable<Movie> GetMovies()
        {
            return new List<Movie>
            {
                new Movie { Id = 1, Name = "Shrek"},
                new Movie { Id = 2, Name = "The lord of the rings"}
            };
        }

	}
}