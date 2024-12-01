//==================================================
// Copyright (c) Coalition of Good-Hearted Engineers
// Library Management System
//==================================================

using Xeptions;

namespace SimpleLibrary.Api.Models.Foundations.ReaderBooks.Exceptions
{
    public class ReaderBookValidationException : Xeption
    {
        public ReaderBookValidationException(Exception innerException)
            : base(message: "A validation error occurred while processing the reader-book relationship", 
                  innerException)
        { }
    }
}
