using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace VatClinic.Data.Entities
{
    public class Patient : BaseEntity
    {
        public int Name { get; set; }
        public string ClinicNo { get; set; }


        public ICollection<Contract> Contracts { get; set; }


        public Patient()
        {
            Contracts = new Collection<Contract>();
        }
    }
}
