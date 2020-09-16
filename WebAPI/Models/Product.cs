using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    [Table("Products")]
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(80)]
        public string Name { get; set; }
        [Required]
        [MaxLength(300)]
        public string Description { get; set; }
        [Required]
        public decimal Price { get; set; }
        [Required]
        [MaxLength(300)]
        public string ImageUrl { get; set; }
        public float Amount { get; set; }
        public DateTime Created { get; set; }

        public Category Category { get; set; }

        public int CategoryId { get; set; }

    }
}
