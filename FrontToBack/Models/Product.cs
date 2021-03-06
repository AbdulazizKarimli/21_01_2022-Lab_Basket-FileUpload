using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FrontToBack.Models
{
    public class Product : BaseEntity
    {
        public string Name { get; set; }

        public double Price { get; set; }

        public string Image { get; set; }

        public int CategoryId { get; set; }

        public Category Category { get; set; }

        [NotMapped]
        public IFormFile Photo { get; set; }
    }
}
