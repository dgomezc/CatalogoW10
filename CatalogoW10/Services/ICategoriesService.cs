using CatalogoW10.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogoW10.Services
{
    public interface ICategoriesService
    {
        IEnumerable<Category> GetCategories();
        Category GetCategory(Guid id);
    }
}
