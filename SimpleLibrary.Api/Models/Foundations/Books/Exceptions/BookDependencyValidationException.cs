//==================================================
// Copyright (c) Coalition of Good-Hearted Engineers
// Library Management System
//==================================================

using Xeptions;

namespace SimpleLibrary.Api.Models.Foundations.Books.Exceptions
{
    public class BookDependencyValidationException : Xeption
    {
        public BookDependencyValidationException(Exception innerException)
            : base(message: "Book dependency validation error occurred. Fix the errors and try again", 
                  innerException)
        { }
    }
}
