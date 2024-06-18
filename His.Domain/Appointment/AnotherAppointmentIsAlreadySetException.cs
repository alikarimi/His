namespace His.Domain.Appointment;

public class AnotherAppointmentIsAlreadySetException : Exception
{
    public AnotherAppointmentIsAlreadySetException() : base("Another Appointment Is Already Make")
    {
    }
}