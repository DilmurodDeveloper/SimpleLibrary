//==========================
// Simple Library Management
//==========================

using SimpleLibrary.Api.Models.Foundations;

namespace SimpleLibrary.Api.Brokers.Storages
{
    public partial interface IStorageBroker
    {
        // ======= ReaderBook Operations =======
        ValueTask<ReaderBook> SelectReaderWithBooksAsync(Guid readerId);
    }
}
