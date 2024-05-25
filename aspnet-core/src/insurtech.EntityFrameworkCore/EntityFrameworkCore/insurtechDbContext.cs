using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using insurtech.Authorization.Roles;
using insurtech.Authorization.Users;
using insurtech.MultiTenancy;
using System.Reflection;
using insurtech.Models;

namespace insurtech.EntityFrameworkCore
{
    public class insurtechDbContext : AbpZeroDbContext<Tenant, Role, User, insurtechDbContext>
    {
        /* Define a DbSet for each entity of the application */
        //public DbSet<Users> Users { get; set; }
        public DbSet<Article> Articles { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Company> companies { get; set; }
        public DbSet<FAQ> FAQs { get; set; }
        public DbSet<Feedback> feedbacks { get; set; }
        public DbSet<HealthInsurancePlan> HealthInsurancePlans { get; set; }
        public DbSet<HomeInsurancePlan> HomeInsurancePlans { get; set; }
        public DbSet<InsurancePlan> InsurancePlans { get; set; }
        public DbSet<MotorInsurancePlan> MotorInsurancePlans { get; set; }
        public DbSet<Notification> Notifications { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Request> Requests { get; set; }
        public DbSet<RequestQuestion> RequestQuestions { get; set; }


        public insurtechDbContext(DbContextOptions<insurtechDbContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(modelBuilder);
        }
        

    }
}
