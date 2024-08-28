using LMS.LIBRARY.API.Models;

namespace LMS.LIBRARY.API.Services
{
    public interface IBookService
    {
        List<Book> GetAllBooks();
        List<Book> GetByTitle ( string title );
        List<Book> GetByAuthor ( string author );
        List<Book> GetById ( int id );
        Task<Book> Create ( Book book );
    }
}
