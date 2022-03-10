using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreModel
{
   public  class ProductType
    {
        public int ID { get; set; }

        [Required]
        [MinLength(2, ErrorMessage = "The productType name field must be at least 2 characters long")]
        public String Name { get; set; }

        public ICollection<Product> Products { get; set; }

    }
}
