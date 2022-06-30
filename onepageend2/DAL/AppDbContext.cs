using Microsoft.EntityFrameworkCore;
using onepageend2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace onepageend2.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext>options):base(options)
        {
             
        }
        public DbSet<Catagory> catagories { get; set; }
    }
}
