using His.Domain.Doctor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using His.Domain.Appointment;

namespace His.ApplicationService.Appointment
{
    public class CancelAppointment
    {
        private readonly IAppointmentRepository _appointmentRepository;
        private readonly IDoctorRepository _doctorRepository;

        public CancelAppointment(IAppointmentRepository appointmentRepository, IDoctorRepository doctorRepository)
        {
            _appointmentRepository = appointmentRepository;
            _doctorRepository = doctorRepository;
        }

        public void Execute(Guid patientId, Guid scheduleId)
        {
            var cancelAppointmentDomainService = new CancelAppointmentDomainService(_appointmentRepository, _doctorRepository);

            try
            {
                cancelAppointmentDomainService.Cancel(patientId);
            }
            catch (AnotherAppointmentIsAlreadySetException exception)
            {
                //log
                throw;
            }

        }
    }
}
