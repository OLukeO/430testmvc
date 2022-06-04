using _430testmvc.Models;
using Microsoft.EntityFrameworkCore;

namespace _430testmvc.Data;

    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Book> Books { get; set; }
    }

