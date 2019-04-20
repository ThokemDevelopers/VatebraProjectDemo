using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VatClinic.Data.Entities;
using VatClinic.Data.Repository.Interface;

namespace VatClinic.Data.Repository
{
   public  class PatientRepo : IPatientRepo<Patient>
    {
        private readonly VatClinicDbContext _VatClinicDb; 

        public PatientRepo(VatClinicDbContext VatClinicDb)
        {
            _VatClinicDb = VatClinicDb;
        }


        public IList<Patient> SelectAll() => _VatClinicDb.Patients.ToList();



    }
}
