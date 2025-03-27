using Health_Api.DataAccess.Abstracts;
using Health_Api.DataAccess.Context;
using Health_Api.Entities;

namespace Health_Api.DataAccess.Concretes;

public class DoctorRepository : GenericRepository<Doctor>, IDoctorRepository
{
    private BaseDbContext context;

    public DoctorRepository(BaseDbContext context) : base(context)
    {
    }

    public List<Appointment> GetAll()
    {
        List<Appointment> appointments = context.Appointments.ToList();
        return appointments;
    }

    public IQueryable<Doctor> GetQueryable()
    {
        return context.Doctors.AsQueryable();
    }


    List<Doctor> IGenericRepository<Doctor>.GetAll()
    {
        throw new NotImplementedException();
    }
}
