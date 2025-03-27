using Health_Api.DataAccess.Abstracts;
using Health_Api.DataAccess.Context;
using Health_Api.Entities;

namespace Health_Api.DataAccess.Concretes;

public class AppointmentRepository : GenericRepository<Appointment>, IAppointmentRepository
{
    private BaseDbContext _context;

    public AppointmentRepository(BaseDbContext context) : base(context)
    {
    }
    public List<Appointment> GetAll()
    {
        List<Appointment> appointments = _context.Appointments.ToList();
        return appointments;
    }

    public Appointment GetById(int id)
    {
        return _context.Appointments.Find(id);
    }

    public IQueryable<Appointment> GetQueryable()
    {
        return _context.Appointments.AsQueryable();
    }

    public void Update(Appointment appointment)
    {
        _context.Appointments.Update(appointment);
        _context.SaveChanges();
    }
}
