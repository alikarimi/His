using His.Domain.Doctor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using His.Domain.Appointment;

namespace His.ApplicationService.Appointment
{
    public class MakeAppointment
    {
        private readonly IAppointmentRepository _appointmentRepository;

        public MakeAppointment(IAppointmentRepository appointmentRepository)
        {
            _appointmentRepository = appointmentRepository;
        }

        public void Execute(Guid patientId, Guid doctorId, Guid scheduleId)
        {
            var makeAppointmentDomainService = new MakeAppointmentDomainService(_appointmentRepository);

            try
            {
                makeAppointmentDomainService.Make(patientId, doctorId, scheduleId);
            }
            catch (AnotherAppointmentIsAlreadySetException exception)
            {
                //log
                throw;
            }

        }
    }
}
