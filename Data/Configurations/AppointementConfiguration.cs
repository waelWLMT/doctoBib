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
    public class AppointementConfiguration : IEntityTypeConfiguration<RendezVous>
    {
        public void Configure(EntityTypeBuilder<RendezVous> builder)
        {
            builder.HasOne(x=> x.Patient).WithMany().OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(x => x.Praticien).WithMany().OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(x => x.Motif).WithMany().OnDelete(DeleteBehavior.Restrict);

        }
    }
}
