//==================================================
// Copyright (c) Coalition of Good-Hearted Engineers
// Library Management System
//==================================================

using Xeptions;

namespace SimpleLibrary.Api.Models.Foundations.Books.Exceptions
{
    public class FailedBookStorageException : Xeption
    {
        public FailedBookStorageException(Exception innerException)
            : base(message: "Failed book storage error occurred. Please contact support", 
                  innerException)
        { }
    }
}
