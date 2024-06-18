using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace His.Domain.Doctor
{
    public class Doctor : Entity
    {
        public Doctor()
        {
            Schedules = new List<Schedule>();
        }

        public Doctor(string name, string expertise) : this()
        {
            Name = name;
            Expertise = expertise;
        }

        public string Name { get; private set; }
        public string Expertise { get; private set; }

        public List<Schedule> Schedules { get; private set; }

        public void AddSchedule(Schedule schedule)
        {
            if (Schedules.Any(s => s.TimeSlot.Equals(schedule.TimeSlot)))
                throw new DuplicatedScheduleException();
            Schedules.Add(schedule);
        }
    }
}
