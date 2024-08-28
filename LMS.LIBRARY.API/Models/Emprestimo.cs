namespace LMS.LIBRARY.API.Models
{
    public class Emprestimo
    {
        public int Id { get; set; }
        public User UserId { get; set; }
        public List<Book> BookList { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime FinishDate { get; set; }
    }
}
