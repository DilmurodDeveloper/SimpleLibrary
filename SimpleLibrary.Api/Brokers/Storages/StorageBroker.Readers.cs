﻿//==================================================
// Copyright (c) Coalition of Good-Hearted Engineers
// Library Management System
//==================================================

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using SimpleLibrary.Api.Models.Foundations.Readers;

namespace SimpleLibrary.Api.Brokers.Storages
{
    public partial class StorageBroker
    {
        public DbSet<Reader> Readers { get; set; }

        public async Task<Reader> InsertReaderAsync(Reader reader)
        {
            using var broker = new StorageBroker(this.configuration);

            EntityEntry<Reader> readerEntityEntry =
                await broker.Readers.AddAsync(reader);

            await broker.SaveChangesAsync();

            return readerEntityEntry.Entity;
        }

        public IQueryable<Reader> SelectAllReaders() =>
            SelectAll<Reader>();

        public async Task<Reader> SelectReaderByIdAsync(Guid readerId) =>
            await SelectAsync<Reader>(readerId);

        public async Task<Reader> UpdateReaderAsync(Reader reader) =>
            await UpdateAsync(reader);

        public async Task<Reader> DeleteReaderAsync(Reader reader) =>
            await DeleteAsync<Reader>(reader);
    }
}