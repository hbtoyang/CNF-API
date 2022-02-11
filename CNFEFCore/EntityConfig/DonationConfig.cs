using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNFEFCore
{
    public class DonationConfig : IEntityTypeConfiguration<Donation>
    {
        public void Configure(EntityTypeBuilder<Donation> builder)
        {
            builder.ToTable("Donation");
            builder.Property(x => x.CreatedBy).HasMaxLength(255);
            builder.Property(x => x.UpdateBy).HasMaxLength(255);
        }
    }
}