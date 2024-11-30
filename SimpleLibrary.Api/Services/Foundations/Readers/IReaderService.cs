//==================================================
// Copyright (c) Coalition of Good-Hearted Engineers
// Library Management System
//==================================================

using SimpleLibrary.Api.Models.Foundations.Readers;

namespace SimpleLibrary.Api.Services.Foundations.Readers
{
    public interface IReaderService
    {
        ValueTask<Reader> AddReaderAsync(Reader reader);
        IQueryable<Reader> RetrieveAllReaders();
        ValueTask<Reader> RetrieveReaderByIdAsync(Guid readerId);
        ValueTask<Reader> ModifyReaderAsync(Reader reader);
        ValueTask<Reader> RemoveReaderAsync(Reader reader);
    }
}
