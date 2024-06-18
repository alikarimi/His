using His.Domain.Doctor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using His.Domain.Appointment;

namespace His.ApplicationService.Appointment
{
    public class Prescribe
    {
        private readonly IAppointmentRepository _appointmentRepository;

        public Prescribe(IAppointmentRepository appointmentRepository)
        {
            _appointmentRepository = appointmentRepository;
        }

        public void Execute(Guid appointmentId, string text)
        {
            var appointment = _appointmentRepository.GetById(appointmentId);
            appointment.Prescribe(text);
            _appointmentRepository.Update(appointment);
        }
    }
}
