using System;
using System.Collections.Generic;
using System.Text;

namespace VatClinic.Data.Entities
{
    public class Administer : BaseEntity
    {
        
        public Contract Contract  { get; set; }
        public Resolve Resolve { get; set; }
    }
}
