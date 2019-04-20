using System;
using System.Collections.Generic;
using System.Text;

namespace VatClinic.Data.Repository.Interface
{
    public interface IPatientRepo <T>
    {
        IList <T> SelectAll();
    }
}
