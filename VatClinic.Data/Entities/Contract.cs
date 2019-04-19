using System;
using System.Collections.Generic;
using System.Text;

namespace VatClinic.Data.Entities
{
   public  class Contract
    {
        public int PatientId { get; set; }
        public int AilmentId { get; set; }

        public Patient Patient { get; set; }
        public Ailment Ailment { get; set; }
    }
}
