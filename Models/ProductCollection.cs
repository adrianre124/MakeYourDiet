using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MakeYourDiet.Models
{
    public class ProductCollection
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int UserId { get; set; }
        public User User { get; set; } = null;
        public ICollection<Product> Products { get; } = new List<Product>();
    }
}