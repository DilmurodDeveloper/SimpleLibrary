//==========================
// Simple Library Management
//==========================

using Xeptions;

namespace SimpleLibrary.Api.Models.Foundations.Exceptions.Book
{
    public class NullBookException : Xeption
    {
        public NullBookException()
            : base(message: "Book is null")
        { }
    }
}
