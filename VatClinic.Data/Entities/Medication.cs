using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace VatClinic.Data.Entities
{
    public class Medication : BaseEntity
    {
        public string Name { get; set; }
        public string Doses { get; set; }

        public ICollection<Resolve> Resolves { get; set; }


        public Medication()
        {
            Resolves = new Collection<Resolve>();
        }
    }
}
