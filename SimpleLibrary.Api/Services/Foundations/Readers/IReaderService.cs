//==========================
// Simple Library Management
//==========================

using SimpleLibrary.Api.Models.Foundations;

namespace SimpleLibrary.Api.Services.Foundations.Readers
{
    public interface IReaderService
    {
        ValueTask<Reader> AddBookAsync(Reader reader);
        IQueryable<Reader> RetrieveAllBooks();
        ValueTask<Reader> RetrieveBookByIdAsync(Guid readerId);
        ValueTask<Reader> ModifyBookAsync(Reader reader);
        ValueTask<Reader> RemoveBookByIdAsync(Guid readerId);
        ValueTask<Reader> RemoveBookByIdAsync(object someId);
    }
}
