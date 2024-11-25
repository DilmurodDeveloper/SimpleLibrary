//==========================
// Simple Library Management
//==========================

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace SimpleLibrary.Api.Brokers.Storages
{
    public partial class StorageBroker
    {
        public DbSet<Reader> Readers { get; set; }

        // ======= Reader CRUD Operations =======
        public async ValueTask<Reader> InsertReaderAsync(Reader reader)
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
    }
}