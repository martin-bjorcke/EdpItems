#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ItemsBackend.Models;

namespace ItemsBackend.Data
{
    public class ItemsBackendContext : DbContext
    {
        public ItemsBackendContext (DbContextOptions<ItemsBackendContext> options)
            : base(options)
        {
        }

        public DbSet<ItemsBackend.Models.EdpItem> EdpItem { get; set; }
    }
}
