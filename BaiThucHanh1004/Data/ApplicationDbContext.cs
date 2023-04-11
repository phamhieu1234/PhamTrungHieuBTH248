using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BaiThucHanh1004.Models;

    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<BaiThucHanh1004.Models.Student> Student { get; set; } = default!;

        public DbSet<BaiThucHanh1004.Models.Employee> Employee { get; set; } = default!;
    }
