using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.Models {
    /// <summary>
    /// 
    /// </summary>
    public class Product {

        [Key]
        public int ProductID { get; set; }

        [MaxLength(80)] [Required]
        public string Name { get; set; }

        [Required]
        public decimal Price { get; set; }

        public int Qty { get; set; }

        [MaxLength(8)]
        public string Status { get; set; }

    }
}
