using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using vidly.Models;
using vidly.ViewModel;

namespace vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Monali!" };
            var customer = new List<Customer>
            {
                new Customer {Name="customer1"},
                new Customer {Name="customer1"}

            };

            var viewModel = new RendomMovieViewModel
            {
                Movie = movie,
                Customers = customer
            };

            //var viewmodel= Tuple.Create<Movie, List<Customer>>(movie,customer);
            return View(viewModel);

            //var viewResult = new ViewResult();
            //viewResult.ViewData.Model

            ///this the viwedata for the using viewdata
            // ViewData["Movie"] = movie;

            // this use of viewBag
            //ViewBag.Movie = movie;
            //ViewBag.RandMovie = movie;


            //return View(movie);
            //return Content("HEllo World!");
            //return HttpNotFound();
            //return new EmptyResult();
            //return RedirectToAction("Index","Home",new { page=1,sortBy="name"});
        }

        public ActionResult Edit(int id)
        {
            return Content("id=" + id);
        }

        // movies 
        public ActionResult Index(int? pageIndex, string sortBy)
        {
            if (pageIndex.HasValue)
                pageIndex = 1;
            if (string.IsNullOrEmpty(sortBy))
                sortBy = "Name";

            return Content(String.Format("pageIndex={0}&sortBy={1}", pageIndex, sortBy));
        }

        [Route("movies/released/{year}/{month:regex(\\d{4}):range(1,12)}")]
        public ActionResult byReleaseDate(int year, int month)
        {
            //return View();
            return Content(year + "/" + month);
        }


    }
}