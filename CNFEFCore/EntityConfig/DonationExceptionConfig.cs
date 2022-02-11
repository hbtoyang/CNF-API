using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNFEFCore
{
    public class DonationExceptionConfig : IEntityTypeConfiguration<DonationException>
    {

        public void Configure(EntityTypeBuilder<DonationException> builder)
        {
            builder.ToTable("DonationException");
            builder.Property(x => x.CreatedBy).HasMaxLength(255);
        }
    }
}