using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNFEFCore
{
    public class DonationHistoryRecordConfig : IEntityTypeConfiguration<DonationHistoryRecord>
    {
        public void Configure(EntityTypeBuilder<DonationHistoryRecord> builder)
        {
            builder.ToTable("DonationHistoryRecord");
            builder.Property(x => x.CreatedBy).HasMaxLength(255);
        }
    }
}