//==========================
// Simple Library Management
//==========================

using Xeptions;

namespace SimpleLibrary.Api.Models.Foundations.Exceptions.ReaderBook
{
    public class NullReaderBookException : Xeption
    {
        public NullReaderBookException()
            : base(message: "ReaderBook is null")
        { }
    }
}
