using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace His.Domain.Patient
{
    public class Patient : Entity
    {
        public string Name { get; set; }
        public string NationalCode { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}
