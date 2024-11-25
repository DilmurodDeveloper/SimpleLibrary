//==========================
// Simple Library Management
//==========================

using Xeptions;

namespace SimpleLibrary.Api.Models.Foundations.Exceptions.Reader
{
    public class ReaderValidationException : Xeption
    {
        public ReaderValidationException(Xeption innerException)
            : base(message: "Reader validation error occurred, fix the errors and try again",
                 innerException)
        { }
    }
}
