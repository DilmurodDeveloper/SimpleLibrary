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

        // ======= Book CRUD Operations =======
        public async ValueTask<Book> InsertBookAsync(Book book)
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
    }
}