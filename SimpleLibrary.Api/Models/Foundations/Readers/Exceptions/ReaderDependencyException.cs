//==================================================
// Copyright (c) Coalition of Good-Hearted Engineers
// Library Management System
//==================================================

using Xeptions;

namespace SimpleLibrary.Api.Models.Foundations.Readers.Exceptions
{
    public class ReaderDependencyException : Xeption
    {
        public ReaderDependencyException(Exception innerException)
            : base(message: "Reader dependency error occurred. Please contact support", 
                  innerException)
        { }
    }
}
