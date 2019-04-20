using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using VatClinic.Data.Entities;

namespace VatClinic.Data
{
  public static class VatClinicDataContextSeeder
    {
      
        
        public static void SeedPatientData (this ModelBuilder builder)
        {
            builder.Entity<Patient>().HasData(
                   new Patient[]
                {
                  new Patient{Id = 1, Name = "Johnson Nwafor", Age = 20, ClinicNo = "VAT0100" , DateCreated = DateTime.Now, DateUpdated = DateTime.Now},
                  new Patient{Id = 2, Name = "Abel Emmanuel", Age = 35, ClinicNo = "VAT0101" , DateCreated = DateTime.Now, DateUpdated = DateTime.Now },
                  new Patient{Id = 3, Name = "Joy Ugu", Age = 46, ClinicNo = "VAT0102" , DateCreated = DateTime.Now, DateUpdated = DateTime.Now },
                  new Patient{Id = 4, Name = "James Daniel", Age = 28, ClinicNo = "VAT0103" , DateCreated = DateTime.Now, DateUpdated = DateTime.Now },
                  new Patient{Id = 5, Name = "McHenry Junior", Age = 16, ClinicNo = "VAT0104" , DateCreated = DateTime.Now, DateUpdated = DateTime.Now },
                  new Patient{Id = 6, Name = "Lizzy John", Age = 22, ClinicNo = "VAT0105" , DateCreated = DateTime.Now, DateUpdated = DateTime.Now },
                  new Patient{Id = 7, Name = "Kehinde Jamie", Age = 68, ClinicNo = "VAT0106" , DateCreated = DateTime.Now, DateUpdated = DateTime.Now },
                  new Patient{Id = 8, Name = "Amaka Mane", Age = 27, ClinicNo = "VAT0107" , DateCreated = DateTime.Now, DateUpdated = DateTime.Now },
                  new Patient{Id = 9, Name = "Lukas Moric", Age = 55, ClinicNo = "VAT0108" , DateCreated = DateTime.Now, DateUpdated = DateTime.Now },
                  new Patient{Id = 10, Name = "Jimmy jones", Age = 41, ClinicNo = "VAT0109" , DateCreated = DateTime.Now, DateUpdated = DateTime.Now }
                }
          ); 
        }


        public static void SeedAilmentData (this ModelBuilder builder)
        {
            builder.Entity<Ailment>().HasData(
                new Ailment[]
                {
                    new Ailment{Id = 1, Name = "Malaria" , Symptoms = "Weakness of the body, High Temperature, Severe Headache", DateCreated = DateTime.Now, DateUpdated = DateTime.Now},
                    new Ailment{Id = 2, Name = "Ulcer" , Symptoms = "Loss of Appetite", DateCreated = DateTime.Now, DateUpdated = DateTime.Now},
                    new Ailment{Id = 3, Name = "Breast Cancer" , Symptoms = "Lumps in the Breast", DateCreated = DateTime.Now, DateUpdated = DateTime.Now},
                    new Ailment{Id = 4, Name = "Ghonorea" , Symptoms = "Difficulty in Urinating", DateCreated = DateTime.Now, DateUpdated = DateTime.Now},
                    new Ailment{Id = 5, Name = "Diabetes" , Symptoms = "Pains around the lower Abdomen", DateCreated = DateTime.Now, DateUpdated = DateTime.Now},
                    new Ailment{Id = 6, Name = "Hypertension" , Symptoms = "Severe Chest Pain", DateCreated = DateTime.Now, DateUpdated = DateTime.Now},
                    new Ailment{Id = 7, Name = "Syphilis" , Symptoms = "Abnormal dischrage", DateCreated = DateTime.Now, DateUpdated = DateTime.Now},
                    new Ailment{Id = 8, Name = "Obesity" , Symptoms = "swollen of body parts", DateCreated = DateTime.Now, DateUpdated = DateTime.Now},
                    new Ailment{Id = 9, Name = "Cough" , Symptoms = "Cold, Swollen Face", DateCreated = DateTime.Now, DateUpdated = DateTime.Now},
                    new Ailment{Id = 10, Name = "Cataarh" , Symptoms = "Difficulty in breathing", DateCreated = DateTime.Now, DateUpdated = DateTime.Now},
                }
           );
        }

        public static void SeedMedicationData(this ModelBuilder builder)
        {
            builder.Entity<Medication>().HasData(
                new Medication[]
                {
                    new Medication{Id = 1, Name = "Leonart", Doses = "Take 2 in the morning 2 in the Evening", DateCreated = DateTime.Now, DateUpdated = DateTime.Now},
                    new Medication{Id = 2, Name = "Coflin", Doses = "2 Teaspoonful, every 5hrs", DateCreated = DateTime.Now, DateUpdated = DateTime.Now},
                    new Medication{Id = 3, Name = "Artfed", Doses = "4 at once", DateCreated = DateTime.Now, DateUpdated = DateTime.Now},
                    new Medication{Id = 4, Name = "Xamaforin", Doses = "Take 2 in the morning 2 in the Evening", DateCreated = DateTime.Now, DateUpdated = DateTime.Now},
                    new Medication{Id = 5, Name = "Becham", Doses = "Take 2 in the morning 2 in the Evening", DateCreated = DateTime.Now, DateUpdated = DateTime.Now},
                    new Medication{Id = 6, Name = "Paracetamol", Doses = "for Adult Take two every 6 hours", DateCreated = DateTime.Now, DateUpdated = DateTime.Now},
                    new Medication{Id = 7, Name = "Feldin", Doses = "2 Daily", DateCreated = DateTime.Now, DateUpdated = DateTime.Now},
                    new Medication{Id = 8, Name = "Xamarin", Doses = "Take 2 in the morning befoe meal", DateCreated = DateTime.Now, DateUpdated = DateTime.Now},
                    new Medication{Id = 9, Name = "Amalar", Doses = "3 Once", DateCreated = DateTime.Now, DateUpdated = DateTime.Now},
                    new Medication{Id = 10, Name = "Syrup", Doses = "Two Table Spoonful Daily", DateCreated = DateTime.Now, DateUpdated = DateTime.Now}

                }
             );
        }


