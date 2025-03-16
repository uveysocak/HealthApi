namespace Health_Api.Entities;

public class Doctor
{
    public int DoctorId { get; set; }

    public List<Appointment>? Appointments { get; set; }
    public string? Name { get; set; }
    public string? SurName { get; set; }
    public string? Branch { get; set; }
}
