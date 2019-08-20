using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.Models {

    public class MyDatabase : DbContext {

        public DbSet<Product> Products { get; set; }

        public DbSet<Customer> Customers { get; set; }

        // constructor to allow .NET Core to do dependency injection
        public MyDatabase(DbContextOptions options) : base(options) {


        }
    }
}

