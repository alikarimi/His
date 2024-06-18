namespace His.Domain.Appointment
{
    public interface IAppointmentRepository
    {
        void Add(Appointment appointment);
        void Delete(Appointment appointment);
        Appointment GetById(Guid id);
        bool DoesExistByScheduleId(Guid scheduleId);
        void Update(Appointment appointment);
    }
}
