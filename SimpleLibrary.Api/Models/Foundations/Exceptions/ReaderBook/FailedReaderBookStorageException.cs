//==========================
// Simple Library Management
//==========================

using Xeptions;

namespace SimpleLibrary.Api.Models.Foundations.Exceptions.ReaderBook
{
    public class FailedReaderBookStorageException : Xeption
    {
        public FailedReaderBookStorageException(Exception innerException)
            : base(message: "Failed readerbook storage error occurred, contact support",
                  innerException)
        { }
    }
}
