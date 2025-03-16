using Health_Api.Entities;

namespace Health_Api.DataAccess.Abstracts;

public interface IPatientRepository
{
    void Add(Patient patient);
    void Update(Patient patient);
    void Delete(Patient patient);
    List<Patient> GetAll();
    Patient? GetById(int id);
    Patient? GetByNameS(string nS);
}
