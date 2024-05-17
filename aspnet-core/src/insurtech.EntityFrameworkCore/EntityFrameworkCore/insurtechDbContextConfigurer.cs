using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace insurtech.EntityFrameworkCore
{
    public static class insurtechDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<insurtechDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<insurtechDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
