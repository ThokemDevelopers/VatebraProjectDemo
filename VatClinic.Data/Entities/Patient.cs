using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace VatClinic.Data.Entities
{
    public class Patient : BaseEntity
    {
        

        [Required]
        [StringLength(20)]
        public int Name { get; set; }

        [Required]
        [StringLength(10)]
        public string ClinicNo { get; set; }

        [Required]
        public int Age { get; set; }


        public ICollection<Contract> Contracts { get; set; }


        public Patient()
        {
            Contracts = new Collection<Contract>();
        }
    }
}
