//==================================================
// Copyright (c) Coalition of Good-Hearted Engineers
// Library Management System
//==================================================

using Xeptions;

namespace SimpleLibrary.Api.Models.Foundations.Books.Exceptions
{
    public class FailedBookServiceException : Xeption
    {
        public FailedBookServiceException(Exception innerException)
            : base(message: "Failed book service error occured, Please contact support",
                 innerException)
        { }
    }
}
