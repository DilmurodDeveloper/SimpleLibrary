//==================================================
// Copyright (c) Coalition of Good-Hearted Engineers
// Library Management System
//==================================================

using Xeptions;

namespace SimpleLibrary.Api.Models.Foundations.Readers.Exceptions
{
    public class ReaderServiceException : Xeption
    {
        public ReaderServiceException(Exception innerException)
            : base(message: "Reader service error occurred. Please contact support",
                  innerException)
        { }
    }
}
