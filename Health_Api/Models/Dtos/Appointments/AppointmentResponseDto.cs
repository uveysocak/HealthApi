namespace Health_Api.Models.Dtos.Appointments;

public class AppointmentResponseDto
{
    public int Id { get; set; }
    public int DoctorId { get; set; }
    public int PatientId { get; set; }
    public int BirthDay { get; set; }
    public int BirthMonth { get; set; }
    public int BirthYear { get; set; }
    public string? Notes { get; set; }
}
