using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Library.API.Entities
{
    public class LibraryContext : DbContext
    {
        public LibraryContext(DbContextOptions<LibraryContext> options)
           : base(options)
        {
            Database.Migrate();
        }

        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }

    }

    // required when local database deleted
    public class ToDoContextFactory : IDesignTimeDbContextFactory<LibraryContext>
    {
        public LibraryContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<LibraryContext>();
            builder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=LibraryDB;Trusted_Connection=True;");
            return new LibraryContext(builder.Options);
        }
    }
}
