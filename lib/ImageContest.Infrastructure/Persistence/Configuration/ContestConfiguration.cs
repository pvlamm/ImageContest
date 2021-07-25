using ImageContest.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageContest.Infrastructure.Persistence.Configuration
{
    public class ContestConfiguration : IEntityTypeConfiguration<Contest>
    {
        public void Configure(EntityTypeBuilder<Contest> builder)
        {
            throw new NotImplementedException();
        }
    }
}
