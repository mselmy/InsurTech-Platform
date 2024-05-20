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
    public class UserConfiguration : IEntityTypeConfiguration<InsuranceUser>
    {
        public void Configure(EntityTypeBuilder<InsuranceUser> builder)
        {
            builder.Property(a => a.Email).HasAnnotation("RegularExpression", @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            builder.Property(a => a.Number).HasMaxLength(11).HasAnnotation("RegularExpression", @"^01(0|1|2|5)[0-9]{8}$");
            builder.Property(a => a.Password).HasMaxLength(11).HasAnnotation("RegularExpression", @"^(?=.[A-Za-z])(?=.\d)[A-Za-z\d]{8,}$");
            builder.Property(a => a.FirstName).HasAnnotation("MinLength", 3).HasMaxLength(20).HasAnnotation("RegularExpression", @"^[a-zA-Z][a-zA-Z0-9]*$");
            builder.Property(a => a.LastName).HasAnnotation("MinLength", 3).HasMaxLength(20).HasAnnotation("RegularExpression", @"^[a-zA-Z][a-zA-Z0-9]*$");
            builder.HasIndex(a => a.Email).IsUnique();

            builder.UseTptMappingStrategy();

            builder.HasData(
                new InsuranceUser
                {
                    InsuranceUserId=1,
                    Email="AsmaaAsh@gmail.com",
                    Password="2052024",
                    Number="01211236779",
                    FirstName="Asmaa",
                    LastName="Ash"
                }
                );
        }
    }
}
