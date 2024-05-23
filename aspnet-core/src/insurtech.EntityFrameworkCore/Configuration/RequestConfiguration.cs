using insurtech.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace insurtech.Configuration
{
    internal class RequestConfiguration : IEntityTypeConfiguration<Request>
    {
        public void Configure(EntityTypeBuilder<Request> builder)
        {
            builder.HasOne(a => a.InsurancePlan).WithMany(a => a.Requests).HasForeignKey(b => b.InsurancePlanId).OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(r => r.Customer)
                       .WithMany(u => u.Requests)
                       .HasForeignKey(r => r.Id)
                       .OnDelete(DeleteBehavior.NoAction);

           
        }
    }
}
