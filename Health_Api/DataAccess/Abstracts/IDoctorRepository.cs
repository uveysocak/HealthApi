using Health_Api.Entities;

namespace Health_Api.DataAccess.Abstracts;

public interface IDoctorRepository
{
    void Add(Doctor doctor);
    void Update(Doctor doctor);
    void Delete(int id);
    List<Appointment> GetAll();
    IQueryable<Doctor> GetQueryable();
    Doctor? GetById(int id);
}
