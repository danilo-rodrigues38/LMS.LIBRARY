﻿using LMS.LIBRARY.API.Models;
using Microsoft.EntityFrameworkCore;

namespace LMS.LIBRARY.API.Context
{
    public static class BookConfiguration
    {
        public static void Configure ( ModelBuilder modelBuilder )
        {
            foreach (var property in modelBuilder.Model.GetEntityTypes ( )
                .SelectMany ( t => t.GetProperties ( ) )
                .Where ( p => p.ClrType == typeof ( string ) ))
            {
                property.SetColumnType ( "varchar (100)" );
            }

            modelBuilder.Entity<Book> ( )
                .HasKey ( u => u.Id );

            modelBuilder.Entity<Book> ( )
                .Property ( u => u.Title )
                .HasColumnType ( "varchar(100)" )
                .IsRequired ( );

            modelBuilder.Entity<Book> ( )
                .Property ( u => u.Author )
                .HasColumnType ( "varchar(100)" )
                .IsRequired ( );

            modelBuilder.Entity<Book> ( )
                .Property ( u => u.Isbn )
                .HasColumnType ( "varchar(20)" )
                .IsRequired ( );
        }
    }
}
