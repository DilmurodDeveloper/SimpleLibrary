//==================================================
// Copyright (c) Coalition of Good-Hearted Engineers
// Library Management System
//==================================================

using Xeptions;

namespace SimpleLibrary.Api.Models.Foundations.Books.Exceptions
{
    public class BookDependencyException : Xeption
    {
        public BookDependencyException(Exception innerException)
            : base(message: "Book dependency error occurred. Please contact support", 
                  innerException)
        { }
    }
}
