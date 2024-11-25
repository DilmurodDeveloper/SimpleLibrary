//==========================
// Simple Library Management
//==========================

using Xeptions;

namespace SimpleLibrary.Api.Models.Foundations.Exceptions.Reader
{
    public class InvalidReaderException : Xeption
    {
        public InvalidReaderException()
            : base(message: "Reader is invalid")
        { }
    }
}
