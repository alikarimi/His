namespace His.Domain.Appointment;

public class ScheduleDoesNotExistException : Exception
{
    public ScheduleDoesNotExistException(Guid id) : base($"Schedule with Id: {id} Does not exists")
    {
    }
}