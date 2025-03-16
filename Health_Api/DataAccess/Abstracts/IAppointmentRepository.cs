using Health_Api.Entities;

namespace Health_Api.DataAccess.Abstracts;

public interface IAppointmentRepository
{
    void Add(Appointment appointment);
    void Update(Appointment appointment);
    void Delete(int id);
    List<Appointment> GetAll();
    IQueryable<Appointment> GetQueryable();
    Appointment? GetById(int id);
}
