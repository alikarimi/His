using His.Domain.Doctor;

namespace His.ApplicationService.Doctor
{
    public class ArrangeSchedule
    {
        private readonly IDoctorRepository _doctorRepository;

        public ArrangeSchedule(IDoctorRepository doctorRepository)
        {
            _doctorRepository = doctorRepository;
        }

        public void Execute(Guid doctorId, DateTime day)
        {
            var doctor = _doctorRepository.GetById(doctorId);

            try
            {
                for (var i = Schedule.WorkingDayStartHour; i < Schedule.WorkingDayEndHour; i++)
                    doctor.AddSchedule(new Schedule(new TimeSlot(day, i, i + 1), doctorId));
            }
            catch (DuplicatedScheduleException exception)
            {
                //log
                throw;
            }

        }
    }
}
