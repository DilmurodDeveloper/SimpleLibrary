//==========================
// Simple Library Management
//==========================

using Xeptions;

namespace SimpleLibrary.Api.Models.Foundations.Exceptions.Reader
{
    public class ReaderDependencyException : Xeption
    {
        public ReaderDependencyException(Xeption innerException)
            : base(message: "Reader dependency error occured, contact support",
                 innerException)
        { }
    }
}
