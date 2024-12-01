//==================================================
// Copyright (c) Coalition of Good-Hearted Engineers
// Library Management System
//==================================================

using Xeptions;

namespace SimpleLibrary.Api.Models.Foundations.ReaderBooks.Exceptions
{
    public class AlreadyExistReaderBookException : Xeption
    {
        public AlreadyExistReaderBookException(Guid readerId, Guid bookId, Exception innerException)
            : base(message: $"Reader with ID {readerId} already has the book with ID {bookId}", 
                  innerException)
        { }
    }
}
