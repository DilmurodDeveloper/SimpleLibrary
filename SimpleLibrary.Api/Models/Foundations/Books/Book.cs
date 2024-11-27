//==================================================
// Copyright (c) Coalition of Good-Hearted Engineers
// Library Management System
//==================================================

namespace SimpleLibrary.Api.Models.Foundations.Books
{
    public class Book
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }
        public Guid ReaderId { get; set; }

        public Book(Guid readerId) =>
            ReaderId = readerId;
    }
}
