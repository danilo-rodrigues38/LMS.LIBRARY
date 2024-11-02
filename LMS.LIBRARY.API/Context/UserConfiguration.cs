using LMS.LIBRARY.API.Models;
using Microsoft.EntityFrameworkCore;

namespace LMS.LIBRARY.API.Context
{
    public static class UserConfiguration
    {
        public static void Configure ( ModelBuilder modelBuilder )
        {
            modelBuilder.Entity<User>()
                .HasKey ( u => u.Id );

            modelBuilder.Entity<User> ( )
                .Property ( u => u.Name )
                .HasColumnType ( "varchar(100)" )
                .IsRequired ( );

            modelBuilder.Entity<User> ( )
                .Property ( u => u.Email )
                .HasColumnType ( "varchar(300)" )
                .IsRequired ( );
        }
    }
}