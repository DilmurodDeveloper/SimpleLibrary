//==========================
// Simple Library Management
//==========================

using Xeptions;

namespace SimpleLibrary.Api.Models.Foundations.Exceptions.Reader
{
    public class ReaderServiceException : Xeption
    {
        public ReaderServiceException(Xeption innerException)
            : base(message: "Reader service error occurred, contact support",
                 innerException)
        { }
    }
}
