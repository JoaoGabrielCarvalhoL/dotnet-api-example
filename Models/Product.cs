using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVC.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Display(Name = "Description")]
        [Required(ErrorMessage = "The description field is mandatory.")]
        public string DescriptionProduct { get; set; }

        [Display(Name = "Amount")]
        public int AmountProduct { get; set; }

        public int CategoryId { get; set; }

        public Category Category { get; set; }
    }
}
