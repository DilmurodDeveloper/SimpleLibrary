//==================================================
// Copyright (c) Coalition of Good-Hearted Engineers
// Library Management System
//==================================================

using Xeptions;

namespace SimpleLibrary.Api.Models.Foundations.ReaderBooks.Exceptions
{
    public class ReaderBookDependencyException : Xeption
    {
        public ReaderBookDependencyException(Exception innerException)
            : base(message: "A dependency error occurred while handling the reader-book relationship", 
                  innerException)
        { }
    }
}
