using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreApplication.Models
{
    public class Movie
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string LongDescription { get; set; }

        public string ImageUrl { get; set; }

        public int CategoryID { get; set; }
    }
}
