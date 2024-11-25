//==========================
// Simple Library Management
//==========================

using Xeptions;

namespace SimpleLibrary.Api.Models.Foundations.Exceptions.ReaderBook
{
    public class ReaderBookServiceException : Xeption
    {
        public ReaderBookServiceException(Xeption innerException)
            : base(message: "ReaderBook service error occurred, contact support",
                 innerException)
        { }
    }
}
