//==========================
// Simple Library Management
//==========================

using SimpleLibrary.Api.Models.Foundations;

namespace SimpleLibrary.Api.Services.Foundations.Books
{
    public interface IBookService
    {
        ValueTask<Book> AddBookAsync(Book book);
        IQueryable<Book> RetrieveAllBooks();
        ValueTask<Book> RetrieveBookByIdAsync(Guid bookId);
        ValueTask<Book> ModifyBookAsync(Book book);
        ValueTask<Book> RemoveBookByIdAsync(Guid bookId);
        ValueTask<Book> RemoveBookByIdAsync(object someId);
    }
}
