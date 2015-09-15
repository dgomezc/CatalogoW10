using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogoW10.Models
{
    public class Category
    {
        public Guid Id { get; private set; }
        public string Name { get; internal set; }
        public IEnumerable<Category> ChildrenCategories { get; internal set; }
        
        public Category(string name, IEnumerable<Category> childrenCategories)
        {
            Id = Guid.NewGuid();
            Name = name;
            ChildrenCategories = childrenCategories;
        }
    }
}
