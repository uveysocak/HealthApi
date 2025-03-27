using Health_Api.Entities;

namespace Health_Api.DataAccess.Abstracts;

public interface IPatientRepository
{
    Patient? GetByNameS(string nS);
}
