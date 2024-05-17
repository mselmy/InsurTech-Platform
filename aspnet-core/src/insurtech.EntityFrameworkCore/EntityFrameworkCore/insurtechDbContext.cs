using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using insurtech.Authorization.Roles;
using insurtech.Authorization.Users;
using insurtech.MultiTenancy;

namespace insurtech.EntityFrameworkCore
{
    public class insurtechDbContext : AbpZeroDbContext<Tenant, Role, User, insurtechDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public insurtechDbContext(DbContextOptions<insurtechDbContext> options)
            : base(options)
        {
        }
    }
}
