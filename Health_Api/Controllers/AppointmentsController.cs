using Health_Api.DataAccess.Context;
using Microsoft.AspNetCore.Mvc;

namespace Health_Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AppointmentsController : ControllerBase
{
    private readonly BaseDbContext _ctx;

    public AppointmentsController(BaseDbContext ctx)
    {
        _ctx = ctx;
    }

    //public IActionResult AddAppointment(Doctor doctor, Patient patient)
    //{
    //    _ctx.Appointments.Add(doctor, patient);
    //    _ctx.SaveChanges();
    //    return Ok("Başarıyla eklendi");
    //}
}
