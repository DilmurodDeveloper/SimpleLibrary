//==========================
// Simple Library Management
//==========================

using Xeptions;

namespace SimpleLibrary.Api.Models.Foundations.Exceptions.ReaderBook
{
    public class InvalidReaderBookException : Xeption
    {
        public InvalidReaderBookException()
            : base(message: "ReaderBook is invalid")
        { }
    }
}
