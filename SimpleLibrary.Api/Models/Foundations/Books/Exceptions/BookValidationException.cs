//==================================================
// Copyright (c) Coalition of Good-Hearted Engineers
// Library Management System
//==================================================

using Xeptions;

namespace SimpleLibrary.Api.Models.Foundations.Books.Exceptions
{
    public class BookValidationException : Xeption
    {
        public BookValidationException(Exception innerException)
            : base(message: "Book validation error occurred. Fix the errors and try again", 
                  innerException)
        { }
    }
}
