//==================================================
// Copyright (c) Coalition of Good-Hearted Engineers
// Library Management System
//==================================================

using Xeptions;

namespace SimpleLibrary.Api.Models.Foundations.Books.Exceptions
{
    public class NullBookException : Xeption
    {
        public NullBookException()
            : base(message: "The book is null")
        { }
    }
}
