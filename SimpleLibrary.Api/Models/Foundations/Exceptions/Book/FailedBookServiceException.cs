//==========================
// Simple Library Management
//==========================

using Xeptions;

namespace SimpleLibrary.Api.Models.Foundations.Exceptions.Book
{
    public class FailedBookServiceException : Xeption
    {
        public FailedBookServiceException(Exception innerException)
            : base(message: "Failed book service error occured, contact support",
                 innerException)
        { }
    }
}
