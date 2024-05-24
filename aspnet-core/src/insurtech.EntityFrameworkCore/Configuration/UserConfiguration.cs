using insurtech.Authorization.Users;
using insurtech.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace insurtech.Configration
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.Property(a => a.EmailAddress).HasAnnotation("RegularExpression", @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            builder.Property(a => a.PhoneNumber).HasMaxLength(11).HasAnnotation("RegularExpression", @"^01(0|1|2|5)[0-9]{8}$");
            builder.Property(a => a.Password).HasAnnotation("RegularExpression", @"^(?=.[A-Za-z])(?=.\d)[A-Za-z\d]{8,}$");
            builder.Property(a => a.UserName).HasAnnotation("MinLength", 3).HasMaxLength(20).HasAnnotation("RegularExpression", @"^[a-zA-Z][a-zA-Z0-9]*$");
            builder.HasIndex(a => a.EmailAddress).IsUnique();


            builder.HasData(
                new User
                {
                   

                    Id = 1, // Ensure this ID is unique and not conflicting
                    UserName = "admin",
                    Name = "Asmaa",
                    Surname = "Ash",
                    EmailAddress = "AsmaaAsh@gmail.com",
                    Password = new PasswordHasher<User>(new OptionsWrapper<PasswordHasherOptions>(new PasswordHasherOptions())).HashPassword(null, "123456789"),
                   
                    PhoneNumber = "01211236779",
                    TenantId = 1, // Adjust as necessary
                    IsActive = true,
                    IsEmailConfirmed = true,
                    CreationTime = DateTime.Now,
                    NormalizedUserName = "ADMIN",
                    NormalizedEmailAddress = "AsmaaAsh@gmail.com",
                    ConcurrencyStamp = Guid.NewGuid().ToString(),
                    SecurityStamp = Guid.NewGuid().ToString()

                }
                );





        }
    }
}
