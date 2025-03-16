namespace Health_Api.Entities;

public class Appointment
{
    public int AppointmentId { get; set; }

    public int DoctorId { get; set; }
    public Doctor? Doctor { get; set; }

    public int PatientId { get; set; }
    public Patient? Patient { get; set; }

    public DateTime AppoDate { get; set; }
    public string? Notes { get; set; }
}
