//==========================
// Simple Library Management
//==========================

using Xeptions;

namespace SimpleLibrary.Api.Models.Foundations.Exceptions.Book
{
    public class NotFoundBookException : Xeption
    {
        public NotFoundBookException(Guid bookId)
            : base(message: $"Couldn't find job with id: {bookId}") 
        { }
    }
}
