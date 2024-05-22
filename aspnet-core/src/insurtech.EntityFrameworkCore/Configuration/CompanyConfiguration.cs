using insurtech.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace insurtech.Configration
{
    internal class CompanyConfiguration : IEntityTypeConfiguration<Company>
    {
        public void Configure(EntityTypeBuilder<Company> builder)
        {
            builder.Property(a => a.TaxNumber).HasAnnotation("RegularExpression", @"^\d{9}$");
            builder.Property(a=>a.Street).HasAnnotation("MinLength", 3).HasMaxLength(255);
        }
    }
}
