using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using VatClinic.Data.Entities;

namespace VatClinic.Domain.ApiResponseModel
{
    public  class PatientResponse
    {
        [Required]
        [StringLength(20)]
        public string Name { get; set; }

        [Required]
        [StringLength(10)]
        public string ClinicNo { get; set; }

        [Required]
        public int Age { get; set; }

        public ICollection<Contract> Contracts { get; set; }

        public PatientResponse()
        {
            Contracts = new Collection<Contract>();
        }

        


       
    }
}
