//==================================================
// Copyright (c) Coalition of Good-Hearted Engineers
// Library Management System
//==================================================

using SimpleLibrary.Api.Models.Foundations.Books;
using SimpleLibrary.Api.Models.Foundations.Readers;

namespace SimpleLibrary.Api.Models.Foundations.ReadersBooks
{
    public class ReaderBook
    {
        public Reader Reader { get; set; } 
        public List<Book> Books { get; set; }

        public ReaderBook() =>
            Books = new List<Book>();
    }
}
