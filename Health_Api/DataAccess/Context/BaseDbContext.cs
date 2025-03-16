using Health_Api.Entities;
using Microsoft.EntityFrameworkCore;

namespace Health_Api.DataAccess.Context;

public class BaseDbContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=CHABORZ-UVAYS\\SQLEXPRESS;initial catalog=HospitalDb;integrated security=true;TrustServerCertificate=true");
    }
    public DbSet<Doctor> Doctors { get; set; }
    public DbSet<Patient> Patients { get; set; }
    public DbSet<Appointment> Appointments { get; set; }
}
