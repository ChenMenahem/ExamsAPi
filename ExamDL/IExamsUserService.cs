using ExamDL.Models;
namespace ExamDL
{
    public interface IExamsUserService
    {
        Task<bool> Add(ExamsUser examsUser);
        Task<List<ExamsUser>> GetAllExamsForUser(int userId);
    }
}