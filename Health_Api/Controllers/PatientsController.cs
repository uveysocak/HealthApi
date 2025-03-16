using Health_Api.Models.Dtos.Patients;
using Health_Api.Services.Abstracts;
using Microsoft.AspNetCore.Mvc;

namespace Health_Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class PatientsController : ControllerBase
{
    private IPatientService patientService;

    public PatientsController(IPatientService patientService)
    {
        this.patientService = patientService;
    }
    [HttpPost]
    public IActionResult AddPatient(PatientAddRequestDto dto)
    {
        patientService.Add(dto);
        return Ok("Hasta başarıyla eklendi");
    }

    [HttpGet("getall")]
    public IActionResult GetAll()
    {
        return Ok(patientService.GetAll());
    }
}
