//==========================
// Simple Library Management
//==========================

using Xeptions;

namespace SimpleLibrary.Api.Models.Foundations.Exceptions.Book
{
    public class BookDependencyValidationException : Xeption
    {
        public BookDependencyValidationException(Xeption innerException)
            : base(message: "Book dependency validation error occurred, fix the errors and try again",
                 innerException)
        { }
    }
}
