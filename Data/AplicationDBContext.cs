using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MVCMovie.Models;
using MvcMovie.Models;

 namespace MVCMovie.Data
 {
    public class AplicationDBContext : DbContext
    {
        public AplicationDBContext (DbContextOptions<AplicationDBContext> options)
            : base(options)
        {
        }

        public DbSet<MVCMovie.Models.Person> Person { get; set; }

        public DbSet<MVCMovie.Models.Student> Student { get; set; }

        public DbSet<MVCMovie.Models.Employee> Employee { get; set; }

        public DbSet<MVCMovie.Models.Product> Product { get; set; }

        public DbSet<MVCMovie.Models.KhachHang> KhachHang { get; set; }

        public DbSet<MVCMovie.Models.Category> Category { get; set; }

        public DbSet<MVCMovie.Models.MatHang> MatHang { get; set; }

        public DbSet<MVCMovie.Models.Demo> Demo { get; set; }

        public DbSet<MvcMovie.Models.Movie> Movie { get; set; }
        
        
    }
 }

    
