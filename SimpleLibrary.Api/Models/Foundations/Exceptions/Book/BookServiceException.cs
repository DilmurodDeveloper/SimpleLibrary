//==========================
// Simple Library Management
//==========================

using Xeptions;

namespace SimpleLibrary.Api.Models.Foundations.Exceptions.Book
{
    public class BookServiceException : Xeption
    {
        public BookServiceException(Xeption innerException)
            : base(message: "Book service error occurred, contact support",
                 innerException)
        { }
    }
}
