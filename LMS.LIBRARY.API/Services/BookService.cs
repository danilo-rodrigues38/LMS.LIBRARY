using LMS.LIBRARY.API.Context;
using LMS.LIBRARY.API.Models;

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
            var books = _context.Books.ToList();

            return books;
        }

        public List<Book> GetForAuthor ( string author )
        {
            throw new NotImplementedException ( );
        }

        public List<Book> GetForTitle ( )
        {
            throw new NotImplementedException ( );
        }
    }
}
