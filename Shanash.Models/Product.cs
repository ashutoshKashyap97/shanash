using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shanash.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Code { get; set; }
        [Required]
        public string Brand { get; set; }
        [Required]
        [Range(1,1000000)]
        public double Price { get; set; }
        [Required]
        [Range(1, 1000000)]
        public double ListPrice { get; set; }
        [Required]
        [Display(Name = "Price for 5")]
        [Range(1, 1000000)]
        public double ListPrice5 { get; set; }
        
        [Required]
        [Display(Name = "Price for 10")]
        [Range(1, 1000000)] 
        public double ListPrice10 { get; set; }
        [ValidateNever]

        public string ImageUrl { get; set; }

        [Required]
        [Display(Name = "Category")]
        public int CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        [ValidateNever]
        public Category Category { get; set; }
        
        [Required]
        [Display(Name = "Cover Type")]
        public int CoverTypeId { get; set; }
        [ForeignKey("CoverTypeId")]
        [ValidateNever]
        
        public CoverType CoverType { get; set; }
    }
}
