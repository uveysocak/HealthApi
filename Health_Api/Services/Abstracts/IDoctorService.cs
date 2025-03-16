using Health_Api.Models.Dtos.Doctors;

namespace Health_Api.Services.Abstracts;

public interface IDoctorService
{
    void Add(DoctorAddRequestDto doctorAddRequestDto);
    void Delete(int id);
    List<DoctorResponseDto>? GetAllAppointmentById(int id);
    DoctorResponseDto GetById(int id);
}
