using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using CoreApplication.Data;
using CoreApplication.Models;

namespace CoreApplication.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index(int?id)
        {
            var movies = MovieRepository.Movies;
            if (id != null) { movies = movies.Where(i => i.CategoryID == id).ToList();}

            return View(movies);
        }

        public IActionResult Details(int id)
        {
            //Movie_CategoryModel model = new Movie_CategoryModel();
            //model.Categories = CategoryRepository.Categories;
            //model.Movie = MovieRepository.GetById(id);

            return View(MovieRepository.GetById(id));
        }
        public IActionResult Contact()
        {
            return View();
        }

     
    }
}
