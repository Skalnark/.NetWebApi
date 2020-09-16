using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    [Table("Categories")]
    public class Category
    {
        public Category()
        {
            Products = new Collection<Product>();
        }

        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(80)]
        public string Name { get; set; }
        [Required]
        [MaxLength(300)]
        public string ImageUrl { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}
