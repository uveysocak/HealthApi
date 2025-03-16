using Health_Api.DataAccess.Abstracts;
using Health_Api.Entities;
using Health_Api.Models.Dtos.Doctors;
using Health_Api.Services.Abstracts;
using Microsoft.EntityFrameworkCore;

namespace Health_Api.Services.Concretes;

public class DoctorService : IDoctorService
{
    private IDoctorRepository _doctorRepository;
    private readonly IAppointmentRepository _appointmentRepository;
    public DoctorService(IDoctorRepository doctorRepository, IAppointmentRepository appointmentRepository)
    {
        _doctorRepository = doctorRepository;
        _appointmentRepository = appointmentRepository;
    }
    public DoctorResponseDto GetById(int id)
    {
        throw new NotImplementedException();
    }
    public List<DoctorResponseDto>? GetAllAppointmentById(int id)
    {
        var appointments = _appointmentRepository.GetQueryable()
            .Include(x => x.Doctor)
            .Include(x => x.Patient)
            .ToList();

        return appointments.Select(x => new DoctorResponseDto
        {
            Id = x.DoctorId,
            Name = x.Doctor.Name,
            Branch = x.Doctor.Branch,
            SurName = x.Doctor.SurName,

        }).ToList();

    }
    public void Add(DoctorAddRequestDto doctorAddRequestDto)
    {
        Doctor doctor = ConvertToDoctor(doctorAddRequestDto);
        _doctorRepository.Add(doctor);
    }
    public void Delete(int id)
    {
        Doctor doctor = _doctorRepository.GetById(id);
        _doctorRepository.Delete(doctor.DoctorId);
    }
    private Doctor ConvertToDoctor(DoctorAddRequestDto dto)
    {
        return new Doctor
        {
            Branch = dto.Branch,
            Name = dto.Name,
            SurName = dto.SurName
        };
    }
    private DoctorResponseDto ConvertToResponseDto(Doctor doctor)
    {
        return new DoctorResponseDto()
        {
            Id = doctor.DoctorId,
            Branch = doctor.Branch,
            Name = doctor.Name,
            SurName = doctor.SurName
        };
    }
    private List<DoctorResponseDto> ConvertToResponseDtoList(List<Doctor> doctors)
    {
        return doctors.Select(x => ConvertToResponseDto(x)).ToList();
    }

}
