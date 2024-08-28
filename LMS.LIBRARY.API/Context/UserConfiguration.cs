using LMS.LIBRARY.API.Models;
using Microsoft.EntityFrameworkCore;

namespace LMS.LIBRARY.API.Context
{
    public static class UserConfiguration
    {
        public static void Configure ( ModelBuilder modelBuilder )
        {
            foreach (var property in modelBuilder.Model.GetEntityTypes ( )
                .SelectMany ( t => t.GetProperties ( ) )
                .Where ( p => p.ClrType == typeof ( string ) ))
            {
                property.SetColumnType ( "varchar (100)" );
            }

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