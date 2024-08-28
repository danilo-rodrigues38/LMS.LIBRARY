using LMS.LIBRARY.API.Context;
using LMS.LIBRARY.API.Models;
using Microsoft.AspNetCore.Http.HttpResults;

namespace LMS.LIBRARY.API.Services
{
    public class BookService : IBookService
    {
        private readonly LibraryDbContext _context;

        public BookService(LibraryDbContext context)
        {
            _context = context;
        }

        public List<Book> GetAllBooks ( )
        {
            return _context.Books.ToList();
        }

        public List<Book> GetByAuthor ( string author )
        {
            return _context.Books.Where(a => a.Author.Contains(author)).ToList();
        }

        public List<Book> GetById ( int id )
        {
            return _context.Books.Where(i => i.Id == id).ToList();
        }

        public List<Book> GetByTitle ( string title )
        {
            return _context.Books.Where(t => t.Title.Contains(title)).ToList();
        }

        public async Task<Book> Create ( Book book )
        {
            _context.Books.Add ( book );
            await _context.SaveChangesAsync ( );

            return book;
        }
    }
}
