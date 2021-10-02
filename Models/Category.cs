using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVC.Models
{
    public class Category
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "The description field is mandatory.")]
        public string Description { get; set; }

        public List<Product> Products { get; set; }
    }
}
