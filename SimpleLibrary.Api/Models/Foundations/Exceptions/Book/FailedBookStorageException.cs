//==========================
// Simple Library Management
//==========================

using Xeptions;

namespace SimpleLibrary.Api.Models.Foundations.Exceptions.Book
{
    public class FailedBookStorageException : Xeption
    {
        public FailedBookStorageException(Exception innerException)
            : base(message: "Failed book storage error occurred, contact support",
                  innerException)
        { }
    }
}
