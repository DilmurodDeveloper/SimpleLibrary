//==========================
// Simple Library Management
//==========================

using Xeptions;

namespace SimpleLibrary.Api.Models.Foundations.Exceptions.Reader
{
    public class NotFoundReaderException : Xeption
    {
        public NotFoundReaderException(Guid readerId)
            : base(message: $"Couldn't find job with id: {readerId}") { }
    }
}
