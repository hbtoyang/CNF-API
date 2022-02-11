using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNFEFCore
{
    public class ApplicationConfig : IEntityTypeConfiguration<Application>
    {
        public void Configure(EntityTypeBuilder<Application> builder)
        {
            builder.ToTable("Application");
            builder.Property(x => x.Title).HasMaxLength(50);
            builder.Property(x => x.FirstName).HasMaxLength(50);
            builder.Property(x => x.LastName).HasMaxLength(50);
            builder.Property(x => x.Organization).HasMaxLength(255);
            builder.Property(x => x.MailingAddress).HasMaxLength(255);
            builder.Property(x => x.Province).HasMaxLength(50);
            builder.Property(x => x.City).HasMaxLength(50);
            builder.Property(x => x.Country).HasMaxLength(50);
            builder.Property(x => x.PostalCode).HasMaxLength(50);
            builder.Property(x => x.Email).HasMaxLength(255);
            builder.Property(x => x.Phone).HasMaxLength(255);
            builder.Property(x => x.CreatedBy).HasMaxLength(255);
            builder.Property(x => x.UpdateBy).HasMaxLength(255);
        }
    }
}
