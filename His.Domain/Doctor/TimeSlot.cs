using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace His.Domain.Doctor
{
    public class TimeSlot : ValueObject
    {
        public TimeSlot(DateTime day, int fromHour, int toHour)
        {
            Day = day;
            FromHour = fromHour;
            ToHour = toHour;
        }

        public DateTime Day { get; private init; }
        public int FromHour { get; private init; }
        public int ToHour { get; private init; }

        protected override IEnumerable<object> GetAtomicValues()
        {
            yield return Day;
            yield return FromHour;
            yield return ToHour;
        }
    }
}
