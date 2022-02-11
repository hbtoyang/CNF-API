using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNFEFCore
{
    public class RecurringTypeConfig : IEntityTypeConfiguration<RecurringType>
    {
        public void Configure(EntityTypeBuilder<RecurringType> builder)
        {
            builder.ToTable("RecurringType");
            builder.Property(x => x.Name).HasMaxLength(255);
            builder.Property(x => x.Description).HasMaxLength(255);
        }
    }
}