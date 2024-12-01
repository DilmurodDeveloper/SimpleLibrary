//==================================================
// Copyright (c) Coalition of Good-Hearted Engineers
// Library Management System
//==================================================

using Xeptions;

namespace SimpleLibrary.Api.Models.Foundations.Books.Exceptions
{
    public class InvalidBookException : Xeption
    {
        public InvalidBookException()
            : base(message: "Book is invalid")
        { }
    }
}
