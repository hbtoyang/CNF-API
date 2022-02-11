using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNFEFCore
{
    public class AmountTypeConfig : IEntityTypeConfiguration<AmountType>
    {
        public void Configure(EntityTypeBuilder<AmountType> builder)
        {
            builder.ToTable("AmounType");
            builder.Property(x => x.Description).HasMaxLength(255);
        }
    }
}
