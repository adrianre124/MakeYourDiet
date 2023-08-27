using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MakeYourDiet.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Fats { get; set; }
        public int Carbons { get; set; }
        public int Proteins { get; set; }
        public int Weight { get; set; } = 100;
    }
}