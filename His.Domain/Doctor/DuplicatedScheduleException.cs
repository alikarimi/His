using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace His.Domain.Doctor
{
    public class DuplicatedScheduleException : Exception
    {
        public DuplicatedScheduleException() : base("Duplicated Schedule Occurred")
        {
        }
    }
}
