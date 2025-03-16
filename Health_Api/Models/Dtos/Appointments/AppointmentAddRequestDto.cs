namespace Health_Api.Models.Dtos.Appointments;

public class AppointmentAddRequestDto
{
    public string? DoctorName { get; set; }
    public string? DoctorBranch { get; set; }
    public int AppDay { get; set; }
    public int AppMonth { get; set; }
    public int AppYear { get; set; }
    public string? Notes { get; set; }
}
