//==========================
// Simple Library Management
//==========================

using Xeptions;

namespace SimpleLibrary.Api.Models.Foundations.Exceptions.Reader
{
    public class NullReaderException : Xeption
    {
        public NullReaderException()
            : base(message: "Reader is null")
        { }
    }
}
