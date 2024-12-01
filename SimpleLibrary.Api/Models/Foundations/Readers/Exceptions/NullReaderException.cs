//==================================================
// Copyright (c) Coalition of Good-Hearted Engineers
// Library Management System
//==================================================

using Xeptions;

namespace SimpleLibrary.Api.Models.Foundations.Readers.Exceptions
{
    public class NullReaderException : Xeption
    {
        public NullReaderException()
            : base(message: "Reader is null")
        { }
    }
}
