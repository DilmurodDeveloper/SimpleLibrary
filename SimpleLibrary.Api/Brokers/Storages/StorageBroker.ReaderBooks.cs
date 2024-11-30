//==================================================
// Copyright (c) Coalition of Good-Hearted Engineers
// Library Management System
//==================================================

using Microsoft.EntityFrameworkCore;
using SimpleLibrary.Api.Models.Foundations.Books;
using SimpleLibrary.Api.Models.Foundations.Readers;
using SimpleLibrary.Api.Models.Foundations.ReadersBooks;

namespace SimpleLibrary.Api.Brokers.Storages
{
    public partial class StorageBroker
    {
        public async Task<ReaderBook> SelectReaderWithBooksAsync(Guid readerId)
        {
            Reader reader = await this.Set<Reader>().FirstOrDefaultAsync(r => r.Id == readerId);

            if (reader == null)
            {
                return null;
            }

            var books = await this.Set<Book>().Where(book => book.ReaderId == readerId).ToListAsync();

            return new ReaderBook
            {
                Reader = reader,
                Books = books
            };
        }
    }
}