        public static void SeedContractData(this ModelBuilder builder)
        {
            builder.Entity<Contract>().HasData(
                new Contract[]
                {
                    new Contract{ Id = 1, AilmentId = 1, PatientId = 1, DateCreated = DateTime.Now,DateUpdated = DateTime.Now },
                    new Contract{ Id = 2, AilmentId = 2, PatientId = 2, DateCreated = DateTime.Now ,DateUpdated = DateTime.Now},
                    new Contract{ Id = 3, AilmentId = 3, PatientId = 3, DateCreated = DateTime.Now ,DateUpdated = DateTime.Now},
                    new Contract{ Id = 4, AilmentId = 4, PatientId = 4, DateCreated = DateTime.Now,DateUpdated = DateTime.Now },
                    new Contract{ Id = 5, AilmentId = 5, PatientId = 5, DateCreated = DateTime.Now,DateUpdated = DateTime.Now },
                    new Contract{ Id = 6, AilmentId = 6, PatientId = 6, DateCreated = DateTime.Now ,DateUpdated = DateTime.Now},
                    new Contract{ Id = 7, AilmentId = 7, PatientId = 7, DateCreated = DateTime.Now ,DateUpdated = DateTime.Now},
                    new Contract{ Id = 8, AilmentId = 8, PatientId = 8, DateCreated = DateTime.Now,DateUpdated = DateTime.Now },
                    new Contract{ Id = 9, AilmentId = 9, PatientId = 9, DateCreated = DateTime.Now ,DateUpdated = DateTime.Now},
                    new Contract{ Id = 10, AilmentId = 10, PatientId = 10, DateCreated = DateTime.Now,DateUpdated = DateTime.Now }

                }
                
                );

        }

        public static void SeedResolveData (this ModelBuilder builder)
        {
            builder.Entity<Resolve>().HasData(
                new Resolve[]
                {
                    new Resolve{ Id = 1, AilmentId = 1, MedicationId = 1, DateCreated = DateTime.Now,DateUpdated = DateTime.Now},
                    new Resolve{ Id = 2, AilmentId = 2, MedicationId = 2, DateCreated = DateTime.Now,DateUpdated = DateTime.Now},
                    new Resolve{ Id = 3, AilmentId = 3, MedicationId = 3, DateCreated = DateTime.Now,DateUpdated = DateTime.Now},
                    new Resolve{ Id = 4, AilmentId = 4, MedicationId = 4, DateCreated = DateTime.Now,DateUpdated = DateTime.Now},
                    new Resolve{ Id = 5, AilmentId = 5, MedicationId = 5, DateCreated = DateTime.Now,DateUpdated = DateTime.Now},
                    new Resolve{ Id = 6, AilmentId = 6, MedicationId = 6, DateCreated = DateTime.Now,DateUpdated = DateTime.Now},
                    new Resolve{ Id = 7, AilmentId = 7, MedicationId = 7, DateCreated = DateTime.Now,DateUpdated = DateTime.Now},
                    new Resolve{ Id = 8, AilmentId = 8, MedicationId = 8, DateCreated = DateTime.Now,DateUpdated = DateTime.Now},
                    new Resolve{ Id = 9, AilmentId = 9, MedicationId = 9, DateCreated = DateTime.Now,DateUpdated = DateTime.Now},
                    new Resolve{ Id = 10, AilmentId = 10, MedicationId = 10, DateCreated = DateTime.Now,DateUpdated = DateTime.Now},
                    
                }
                );
        }

        public static void Administer (this ModelBuilder builder)
        {
            builder.Entity<Administer>().HasData(
                new Administer []
                {
                    new Administer { Id = 1, DateCreated = DateTime.Now ,DateUpdated = DateTime.Now},
                    new Administer { Id = 2, DateCreated = DateTime.Now ,DateUpdated = DateTime.Now},
                    new Administer { Id = 3, DateCreated = DateTime.Now ,DateUpdated = DateTime.Now},
                    new Administer { Id = 4, DateCreated = DateTime.Now ,DateUpdated = DateTime.Now},
                    new Administer { Id = 5, DateCreated = DateTime.Now ,DateUpdated = DateTime.Now},
                    new Administer { Id = 6, DateCreated = DateTime.Now ,DateUpdated = DateTime.Now},
                    new Administer { Id = 7, DateCreated = DateTime.Now ,DateUpdated = DateTime.Now},
                    new Administer { Id = 8, DateCreated = DateTime.Now ,DateUpdated = DateTime.Now},
                    new Administer { Id = 9, DateCreated = DateTime.Now ,DateUpdated = DateTime.Now},
                }
                );
        }
    }
}
