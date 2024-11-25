//==========================
// Simple Library Management
//==========================

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using SimpleLibrary.Api.Models.Foundations;

namespace SimpleLibrary.Api.Brokers.Storages
{
    public partial class StorageBroker
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Reader> Readers { get; set; }

        // ======= Book CRUD Operations =======
        public async ValueTask<Book> AddBookAsync(Book book)
        {
            using var broker = new StorageBroker(this.configuration);

            EntityEntry<Book> bookEntityEntry =
                await broker.Books.AddAsync(book);

            await broker.SaveChangesAsync();
            return bookEntityEntry.Entity;
        }

        public async ValueTask<Book> SelectBookByIdAsync(Guid bookId) =>
            await SelectAsync<Book>(bookId);

        public IQueryable<Book> SelectAllBooksAsync() =>
            SelectAll<Book>();

        public async ValueTask<Book> UpdateBookAsync(Book book) =>
            await UpdateAsync(book);

        public async ValueTask<Book> DeleteBookAsync(Book book) =>
            await DeleteAsync<Book>(book);
        

        // ======= Reader CRUD Operations =======
        public async ValueTask<Reader> AddReaderAsync(Reader reader)
        {
            using var broker = new StorageBroker(this.configuration);

            EntityEntry<Reader> readerEntityEntry =
                await broker.Readers.AddAsync(reader);

            await broker.SaveChangesAsync();
            return readerEntityEntry.Entity;
        }

        public async ValueTask<Reader> SelectReaderByIdAsync(Guid readerId) =>
            await SelectAsync<Reader>(readerId);

        public IQueryable<Reader> SelectAllReadersAsync() =>
            SelectAll<Reader>();

        public async ValueTask<Reader> UpdateReaderAsync(Reader reader) =>
            await UpdateAsync(reader);

        public async ValueTask<Reader> DeleteReaderAsync(Reader reader) =>
            await DeleteAsync<Reader>(reader);

        // ======= ReaderBook Operations =======
        public async ValueTask<ReaderBook> SelectReaderWithBooksAsync(Guid readerId)
        {
            Reader reader = await SelectAsync<Reader>(readerId);

            if (reader == null) return null;

            IQueryable<Book> books = SelectAll<Book>().Where(book => book.ReaderId == readerId);
            return new ReaderBook { Reader = reader, Books = await books.ToListAsync() };
        }
    }
}

