using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreModel
{
  public  class Stock
    {
        public int ID { get; set; }
        [Required]
        //[DefaultValue(0)]
        public virtual int Quantity { get; set; }
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

        public virtual bool Availability { get; set; }
        public int ProductID { get; set; }
        public virtual Product Product { get; set; }
    }
}
