//==================================================
// Copyright (c) Coalition of Good-Hearted Engineers
// Library Management System
//==================================================

using Xeptions;

namespace Sheenam.Api.Models.Foundations.Books.Exceptions
{
    public class AlreadyExistBookException : Xeption
    {
        public AlreadyExistBookException(Guid bookId, Exception innerException)
            : base(message: $"Book with ID {bookId} already exists.", innerException)
        { }
    }
}