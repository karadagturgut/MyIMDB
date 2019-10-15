using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreApplication.Models
{
    public class Movie_CategoryModel
    {
        public Movie Movie { get; set; }
        public IEnumerable<Movie> Movies { get; set; }
        public IEnumerable<Category> Categories { get; set; }

   }
}
