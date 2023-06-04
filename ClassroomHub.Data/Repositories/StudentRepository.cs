using ClassroomHub.Core.Entities;
using ClassroomHub.Core.Contracts.Repositories;


namespace ClassroomHub.Data.Repositories
{
    public class StudentRepository : BaseRepository<Student>, IStudentRepository
    {
        public StudentRepository(Context context) : base(context)
        {
        }
    }
}
