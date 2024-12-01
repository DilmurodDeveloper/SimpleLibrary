//==================================================
// Copyright (c) Coalition of Good-Hearted Engineers
// Library Management System
//==================================================

using Xeptions;

namespace SimpleLibrary.Api.Models.Foundations.Readers.Exceptions
{
    public class FailedReaderStorageException : Xeption
    {
        public FailedReaderStorageException(Exception innerException)
            : base(message: "Failed reader storage error occurred. Please contact support", 
                  innerException)
        { }
    }
}
