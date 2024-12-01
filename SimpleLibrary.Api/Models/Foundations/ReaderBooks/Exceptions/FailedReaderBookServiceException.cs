//==================================================
// Copyright (c) Coalition of Good-Hearted Engineers
// Library Management System
//==================================================

using Xeptions;

namespace SimpleLibrary.Api.Models.Foundations.ReaderBooks.Exceptions
{
    public class FailedReaderBookServiceException : Xeption
    {
        public FailedReaderBookServiceException(Exception innerException)
            : base(message: "An error occurred while processing the reader-book relationship in the service", 
                  innerException)
        { }
    }
}
