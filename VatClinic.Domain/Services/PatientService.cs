using System;
using System.Collections.Generic;
using System.Text;
using VatClinic.Data.Entities;
using VatClinic.Data.Repository.Interface;
using VatClinic.Domain.ApiResponseModel;
using VatClinic.Domain.Services.Interface;

namespace VatClinic.Domain.Services
{
   public  class PatientService : IPatientService<PatientResponse>
    {
        private readonly IPatientRepo<Patient> _PatientRepo;

        public PatientService(IPatientRepo<Patient> patientRepo)
        {
            _PatientRepo = patientRepo;
        }


        
        public IList<PatientResponse> GetAll()
        {
            IList<PatientResponse> PatientResult = new List<PatientResponse>();
            var Patients = _PatientRepo.SelectAll();
            foreach (var Patient in Patients)
            {

                PatientResult.Add(new PatientResponse {
                    Name = Patient.Name,
                    Age = Patient.Age,
                    ClinicNo = Patient.ClinicNo,
                    Contracts = Patient.Contracts

                });

            }
                return PatientResult;
        }
    }
}
