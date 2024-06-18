namespace His.Domain.Appointment
{
    public class Prescription : Entity
    {
        public Prescription(Guid appointmentId, string text)
        {
            AppointmentId = appointmentId;
            Text = text;
        }

        public Guid AppointmentId { get; private set; }
        public string Text { get; private set; }
    }
}
