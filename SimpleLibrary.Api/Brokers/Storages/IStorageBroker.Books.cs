//==========================
// Simple Library Management
//==========================

using SimpleLibrary.Api.Models.Foundations;

namespace SimpleLibrary.Api.Brokers.Storages
{
    public partial interface IStorageBroker
    {
        // ======= Book CRUD Operations =======
        ValueTask<Book> InsertBookAsync(Book book);
        ValueTask<Book> SelectBookByIdAsync(Guid bookId);
        IQueryable<Book> SelectAllBooksAsync();
        ValueTask<Book> UpdateBookAsync(Book book);
        ValueTask<Book> DeleteBookAsync(Book book);
    }
}
