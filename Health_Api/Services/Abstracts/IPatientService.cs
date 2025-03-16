using Health_Api.Models.Dtos.Patients;

namespace Health_Api.Services.Abstracts;

public interface IPatientService
{
    void Add(PatientAddRequestDto patientAddRequestDto);
    void Delete(int id);
    List<PatientResponseDto>? GetAll();
    PatientResponseDto? GetById(int id);
}
