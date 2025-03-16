using Health_Api.DataAccess.Context;
using Health_Api.Entities;
using Health_Api.Services.Abstracts;
using Microsoft.AspNetCore.Mvc;

namespace Health_Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class DoctorsController : ControllerBase
{
    private readonly BaseDbContext _context;
    private readonly IDoctorService _doctorService;
    public DoctorsController(BaseDbContext context, IDoctorService doctorService)
    {
        _context = context;
        _doctorService = doctorService;
    }
    [HttpPost]
    public IActionResult AddDoctor(Doctor doctor)
    {
        _context.Doctors.Add(doctor);
        _context.SaveChanges();
        return Ok("Başarıyla eklendi");
    }
    [HttpGet]
    public IActionResult DoctorList()
    {
        var result = _doctorService.GetAllAppointmentById(1);
        //var result = _context.Doctors.ToList();
        return Ok(result);
    }
    [HttpDelete]
    public IActionResult DeleteDoctor(int id)
    {
        var value = _context.Doctors.Find(id);
        _context.Doctors.Remove(value);
        _context.SaveChanges();
        return Ok("Başarıyla silindi");
    }
    [HttpGet("GetById")]
    public IActionResult GetById(int id)
    {
        var value = _context.Doctors.Find(id);
        return Ok(value);
    }
    [HttpPut]
    public IActionResult UpdateDoctor(Doctor doctor)
    {
        _context.Doctors.Update(doctor);
        _context.SaveChanges();
        return Ok("Başarıyla güncellendi");
    }
}
