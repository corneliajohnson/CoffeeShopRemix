using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CoffeeShopRemix.Models
{
    public class BeanVariety
    {
            public int Id { get; set; }

            [Required]
            [StringLength(50, MinimumLength = 3)]
            public string Name { get; set; }

            [Required]
            [StringLength(255, MinimumLength = 3)]
            public string Region { get; set; }

            public string Notes { get; set; }
    }
}
