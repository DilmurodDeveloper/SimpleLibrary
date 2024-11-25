//==========================
// Simple Library Management
//==========================

using Xeptions;

namespace SimpleLibrary.Api.Models.Foundations.Exceptions.ReaderBook
{
    public class ReaderBookDependencyException : Xeption
    {
        public ReaderBookDependencyException(Xeption innerException)
            : base(message: "ReaderBook dependency error occured, contact support",
                 innerException)
        { }
    }
}
