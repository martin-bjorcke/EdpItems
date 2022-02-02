using Microsoft.EntityFrameworkCore;

namespace ItemsBackend.Data
{
        public class ItemsContext : DbContext
        {
            public ItemsContext(DbContextOptions<ItemsContext> options)
                : base(options)
            {
            }

            public DbSet<ItemsBackend.Models.EdpItem> EdpItem { get; set; }
        }
    
}
