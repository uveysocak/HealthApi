using Health_Api.DataAccess.Abstracts;
using Health_Api.Entities;
using Health_Api.Models.Dtos.Patients;
using Health_Api.Services.Abstracts;

namespace Health_Api.Services.Concretes;

public class PatientService : IPatientService
{
    private IPatientRepository patientRepository;

    public PatientService(IPatientRepository patientRepository)
    {
        this.patientRepository = patientRepository;
    }

    public void Add(PatientAddRequestDto patientAddRequestDto)
    {
        Patient patient = ConvertToPatient(patientAddRequestDto);
        patientRepository.Add(patient);
    }

    private Patient ConvertToPatient(PatientAddRequestDto dto)
    {
        return new Patient
        {
            Name = dto.Name,
            Surname = dto.SurName,
            DateofBirth = new DateTime(dto.BirthYear, dto.BirthMonth, dto.BirthDay)
        };
    }

    public void Delete(int id)
    {
        Patient patient = patientRepository.GetById(id);
        patientRepository.Delete(patient);
    }

    public List<PatientResponseDto>? GetAll()
    {
        List<Patient> patients = patientRepository.GetAll();
        List<PatientResponseDto> responses = ConvertToResponseDtoList(patients);
        return responses;
    }

    private List<PatientResponseDto> ConvertToResponseDtoList(List<Patient> patients)
    {
        return patients.Select(x => ConvertToResponseDto(x)).ToList();
    }

    private PatientResponseDto ConvertToResponseDto(Patient patient)
    {
        return new PatientResponseDto
        {
            Id = patient.Id,
            Name = patient.Name,
            SurName = patient.Surname,
            BirthDay = patient.DateofBirth.Day,
            BirthMonth = patient.DateofBirth.Month,
            BirthYear = patient.DateofBirth.Year
        };
    }

    public PatientResponseDto? GetById(int id)
    {
        Patient patient = patientRepository.GetById(id);
        PatientResponseDto response = ConvertToResponseDto(patient);
        return response;
    }
}
