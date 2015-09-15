using CatalogoW10.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogoW10.Services
{
    public class CategoriesService : ICategoriesService
    {
        private List<Category> _categories;

        public CategoriesService()
        {
            _categories = new List<Category>
            {
                new Category("Gama blanca", new List<Category>()),
                new Category("Gama marrón", new List<Category>()),
                new Category("Gama gris", new List<Category>()),
                new Category("Gama PAE", new List<Category>())
            };
        }

        public IEnumerable<Category> GetCategories()
        {
            return _categories;
        }

        public Category GetCategory(Guid id)
        {
            return _categories.FirstOrDefault(c => c.Id == id);
        }
    }
}
