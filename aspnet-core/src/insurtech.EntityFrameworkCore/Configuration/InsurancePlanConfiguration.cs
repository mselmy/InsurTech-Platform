using insurtech.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace insurtech.Configuration
{
    internal class InsurancePlanConfiguration : IEntityTypeConfiguration<InsurancePlan>
    {
        public void Configure(EntityTypeBuilder<InsurancePlan> builder)
        {
            builder.Property(a => a.YearlyCoverage).HasColumnType("decimal(18,2)");
            builder.Property(a => a.Quotation).HasColumnType("decimal(18,2)");

            builder.UseTptMappingStrategy();
        }
    }
}
