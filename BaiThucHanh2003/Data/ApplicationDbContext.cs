using Microsoft.EntityFrameworkCore;
using BaiThucHanh2003.Models;
namespace BaiThucHanh2003.Data;

public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Person> Person { get; set; } = default!;
        public DbSet<Employee> Employee { get; set; } = default!;
    }
