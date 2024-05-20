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
    internal class RequestQuestionConfiguration : IEntityTypeConfiguration<RequestQuestion>
    {
        public void Configure(EntityTypeBuilder<RequestQuestion> builder)
        {
            builder.HasKey(a => new { a.QuestionId, a.RequestId });
        }
    }
}
