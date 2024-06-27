using Microsoft.EntityFrameworkCore;
using His.Domain.Appointment;
using His.Domain.Doctor;
using His.Domain.Patient;

namespace His.DataAccess.Context
{
    public class HisContext : DbContext
    {
        public HisContext()
        {
        }

        public HisContext(DbContextOptions<HisContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Appointment> Appointments { get; set; }
        public virtual DbSet<Doctor> Doctors { get; set; }
        public virtual DbSet<Patient> Patients { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Schedule>(s =>
            {
                s.ComplexProperty(e => e.TimeSlot);
            });
        }
    }
}