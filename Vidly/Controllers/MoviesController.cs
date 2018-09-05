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
        // GET: Movie
        public ActionResult Random()
        {
            //var movie = new Movie { Name = "Shreck!" };
            //var customers = new List<Customer>
            //{
            //    new Customer{Name="Customer 1"},
            //    new Customer{Name="Customer 1"}
            //};

            //var viewModel = new RandomMovieViewModel
            //{
            //    Movie = movie,
            //    Customers = customers
            //};

            //return View(viewModel);

            var movies = GetMovies();

            return View(movies);
        }

        public ActionResult Edit(int id)
        {
            return Content("id = " + id);
        }

        [Route("movies/released/{year}/{month:regex(\\d{2}):range(1,12)}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);
        }

        public ActionResult Index()
        {
            var movies = GetMovies();

            return View(movies);
        }

        private IEnumerable<Movie> GetMovies()
        {
            return new List<Movie>
            {
                new Movie { Id = 1, Name = "Shrek" },
                new Movie { Id = 2, Name = "Wall-e" }
            };
        }
    }
}