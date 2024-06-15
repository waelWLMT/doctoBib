using Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Configurations
{
    public class AdresseConfiguration : IEntityTypeConfiguration<Adresse>
    {
        public void Configure(EntityTypeBuilder<Adresse> builder)
        {
            builder.HasOne<Ville>(a=> a.Ville).WithMany().OnDelete(DeleteBehavior.Restrict);
            builder.HasOne<Departement>(a=> a.Departement).WithMany().OnDelete(DeleteBehavior.Restrict);
        }
    }
}
