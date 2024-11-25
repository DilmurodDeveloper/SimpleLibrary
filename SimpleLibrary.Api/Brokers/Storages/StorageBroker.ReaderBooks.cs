//==========================
// Simple Library Management
//==========================

using Microsoft.EntityFrameworkCore;
using SimpleLibrary.Api.Models.Foundations;

namespace SimpleLibrary.Api.Brokers.Storages
{
    public partial class StorageBroker
    {
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