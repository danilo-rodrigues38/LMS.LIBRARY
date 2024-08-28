﻿namespace LMS.LIBRARY.API.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Isbn { get; set; }
        public DateTime PublicationDate { get; set; }
        public bool Active { get; set; }
    }
}
