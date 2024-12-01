//==================================================
// Copyright (c) Coalition of Good-Hearted Engineers
// Library Management System
//==================================================

using Xeptions;

namespace SimpleLibrary.Api.Models.Foundations.Books.Exceptions
{
    public class BookServiceException : Xeption
    {
        public BookServiceException(Exception innerException)
            : base(message: "Book service error occurred. Please contact support", 
                  innerException)
        { }
    }
}
