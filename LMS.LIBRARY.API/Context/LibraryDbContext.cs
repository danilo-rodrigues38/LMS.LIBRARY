using LMS.LIBRARY.API.Models;
using Microsoft.EntityFrameworkCore;

namespace LMS.LIBRARY.API.Context
{
    public class LibraryDbContext : DbContext
    {
        public LibraryDbContext ( DbContextOptions<LibraryDbContext> options ) : base ( options )
        {
        }

        public DbSet<Book> Books { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating ( ModelBuilder modelBuilder )
        {
            UserConfiguration.Configure ( modelBuilder );
            BookConfiguration.Configure ( modelBuilder );

            base.OnModelCreating ( modelBuilder );
        }
    }
}
