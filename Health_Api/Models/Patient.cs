namespace Health_Api.Entities;

public class Patient
{
    public int Id { get; set; }
    public List<Appointment>? Appointments { get; set; }
    public string? Name { get; set; }
    public string? Surname { get; set; }
    public DateTime DateofBirth { get; set; }
}
