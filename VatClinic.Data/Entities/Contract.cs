using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace VatClinic.Data.Entities
{
   public  class Contract
    {
        [ForeignKey("ID")]
        public long PatientId { get; set; }

        [ForeignKey("ID")]
        public long AilmentId { get; set; }

        public Patient Patient { get; set; }
        public Ailment Ailment { get; set; }
    }
}
