namespace Health_Api.Models.Dtos.Patients;

public class PatientAddRequestDto
{
    public string? Name { get; set; }
    public string? SurName { get; set; }
    public int BirthDay { get; set; }
    public int BirthMonth { get; set; }
    public int BirthYear { get; set; }

}
