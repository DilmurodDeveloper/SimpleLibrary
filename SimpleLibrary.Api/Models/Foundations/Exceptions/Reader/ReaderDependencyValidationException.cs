//==========================
// Simple Library Management
//==========================

using Xeptions;

namespace SimpleLibrary.Api.Models.Foundations.Exceptions.Reader
{
    public class ReaderDependencyValidationException : Xeption
    {
        public ReaderDependencyValidationException(Xeption innerException)
            : base(message: "Reader dependency validation error occurred, fix the errors and try again",
                 innerException)
        { }
    }
}
