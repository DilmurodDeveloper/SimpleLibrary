//==================================================
// Copyright (c) Coalition of Good-Hearted Engineers
// Library Management System
//==================================================

using Xeptions;

namespace SimpleLibrary.Api.Models.Foundations.ReaderBooks.Exceptions
{
    public class NullReaderBookException : Xeption
    {
        public NullReaderBookException(Guid readerId, Guid bookId, Exception innerException)
            : base(message: $"Reader with ID {readerId} and book with ID {bookId} is null or invalid", 
                  innerException)
        { }
    }
}
