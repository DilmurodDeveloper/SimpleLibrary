//==========================
// Simple Library Management
//==========================

using Xeptions;

namespace SimpleLibrary.Api.Models.Foundations.Exceptions.Reader
{
    public class AlreadyExistReaderException : Xeption
    {
        public AlreadyExistReaderException(Exception innerException)
           : base(message: "Reader already exists", innerException)
        { }
    }
}
