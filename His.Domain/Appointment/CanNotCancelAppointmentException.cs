namespace His.Domain.Appointment;

public class CanNotCancelAppointmentException : Exception
{
    public CanNotCancelAppointmentException() : base("Appointment Can not be canceled")
    {
    }
}