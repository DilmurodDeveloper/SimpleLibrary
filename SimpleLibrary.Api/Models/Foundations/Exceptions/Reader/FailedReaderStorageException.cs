//==========================
// Simple Library Management
//==========================

using Xeptions;

namespace SimpleLibrary.Api.Models.Foundations.Exceptions.Reader
{
    public class FailedReaderStorageException : Xeption
    {
        public FailedReaderStorageException(Exception innerException)
            : base(message: "Failed reader storage error occurred, contact support",
                  innerException)
        { }
    }
}
