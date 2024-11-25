//==========================
// Simple Library Management
//==========================

using Xeptions;

namespace SimpleLibrary.Api.Models.Foundations.Exceptions.Reader
{
    public class FailedReaderServiceException : Xeption
    {
        public FailedReaderServiceException(Exception innerException)
            : base(message: "Failed reader service error occured, contact support",
                 innerException)
        { }
    }
}
