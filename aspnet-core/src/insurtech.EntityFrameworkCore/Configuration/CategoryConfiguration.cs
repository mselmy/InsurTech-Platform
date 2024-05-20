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
    internal class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(
                new Category
                {
                    CategoryId = 1,
                    Name = "HealthInsurance",
                    Description = "Health insurance covers medical expenses like doctor visits, hospital stays, and medications. We offer plans for individuals, families, and businesses, including short-term and supplemental options."

                },
                new Category
                {
                    CategoryId = 2,
                    Name = "HomeInsurance",
                    Description = "Home insurance protects your home and belongings from risks like fire, theft, and natural disasters. Our plans cover repairs, replacements, and living expenses, ensuring peace of mind for homeowners."

                }, new Category
                {
                    CategoryId = 3,
                    Name = "MotorInsurance",
                    Description = "Motor insurance covers your vehicle against accidents, theft, and damage. Our policies offer comprehensive protection, including liability, collision, and personal injury coverage, ensuring peace of mind on the road."

                }
            );
        }
    }
}
