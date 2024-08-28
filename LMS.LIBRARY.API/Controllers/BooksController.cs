using LMS.LIBRARY.API.Context;
using LMS.LIBRARY.API.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LMS.LIBRARY.API.Controllers
{
    [Route ( "api/books" )]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly IBookService _bookService;

        public BooksController(IBookService bookService)
        {
            _bookService = bookService;
        }

        [HttpGet]
        public IActionResult GetBook ( )
        {
            return (IActionResult) _bookService.GetAllBooks ( );
        }
    }
}
