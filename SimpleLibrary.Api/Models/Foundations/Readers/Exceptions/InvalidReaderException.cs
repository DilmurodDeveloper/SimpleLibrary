//==================================================
// Copyright (c) Coalition of Good-Hearted Engineers
// Library Management System
//==================================================

using Xeptions;

namespace SimpleLibrary.Api.Models.Foundations.Readers.Exceptions
{
    public class InvalidReaderException : Xeption
    {
        public InvalidReaderException()
            : base(message: "Reader is invalid")
        { }
    }
}
