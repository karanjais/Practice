using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

using System.Linq;
using System.Threading.Tasks;

namespace Practice.Models
{
    public class CommonContext : DbContext

    {

        public CommonContext(DbContextOptions<CommonContext> options) : base(options)
        {

        }
        public DbSet<Category> categories {get; set;}
        public DbSet<Product> products {get; set; }


    }
}
