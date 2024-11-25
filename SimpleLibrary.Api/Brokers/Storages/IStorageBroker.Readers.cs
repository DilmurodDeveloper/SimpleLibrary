//==========================
// Simple Library Management
//==========================

namespace SimpleLibrary.Api.Brokers.Storages
{
    public partial interface IStorageBroker
    {
        // ======= Reader CRUD Operations =======
        ValueTask<Reader> InsertReaderAsync(Reader reader);
        ValueTask<Reader> SelectReaderByIdAsync(Guid readerId);
        IQueryable<Reader> SelectAllReadersAsync();
        ValueTask<Reader> UpdateReaderAsync(Reader reader);
        ValueTask<Reader> DeleteReaderAsync(Reader reader);
    }
}
