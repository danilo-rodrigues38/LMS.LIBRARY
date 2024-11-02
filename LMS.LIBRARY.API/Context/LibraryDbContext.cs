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
            foreach (var property in modelBuilder.Model.GetEntityTypes ( )
                .SelectMany ( t => t.GetProperties ( ) )
                .Where ( p => p.ClrType == typeof ( string ) ))
            {
                property.SetColumnType ( "varchar (100)" );
            }

            UserConfiguration.Configure ( modelBuilder );
            BookConfiguration.Configure ( modelBuilder );

            base.OnModelCreating ( modelBuilder );
        }
    }
}
