﻿using insurtech.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace insurtech.Configuration
{
    internal class FAQConfiguration : IEntityTypeConfiguration<FAQ>
    {
        public void Configure(EntityTypeBuilder<FAQ> builder)
        {
            builder.Property(a => a.Answer).HasAnnotation("MinLength", 3);
            builder.Property(a => a.Body).HasAnnotation("MinLength", 3);

        }
    }
}
