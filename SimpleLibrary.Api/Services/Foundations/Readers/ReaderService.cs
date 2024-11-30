//==================================================
// Copyright (c) Coalition of Good-Hearted Engineers
// Library Management System
//==================================================

using SimpleLibrary.Api.Brokers.Storages;
using SimpleLibrary.Api.Models.Foundations.Readers;

namespace SimpleLibrary.Api.Services.Foundations.Readers
{
    public class ReaderService : IReaderService
    {
        private readonly IStorageBroker storageBroker;

        public ReaderService(IStorageBroker storageBroker) =>
            this.storageBroker = storageBroker;

        public async ValueTask<Reader> AddReaderAsync(Reader reader) =>
            await this.storageBroker.InsertReaderAsync(reader);

        public IQueryable<Reader> RetrieveAllReaders() =>
            this.storageBroker.SelectAllReaders();

        public async ValueTask<Reader> RetrieveReaderByIdAsync(Guid readerId) =>
            await this.storageBroker.SelectReaderByIdAsync(readerId);

        public async ValueTask<Reader> ModifyReaderAsync(Reader reader) =>
            await this.storageBroker.UpdateReaderAsync(reader);

        public async ValueTask<Reader> RemoveReaderAsync(Reader reader) =>
            await this.storageBroker.DeleteReaderAsync(reader);
    }
}
