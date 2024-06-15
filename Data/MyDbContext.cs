
using Core.Models;
using Data.Configurations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    
    public class MyDbContext : DbContext
    {
       
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<Praticien> Praticiens { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Adresse> Adresses { get; set; }
        public DbSet<Ville> Villes { get; set; }
        public DbSet<Departement> Departements { get; set; }
        public DbSet<Specialite> Specialites { get; set; }
        public DbSet<Motif> Motifs { get; set; }
        public DbSet<Calendrier> Calendriers { get; set; }
        public DbSet<RendezVous> Appointements { get; set; } 

        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        { }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.ApplyConfiguration(new AdresseConfiguration());
            modelBuilder.ApplyConfiguration(new AppointementConfiguration());  // Rendez vous

            // Menu Role Configurations
            // modelBuilder.ApplyConfiguration(new RoleMenuConfigurations());           

        }
    }
}
