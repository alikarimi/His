namespace His.Domain.Doctor
{
    public interface IDoctorRepository
    {
        void Add(Doctor doctor);
        Doctor GetById(Guid id);
        void Update(Doctor doctor);
    }
}
