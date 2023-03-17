using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BaoCaoBaiTapLonNhom02.Models;

    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

       

        public DbSet<BaoCaoBaiTapLonNhom02.Models.Student> Student { get; set; } = default!;

        public DbSet<BaoCaoBaiTapLonNhom02.Models.Nhom> Nhom { get; set; } = default!;

        public DbSet<BaoCaoBaiTapLonNhom02.Models.Cathi> Cathi { get; set; } = default!;
    }
