using LMS.LIBRARY.API.Models;
using LMS.LIBRARY.API.Services;
using Microsoft.AspNetCore.Mvc;

namespace LMS.LIBRARY.API.Controllers
{
    [Route ( "api/books" )]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly IBookService _bookService;

        public BooksController ( IBookService bookService )
        {
            _bookService = bookService;
        }

        [HttpGet]
        public IActionResult GetAllBook ( )
        {
            var books = _bookService.GetAllBooks();

            return Ok ( books );
        }

        [HttpGet("author/{nameAuthor}")]
        public IActionResult GetByAuthor ( string nameAuthor )
        {
            var author = _bookService.GetByAuthor(nameAuthor);

            return Ok ( author );
        }

        [HttpGet("title/{titleBook}")]
        public IActionResult GetByTitle ( string titleBook )
        {
            var title = _bookService.GetByTitle(titleBook);

            return Ok ( title );
        }

        [HttpGet ( "{id}", Name = nameof(GetById) )]
        public IActionResult GetById ( int id )
        {
            var book = _bookService.GetById(id).FirstOrDefault();

            if (book == null)
            {
                return NotFound ( );
            }

            return Ok ( book );
        }

        [HttpPost]
        public async Task<ActionResult<Book>> Create ( Book book )
        {
            var createdBook = await _bookService.Create(book);

            //return Ok ( createdBook );
            return CreatedAtRoute ( nameof ( GetById ), new { id = createdBook.Id }, createdBook );
        }
    }
}
