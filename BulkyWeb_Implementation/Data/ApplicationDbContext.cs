using BulkyWeb_Implementation.Models;
using Microsoft.EntityFrameworkCore;

namespace BulkyWeb_Implementation.Data
{
    public class ApplicationDbContext :DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {
            
        }

        public DbSet<Category> Categories { get; set; }
    }
}
