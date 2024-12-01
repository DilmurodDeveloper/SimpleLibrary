//==================================================
// Copyright (c) Coalition of Good-Hearted Engineers
// Library Management System
//==================================================

using Xeptions;

namespace SimpleLibrary.Api.Models.Foundations.Readers.Exceptions
{
    public class NotFoundReaderException : Xeption
    {
        public NotFoundReaderException(Guid readerId)
            : base(message: $"No reader found with the ID: {readerId}.")
        { }
    }
}
