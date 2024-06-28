using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CapstoneTestPRS.Models;
using CapstoneTestPRS.Data;

namespace CapstoneTestPRS.Data
{
    public class PrsDbContext : DbContext
    {
        public PrsDbContext (DbContextOptions<PrsDbContext> options)
            : base(options)
        {
        }

        public DbSet<CapstoneTestPRS.Models.User> Users { get; set; } = default!;
        public DbSet<CapstoneTestPRS.Models.Vendor> Vendors { get; set; } = default!;
        public DbSet<CapstoneTestPRS.Models.Product> Products { get; set; } = default!;
        public DbSet<CapstoneTestPRS.Models.Request> Requests { get; set; } = default!;
        public DbSet<CapstoneTestPRS.Data.RequestLine> RequestLines { get; set; } = default!;

      
    }
}
