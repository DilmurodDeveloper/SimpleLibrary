//==================================================
// Copyright (c) Coalition of Good-Hearted Engineers
// Library Management System
//==================================================

using Xeptions;

namespace SimpleLibrary.Api.Models.Foundations.Readers.Exceptions
{
    public class ReaderValidationException : Xeption
    {
        public ReaderValidationException(Exception innerException)
            : base(message: "Reader validation error occurred. Please fix the validation errors and try again", 
                  innerException)
        { }
    }
}
