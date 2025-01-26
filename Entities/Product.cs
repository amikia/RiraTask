using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Categories Category { get; set; }
        public int Price { get; set; }

    }

    public enum Categories
    {
        Category1,
        Category2,
        Category3
    }
}
