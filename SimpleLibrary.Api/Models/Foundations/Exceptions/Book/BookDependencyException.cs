//==========================
// Simple Library Management
//==========================

using Xeptions;

namespace SimpleLibrary.Api.Models.Foundations.Exceptions.Book
{
    public class BookDependencyException : Xeption
    {
        public BookDependencyException(Xeption innerException)
            : base(message: "Book dependency error occured, contact support",
                 innerException)
        { }
    }
}
