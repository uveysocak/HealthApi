using Health_Api.DataAccess.Abstracts;
using Health_Api.Entities;
using Health_Api.Models.Dtos.Appointments;
using Health_Api.Services.Abstracts;

namespace Health_Api.Services.Concretes;
public class AppointmentService : IAppointmentService
{
    private IAppointmentRepository _appointmentRepository;

    public AppointmentService(IAppointmentRepository appointmentRepository)
    {
        _appointmentRepository = appointmentRepository;
    }

    public void Add(AppointmentAddRequestDto appointmentAddRequestDto)
    {
        Appointment appointment = ConvertToAppointment(appointmentAddRequestDto);
        _appointmentRepository.Add(appointment);
    }

    private Appointment ConvertToAppointment(AppointmentAddRequestDto dto)
    {
        return new Appointment()
        {
            AppoDate = new DateTime(dto.AppYear, dto.AppMonth, dto.AppDay)
        };
    }

    public void Delete(int id)
    {
        Appointment appointment = _appointmentRepository.GetById(id);
        _appointmentRepository.Delete(appointment.AppointmentId);
    }

    public List<AppointmentResponseDto>? GetAll()
    {
        List<Appointment> appointments = _appointmentRepository.GetAll();
        List<AppointmentResponseDto> responses = ConvertToResponseDtoList(appointments);
        return responses;
    }

    private List<AppointmentResponseDto> ConvertToResponseDtoList(List<Appointment> appointments)
    {
        return appointments.Select(x => ConvertToResponseDto(x)).ToList();
    }

    private AppointmentResponseDto ConvertToResponseDto(Appointment appointment)
    {
        return new AppointmentResponseDto()
        {
            Id = appointment.AppointmentId,
            DoctorId = appointment.DoctorId,
            Notes = appointment.Notes
        };
    }
    public AppointmentResponseDto? GetById(int id)
    {
        Appointment appointment = _appointmentRepository.GetById(id);
        AppointmentResponseDto response = ConvertToResponseDto(appointment);
        return response;
    }
}
