//==========================
// Simple Library Management
//==========================

using Xeptions;

namespace SimpleLibrary.Api.Models.Foundations.Exceptions.Book
{
    public class AlreadyExistBookException : Xeption
    {
        public AlreadyExistBookException(Exception innerException)
           : base(message: "Book already exists", innerException)
        { }
    }
}
