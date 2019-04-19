using System;
using System.Collections.Generic;
using System.Text;

namespace VatClinic.Data.Entities
{
    public class Resolve
    {
        public int AilmentId { get; set; }
        public int MedicationId { get; set; }

        public Ailment Ailment { get; set; }
        public Medication Medication { get; set; }
    }
}
