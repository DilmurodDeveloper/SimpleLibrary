//==================================================
// Copyright (c) Coalition of Good-Hearted Engineers
// Library Management System
//==================================================

using SimpleLibrary.Api.Models.Foundations.Readers;

namespace SimpleLibrary.Api.Brokers.Storages
{
    public partial interface IStorageBroker
    {
        ValueTask<Reader> InsertReaderAsync(Reader reader);
        ValueTask<Reader> SelectReaderByIdAsync(Guid readerId);
        IQueryable<Reader> SelectAllReaders();
        ValueTask<Reader> UpdateReaderAsync(Reader reader);
        ValueTask<Reader> DeleteReaderAsync(Reader reader);
    }
}
