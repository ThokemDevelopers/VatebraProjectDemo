using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VatClinic.Domain.ApiResponseModel;
using VatClinic.Domain.Services.Interface;

namespace VatClinic.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientController : ControllerBase 
    {
        private readonly IPatientService<PatientResponse> _PatientService;

        public PatientController(IPatientService<PatientResponse> PatientService)
        {
            _PatientService = PatientService;
        }


        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_PatientService.GetAll());
        }
    }
}
