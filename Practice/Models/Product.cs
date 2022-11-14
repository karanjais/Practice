using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Practice.Models
{
    public class Product
    {
        [Key]
        public int ProductID { get; set; }

        [ForeignKey("category")]
        public int CategoryID { get; set; }
        public Category category{ get; set; }
        public string ProductName { get; set; }
    }
}
