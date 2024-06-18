using His.Domain.Doctor;

namespace His.Domain.Appointment
{
    public class CancelAppointmentDomainService
    {
        private readonly IAppointmentRepository _appointmentRepository;
        private readonly IDoctorRepository _doctorRepository;

        public CancelAppointmentDomainService(IAppointmentRepository appointmentRepository, IDoctorRepository doctorRepository)
        {
            _appointmentRepository = appointmentRepository;
            _doctorRepository = doctorRepository;
        }

        public void Cancel(Guid appointmentId)
        {
            var appointment = _appointmentRepository.GetById(appointmentId);
            var doctor = _doctorRepository.GetById(appointment.DoctorId);
            var schedule = doctor.Schedules.FirstOrDefault(s => s.Id == appointment.ScheduleId);
            if (schedule == null)
                throw new ScheduleDoesNotExistException(appointment.ScheduleId);
            var date = schedule.TimeSlot.Day.AddHours(schedule.TimeSlot.FromHour);
            if (DateTime.Now - date < Appointment.AcceptableTimeSpanToCancel)
                throw new CanNotCancelAppointmentException();
            _appointmentRepository.Update(appointment);
        }
    }
}
