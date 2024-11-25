//==========================
// Simple Library Management
//==========================

using Xeptions;

namespace SimpleLibrary.Api.Models.Foundations.Exceptions.ReaderBook
{
    public class ReaderBookDependencyValidationException : Xeption
    {
        public ReaderBookDependencyValidationException(Xeption innerException)
            : base(message: "ReaderBook dependency validation error occurred, fix the errors and try again",
                 innerException)
        { }
    }
}
