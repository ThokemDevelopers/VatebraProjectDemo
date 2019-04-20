using System;
using System.Collections.Generic;
using System.Text;

namespace VatClinic.Domain.Services.Interface
{
    public interface IPatientService <T>
    {
        IList<T> GetAll();
    }
}
