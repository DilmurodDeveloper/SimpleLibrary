//==================================================
// Copyright (c) Coalition of Good-Hearted Engineers
// Library Management System
//==================================================

using SimpleLibrary.Api.Brokers.Storages;
using SimpleLibrary.Api.Models.Foundations.ReadersBooks;

namespace SimpleLibrary.Api.Services.Foundations.ReaderBooks
{
    public class ReaderBookService : IReaderBookService
    {
        private readonly IStorageBroker storageBroker;

        public ReaderBookService(IStorageBroker storageBroker) =>
            this.storageBroker = storageBroker;

        public async ValueTask<ReaderBook> RetrieveReaderWithBooksAsync(Guid readerId) =>
            await this.storageBroker.SelectReaderWithBooksAsync(readerId);
    }
}
