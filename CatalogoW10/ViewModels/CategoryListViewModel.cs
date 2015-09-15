using Caliburn.Micro;
using CatalogoW10.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogoW10.ViewModels
{
    public class CategoryListViewModel : Screen
    {
        public Guid Id { get; private set; }
        public string Name { get; private set; }

        public CategoryListViewModel(Category category)
        {
            Id = category.Id;
            Name = category.Name;
        }
    }
}
