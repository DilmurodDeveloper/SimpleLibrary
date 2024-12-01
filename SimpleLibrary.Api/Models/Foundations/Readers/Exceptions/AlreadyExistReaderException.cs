//==================================================
// Copyright (c) Coalition of Good-Hearted Engineers
// Library Management System
//==================================================

using Xeptions;

namespace SimpleLibrary.Api.Models.Foundations.Readers.Exceptions
{
    public class AlreadyExistReaderException : Xeption
    {
        public AlreadyExistReaderException(Guid readerId, Exception innerException)
            : base(message: $"Reader with ID {readerId} already exists", 
                  innerException)
        { }
    }
}
