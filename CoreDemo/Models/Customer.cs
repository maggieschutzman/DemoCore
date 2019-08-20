using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.Models {

    public class Customer {

        [Key]
        public int CustomerID { get; set; }

        [MaxLength(30)] [Required]
        public string Firstname { get; set; }

        [MaxLength(50)] [Required]
        public string Lastname { get; set; }

        public DateTime Added { get; set; }

        public decimal CreditLimit { get; set; }


    }
}
