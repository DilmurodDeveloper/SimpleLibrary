//==================================================
// Copyright (c) Coalition of Good-Hearted Engineers
// Library Management System
//==================================================

using SimpleLibrary.Api.Models.Foundations.Readers;

namespace SimpleLibrary.Api.Brokers.Storages
{
    public partial interface IStorageBroker
    {
        Task<Reader> InsertReaderAsync(Reader reader);
        Task<Reader> SelectReaderByIdAsync(Guid readerId);
        IQueryable<Reader> SelectAllReaders();
        Task<Reader> UpdateReaderAsync(Reader reader);
        Task<Reader> DeleteReaderAsync(Reader reader);
    }
}
