//==================================================
// Copyright (c) Coalition of Good-Hearted Engineers
// Library Management System
//==================================================

using Xeptions;

namespace SimpleLibrary.Api.Models.Foundations.ReaderBooks.Exceptions
{
    public class InvalidReaderBookException : Xeption
    {
        public InvalidReaderBookException()
            : base(message: "ReaderBook is invalid")
        { }
    }
}
