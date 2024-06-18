using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace His.Domain.Appointment
{
    public class Appointment : Entity
    {
        public static readonly TimeSpan AcceptableTimeSpanToCancel = TimeSpan.FromMinutes(60);

        public Appointment()
        {
            Prescriptions = new List<Prescription>();
        }

        public Appointment(Guid patientId, Guid doctorId, Guid scheduleId) : this()
        {
            PatientId = patientId;
            DoctorId = doctorId;
            ScheduleId = scheduleId;
            AppointmentState = AppointmentState.Made;
        }

        public Guid PatientId { get; private set; }
        public Guid DoctorId { get; private set; }
        public Guid ScheduleId { get; private set; }
        public AppointmentState AppointmentState { get; private set; }
        public List<Prescription> Prescriptions { get; private set; }

        public void Prescribe(string text)
        {
            Prescriptions.Add(new Prescription(Id, text));
        }
    }
}
