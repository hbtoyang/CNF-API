using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNFEFCore
{
    public class ContactConfig:IEntityTypeConfiguration<Contact>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Contact> builder)
        {
            builder.ToTable("Contact");
            builder.Property(x => x.FirstName).HasMaxLength(50);
            builder.Property(x => x.LastName).HasMaxLength(50);
            builder.Property(x => x.Email).HasMaxLength(255);
            builder.Property(x => x.CreatedBy).HasMaxLength(255);
            builder.Property(x => x.UpdateBy).HasMaxLength(255);
        }
    }
}