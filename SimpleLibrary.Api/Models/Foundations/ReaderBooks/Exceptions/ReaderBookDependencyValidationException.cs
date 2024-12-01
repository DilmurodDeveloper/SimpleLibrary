//==================================================
// Copyright (c) Coalition of Good-Hearted Engineers
// Library Management System
//==================================================

using Xeptions;

namespace SimpleLibrary.Api.Models.Foundations.ReaderBooks.Exceptions
{
    public class ReaderBookDependencyValidationException : Xeption
    {
        public ReaderBookDependencyValidationException(Exception innerException)
            : base(message: "A validation error occurred while handling the reader-book relationship dependencies", 
                  innerException)
        { }
    }
}
