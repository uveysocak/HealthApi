using Health_Api.Models.Dtos.Appointments;

namespace Health_Api.Services.Abstracts;

public interface IAppointmentService
{
    void Add(AppointmentAddRequestDto appointmentAddRequestDto);
    void Delete(int id);
    AppointmentResponseDto? GetById(int id);
    List<AppointmentResponseDto>? GetAll();
}
