//==========================
// Simple Library Management
//==========================

using Microsoft.EntityFrameworkCore;
using SimpleLibrary.Api.Models.Foundations;

namespace SimpleLibrary.Api.Brokers.Storages
{
    public partial class StorageBroker
    {
        public DbSet<Reader> Readers { get; set; }
        public DbSet<Book> Books { get; set; }
    }
}

