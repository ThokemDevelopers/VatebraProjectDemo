using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace VatClinic.Data.Entities
{
    public class Resolve
    {
       
        public long AilmentId { get; set; }

        
        public long MedicationId { get; set; }

        public Ailment Ailment { get; set; }
        public Medication Medication { get; set; }
    }
}
