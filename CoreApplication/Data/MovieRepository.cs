using CoreApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;



namespace CoreApplication.Data
{
    public class MovieRepository
    {
        private static List<Movie> _movies = null;

        static MovieRepository()
        {
            _movies = new List<Movie>()
            {
                new Movie() {Id=1, Name ="Shawshank Redemption" , Description="Shawshank Redemption", LongDescription="<p> Two imprisoned men bond over a number of years, finding solace and eventual redemption through acts of common decency. </p>", ImageUrl="1.jpg", CategoryID=1},
                new Movie() {Id=2, Name ="Léon: The Professional" , Description="Léon: The Professional", LongDescription="<p> Mathilda, a 12-year-old girl, is reluctantly taken in by Léon, a professional assassin, after her family is murdered. Léon and Mathilda form an unusual relationship, as she becomes his protégée and learns the assassin's trade. </p>", ImageUrl="2.jpg" , CategoryID=1},
                new Movie() {Id=3, Name ="Batman: The Dark Knight" , Description="Batman:The Dark Knight", LongDescription="<p> When the menace known as The Joker emerges from his mysterious past, he wreaks havoc and chaos on the people of Gotham. The Dark Knight must accept one of the greatest psychological and physical tests of his ability to fight injustice. </p>", ImageUrl="3.jpg", CategoryID=2 } 
                
            };
        }

        public static List<Movie> Movies
        {
            get
            {
                return _movies;
            }
        }

        public static void AddMovie(Movie entity)
        {
            _movies.Add(entity);
        }

        public static Movie GetById(int id)
        {
           return _movies.FirstOrDefault(i => i.Id == id);

        }
    }
}
