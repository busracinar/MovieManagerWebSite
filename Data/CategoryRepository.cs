using MovieApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace MovieApp.Data
{
    public static class CategoryRepository
    {
        private static List<Category> _categories = null;
        public static List<Category> Categories { get { return _categories; } }
        static CategoryRepository()
        {
            _categories = new List<Category>()
            {
                new Category{ Id=1, Name="Macera" },
                new Category{ Id=2, Name="Korku"},
                new Category{ Id=3, Name="Komedi"}
            };
        }
        public static Category GetCategoryById(int Id)
        {
            return _categories.FirstOrDefault(x => x.Id == Id);
        }
    }
}
