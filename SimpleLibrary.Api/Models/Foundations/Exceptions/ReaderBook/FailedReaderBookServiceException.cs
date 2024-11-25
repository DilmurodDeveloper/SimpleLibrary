//==========================
// Simple Library Management
//==========================

using Xeptions;

namespace SimpleLibrary.Api.Models.Foundations.Exceptions.ReaderBook
{
    public class FailedReaderBookServiceException : Xeption
    {
        public FailedReaderBookServiceException(Exception innerException)
            : base(message: "Failed readerbook service error occured, contact support",
                 innerException)
        { }
    }
}
