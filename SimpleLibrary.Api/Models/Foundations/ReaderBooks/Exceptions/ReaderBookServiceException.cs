//==================================================
// Copyright (c) Coalition of Good-Hearted Engineers
// Library Management System
//==================================================

using Xeptions;

namespace SimpleLibrary.Api.Models.Foundations.ReaderBooks.Exceptions
{
    public class ReaderBookServiceException : Xeption
    {
        public ReaderBookServiceException(Exception innerException)
            : base(message: "An error occurred in the reader-book service", innerException)
        { }
    }
}
