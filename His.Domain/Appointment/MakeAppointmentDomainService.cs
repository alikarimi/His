namespace His.Domain.Appointment
{
    public class MakeAppointmentDomainService
    {
        private readonly IAppointmentRepository _appointmentRepository;

        public MakeAppointmentDomainService(IAppointmentRepository appointmentRepository)
        {
            _appointmentRepository = appointmentRepository;
        }

        public void Make(Guid patientId, Guid doctorId, Guid scheduleId)
        {
            var doesExist = _appointmentRepository.DoesExistByScheduleId(scheduleId);
            if (doesExist)
                throw new AnotherAppointmentIsAlreadySetException();
            _appointmentRepository.Add(new Appointment(patientId, doctorId, scheduleId));
        }
    }
}
