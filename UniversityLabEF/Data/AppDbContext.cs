using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace UniversityLabEF
{
    // The class that represents the database (Lab 09, Task 1).
    public class AppDbContext : DbContext
    {
        // Add one DbSet per table here.

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            // Read the connection string from user secrets and pass it to UseSqlServer.
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Set the default schema to Lab09.
        }
    }
}
