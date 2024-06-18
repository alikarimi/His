using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace His.Domain.Doctor
{
    public class Schedule : Entity
    {
        public static int WorkingDayStartHour = 8;
        public static int WorkingDayEndHour = 16;

        public Schedule(TimeSlot timeSlot, Guid doctorId)
        {
            TimeSlot = timeSlot;
            DoctorId = doctorId;
        }

        public TimeSlot TimeSlot { get; private set; }
        public Guid DoctorId { get; private set; }
    }
}
