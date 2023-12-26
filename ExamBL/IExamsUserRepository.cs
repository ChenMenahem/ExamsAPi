using ExamDL.Models;

namespace ExamBL
{
    internal interface IExamsUserRepository
    {
        Task<bool> Add(ExamsUser examsUser);
        Task<List<ExamsUser>> GetAllExamsForUserBL(int userId);
    }
}