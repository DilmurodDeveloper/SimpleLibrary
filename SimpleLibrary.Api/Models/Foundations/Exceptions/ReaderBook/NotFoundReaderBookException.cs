//==========================
// Simple Library Management
//==========================

using Xeptions;

namespace SimpleLibrary.Api.Models.Foundations.Exceptions.ReaderBook
{
    public class NotFoundReaderBookException : Xeption
    {
        public NotFoundReaderBookException(Guid readerbookId)
            : base(message: $"Couldn't find job with id: {readerbookId}")  
        { }
    }
}
