using Health_Api.DataAccess.Abstracts;
using Health_Api.DataAccess.Context;
using Health_Api.Entities;

namespace Health_Api.DataAccess.Concretes;

public class PatientRepository : GenericRepository<Patient>, IPatientRepository
{
    private readonly PatientRepository _ctx;

    public PatientRepository(BaseDbContext context) : base(context)
    {
    }

    public Patient? GetByNameS(string nS)
    {
        throw new NotImplementedException();
    }
}
