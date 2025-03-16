using Health_Api.DataAccess.Abstracts;
using Health_Api.DataAccess.Context;
using Health_Api.Entities;

namespace Health_Api.DataAccess.Concretes;

public class DoctorRepository : IDoctorRepository
{
    private BaseDbContext context;

    public DoctorRepository(BaseDbContext context)
    {
        this.context = context;
    }

    public void Add(Doctor doctor)
    {
        context.Doctors.Add(doctor);
        context.SaveChanges();
    }

    public void Delete(int id)
    {
        context.Remove(id);
        context.SaveChanges();
    }

    public List<Appointment> GetAll()
    {
        List<Appointment> appointments = context.Appointments.ToList();
        return appointments;
    }

    public Doctor GetById(int id)
    {
        return context.Doctors.Find(id);
    }

    public IQueryable<Doctor> GetQueryable()
    {
        return context.Doctors.AsQueryable();
    }

    public void Update(Doctor doctor)
    {
        context.Doctors.Update(doctor);
        context.SaveChanges();
    }
}
