using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace VatClinic.Data.Entities
{
    public class Medication : BaseEntity
    {
       

        [Required]
        [StringLength(20)]
        public string Name { get; set; }

        [Required]
        public string Doses { get; set; }

       


        public ICollection<Resolve> Resolves { get; set; }


        public Medication()
        {
            Resolves = new Collection<Resolve>();
        }
    }
}
