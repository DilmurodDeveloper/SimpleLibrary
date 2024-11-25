//==========================
// Simple Library Management
//==========================

using Xeptions;

namespace SimpleLibrary.Api.Models.Foundations.Exceptions.ReaderBook
{
    public class ReaderBookValidationException : Xeption
    {
        public ReaderBookValidationException(Xeption innerException)
            : base(message: "ReaderBook validation error occurred, fix the errors and try again",
                 innerException)
        { }
    }
}
