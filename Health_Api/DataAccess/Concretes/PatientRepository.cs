using Health_Api.DataAccess.Abstracts;
using Health_Api.DataAccess.Context;
using Health_Api.Entities;

namespace Health_Api.DataAccess.Concretes;

public class PatientRepository : IPatientRepository
{
    private BaseDbContext ctx;

    public PatientRepository(BaseDbContext context)
    {
        this.ctx = context;
    }

    public void Add(Patient patient)
    {
        ctx.Patients.Add(patient);
        ctx.SaveChanges();
    }

    public void Delete(Patient patient)
    {
        ctx.Patients.Remove(patient);
        ctx.SaveChanges();
    }

    public List<Patient> GetAll()
    {
        List<Patient> patients = ctx.Patients.ToList();
        return patients;
    }

    public Patient? GetById(int id)
    {
        return ctx.Patients.Find(id);
    }

    public Patient? GetByNameS(string nS)
    {
        Patient? patient = ctx.Patients.FirstOrDefault(x => x.Name + x.Surname == nS);
        return patient;
    }

    public void Update(Patient patient)
    {
        ctx.Patients.Update(patient);
        ctx.SaveChanges();
    }
}
