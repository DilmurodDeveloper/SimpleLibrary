//==================================================
// Copyright (c) Coalition of Good-Hearted Engineers
// Library Management System
//==================================================

using SimpleLibrary.Api.Models.Foundations.ReadersBooks;

namespace SimpleLibrary.Api.Services.Foundations.ReaderBooks
{
    public interface IReaderBookService
    {
        ValueTask<ReaderBook> RetrieveReaderWithBooksAsync(Guid readerId);
    }
}
