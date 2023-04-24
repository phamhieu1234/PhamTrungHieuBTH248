using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BaiThucHanh1704.Models;

    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<BaiThucHanh1704.Models.Student> Student { get; set; } = default!;

        public DbSet<BaiThucHanh1704.Models.Faculty> Faculty { get; set; } = default!;

        public DbSet<BaiThucHanh1704.Models.Person> Person { get; set; } = default!;

        public DbSet<BaiThucHanh1704.Models.Employee> Employee { get; set; } = default!;
    }
