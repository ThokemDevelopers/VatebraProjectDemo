using System;
using System.Collections.Generic;
using System.Text;

namespace VatClinic.Data.Entities
{
    class Administer
    {
        public int Id { get; set; }
        public Contract Contract  { get; set; }
        public Resolve Resolve { get; set; }
    }
}
