//==================================================
// Copyright (c) Coalition of Good-Hearted Engineers
// Library Management System
//==================================================

using Xeptions;

namespace SimpleLibrary.Api.Models.Foundations.Readers.Exceptions
{
    public class FailedReaderServiceException : Xeption
    {
        public FailedReaderServiceException(Exception innerException)
            : base(message: "Failed reader service error occurred. Please contact support", 
                  innerException)
        { }
    }
}
