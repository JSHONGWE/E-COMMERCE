using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreModel
{
   public class Product
    {

        public int ID { get; set; }
        [Required]
        [MinLength(2, ErrorMessage = "The product name field must be at least 2 characters long")]
        public String Name { get; set; }
        [Required]
        [MinLength(6, ErrorMessage = "The Description field must be at least 6 characters long")]
        public String Description { get; set; }


        
        public String Image { get; set; }

        [Required]
        [DisplayName("Price")]
        [Column(TypeName = "decimal(8, 3)")]
        public decimal UnitPrice { get; set; }
      

#nullable enable
        public String? Brand { get; set; }
#nullable disable
        public int ProductTypeID { get; set; }
        public virtual ProductType ProductType { get; set; }

        public Stock ProductStock { get; set; }
    }
}
