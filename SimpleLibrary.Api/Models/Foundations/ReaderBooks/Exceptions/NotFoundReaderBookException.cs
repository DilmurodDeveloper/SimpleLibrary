//==================================================
// Copyright (c) Coalition of Good-Hearted Engineers
// Library Management System
//==================================================

using Xeptions;

namespace SimpleLibrary.Api.Models.Foundations.ReaderBooks.Exceptions
{
    public class NotFoundReaderBookException : Xeption
    {
        public NotFoundReaderBookException(Guid readerId, Guid bookId, Exception innerException)
            : base(message: $"Reader with ID {readerId} and book with ID {bookId} not found", innerException)
        { }
    }
}
