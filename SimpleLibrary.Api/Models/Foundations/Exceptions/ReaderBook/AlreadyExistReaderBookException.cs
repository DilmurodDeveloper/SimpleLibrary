//==========================
// Simple Library Management
//==========================

using Xeptions;

namespace SimpleLibrary.Api.Models.Foundations.Exceptions.ReaderBook
{
    public class AlreadyExistReaderBookException : Xeption
    {
        public AlreadyExistReaderBookException(Exception innerException)
           : base(message: "ReaderBook already exists", innerException)
        { }
    }
}
