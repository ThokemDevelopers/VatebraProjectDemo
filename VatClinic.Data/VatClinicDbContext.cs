using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using VatClinic.Data.Entities;

namespace VatClinic.Data
{
   public  class VatClinicDbContext : DbContext 
    {
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Ailment> Ailments { get; set; }
        public DbSet<Medication> Medications { get; set; }
        public DbSet<Contract> Contracts { get; set; }
        public DbSet<Resolve> Resolves  { get; set; }
        public DbSet<Administer> Administers { get; set; }


        public VatClinicDbContext(DbContextOptions options ) : base(options)
        {

        }

        protected override  void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Contract>()
            .HasKey(x => new { x.PatientId, x.AilmentId });


            modelBuilder.Entity<Resolve>()
          .HasKey(x => new { x.MedicationId, x.AilmentId });


            //  modelBuilder.Entity<Contract>()
            //          .HasOne(pt => pt.Patient)
            //          .WithMany()
            //          .HasForeignKey(pt => pt.PatientId);

            //  modelBuilder.Entity<Contract>()
            //         .HasOne(pt => pt.Ailment)
            //         .WithMany()
            //         .HasForeignKey(pt => pt.PatientId);
        }
    }
}
