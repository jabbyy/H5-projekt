using H5_projekt_2023.models;
using Microsoft.EntityFrameworkCore;

namespace H5_projekt_2023.Data
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options) { }

        public DbSet<UserInfo> Users { get; set; }
    }
}
