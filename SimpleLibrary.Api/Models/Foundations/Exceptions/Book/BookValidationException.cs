//==========================
// Simple Library Management
//==========================

using Xeptions;

namespace SimpleLibrary.Api.Models.Foundations.Exceptions.Book
{
    public class BookValidationException : Xeption
    {
        public BookValidationException(Xeption innerException)
            : base(message: "Book validation error occurred, fix the errors and try again",
                 innerException)
        { }
    }
}
