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
    internal class HealthInsurancePlanConfiguration : IEntityTypeConfiguration<HealthInsurancePlan>
    {
        public void Configure(EntityTypeBuilder<HealthInsurancePlan> builder)
        {
            builder.Property(a => a.ClinicsCoverage).HasColumnType("decimal(18,2)");
            builder.Property(a => a.HospitalizationAndSurgery).HasColumnType("decimal(18,2)");
            builder.Property(a => a.OpticalCoverage).HasColumnType("decimal(18,2)");
            builder.Property(a => a.DentalCoverage).HasColumnType("decimal(18,2)");
        }
    }
}
