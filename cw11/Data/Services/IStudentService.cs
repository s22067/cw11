using cw11.Models;

namespace cw11.Repository
{
    public interface IStudentService
    {
        Student GetStudent(int ID);
        void DeleteStudent(int ID);
    }
}
