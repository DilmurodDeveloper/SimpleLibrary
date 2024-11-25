//==========================
// Simple Library Management
//==========================

using SimpleLibrary.Api.Models.Foundations;

namespace SimpleLibrary.Api.Brokers.Storages
{
    public partial interface IStorageBroker
    {
        // ======= Book CRUD Operations =======
        ValueTask<Book> AddBookAsync(Book book);
        ValueTask<Book> SelectBookByIdAsync(Guid bookId);
        IQueryable<Book> SelectAllBooksAsync();
        ValueTask<Book> UpdateBookAsync(Book book);
        ValueTask<Book> DeleteBookAsync(Book book);

        // ======= Reader CRUD Operations =======
        ValueTask<Reader> AddReaderAsync(Reader reader);
        ValueTask<Reader> SelectReaderByIdAsync(Guid readerId);
        IQueryable<Reader> SelectAllReadersAsync();
        ValueTask<Reader> UpdateReaderAsync(Reader reader);
        ValueTask<Reader> DeleteReaderAsync(Reader reader);

        // ======= ReaderBook Operations =======
        ValueTask<ReaderBook> SelectReaderWithBooksAsync(Guid readerId);
    }
}
