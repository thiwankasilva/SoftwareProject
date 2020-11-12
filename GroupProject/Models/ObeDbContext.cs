using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GroupProject.Models
{

        public class ObeDbContext : DbContext
        {
            public ObeDbContext(DbContextOptions<ObeDbContext> options)
           : base(options)
            //calling super constructor
            {
            }
        public DbSet<Result> Results { get; set; }
       public DbSet<Student> Students { get; set; }
       public DbSet<Module> Modules { get; set; }
        public DbSet<Lecturer> Lecturers { get; set; }
        public DbSet<FacultyAdministrator> Admins { get; set; }
    }
    
}
