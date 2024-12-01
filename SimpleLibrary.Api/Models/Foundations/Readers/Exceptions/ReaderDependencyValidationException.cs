//==================================================
// Copyright (c) Coalition of Good-Hearted Engineers
// Library Management System
//==================================================

using Xeptions;

namespace SimpleLibrary.Api.Models.Foundations.Readers.Exceptions
{
    public class ReaderDependencyValidationException : Xeption
    {
        public ReaderDependencyValidationException(Exception innerException)
            : base(message: "Reader dependency validation error occurred. Please fix the errors and try again", 
                  innerException)
        { }
    }
}
