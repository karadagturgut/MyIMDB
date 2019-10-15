using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreApplication.Models;

namespace CoreApplication.Data
{
    public class CategoryRepository
    {
        public static List<Category> _categories = null;
        static CategoryRepository()
        {
            _categories = new List<Category>()
            {
               new Category(){ID=1, Name="Dram"},
               new Category(){ID=2, Name="Aksiyon-Macera"}

            };
        }

        public static List<Category> Categories
        {

            get
            {
                return _categories;
            }
        }
        public static void AddCategory (Category category)
        {
            _categories.Add(category);
        }
        public static Category GetByID(int id)
        {
            return _categories.FirstOrDefault(i => i.ID == id);
        }
    }
}
