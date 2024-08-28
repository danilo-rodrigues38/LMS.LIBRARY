using LMS.LIBRARY.API.Models;

namespace LMS.LIBRARY.API.Services
{
    public interface IBookService
    {
        List<Book> GetAllBooks();
        List<Book> GetForTitle ( );
        List<Book> GetForAuthor ( string author );
    }
}
