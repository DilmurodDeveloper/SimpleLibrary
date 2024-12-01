//==================================================
// Copyright (c) Coalition of Good-Hearted Engineers
// Library Management System
//==================================================

using Xeptions;

namespace SimpleLibrary.Api.Models.Foundations.Books.Exceptions
{
    public class NotFoundBookException : Xeption
    {
        public NotFoundBookException(Guid bookId)
            : base(message: $"No book found with ID {bookId}")
        { }
    }
}
