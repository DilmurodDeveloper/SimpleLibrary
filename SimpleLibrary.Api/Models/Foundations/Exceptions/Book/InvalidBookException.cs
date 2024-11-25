//==========================
// Simple Library Management
//==========================

using Xeptions;

namespace SimpleLibrary.Api.Models.Foundations.Exceptions.Book
{
    public class InvalidBookException : Xeption
    {
        public InvalidBookException()
            : base(message: "Book is invalid")
        { }
    }
}
