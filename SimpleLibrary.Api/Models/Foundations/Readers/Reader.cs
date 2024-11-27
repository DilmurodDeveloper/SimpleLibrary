//==================================================
// Copyright (c) Coalition of Good-Hearted Engineers
// Library Management System
//==================================================

using SimpleLibrary.Api.Models.Foundations.Books;

namespace SimpleLibrary.Api.Models.Foundations.Readers
{
    public class Reader
    {
        public Guid Id { get; set; } 
        public string FirstName { get; set; } 
        public string LastName { get; set; } 
        public int Age { get; set; } 
        public List<Book> Books { get; set; } 

        public Reader() =>
            Books = new List<Book>();  
    }
}
