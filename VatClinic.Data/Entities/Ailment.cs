using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace VatClinic.Data.Entities
{
   public class Ailment : BaseEntity
    {
        public string Name { get; set; }
        public string Symtoms { get; set; }

        public ICollection<Resolve> Resolves { get; set; }
        public ICollection<Contract> Contracts { get; set; }


        public Ailment()
        {
            Resolves = new Collection<Resolve>();
            Contracts = new Collection<Contract>();
        }
    }
}
