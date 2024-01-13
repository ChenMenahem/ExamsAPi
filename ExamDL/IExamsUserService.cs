using ExamDL.Models;

namespace ExamDL
{
    public interface IExamsUserService
    {
        Task<ExamsUser> Add(ExamsUser examsUser);
        Task<List<ExamsUser>> GetAllExams();
        Task<ExamsUser> GetAllExamsForUser(int userId);
        Task<ExamsUser> Update(ExamsUser examUserToUpdate, int id);


    }
}