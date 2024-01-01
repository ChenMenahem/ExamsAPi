using Exam_DTO.DTO;

namespace ExamBL
{
    public interface IExamsUserRepository
    {
        Task<ExamsUserDTO> Add(ExamsUserDTO examsUser);
        Task<List<ExamsUserDTO>> GetAllExamsBL();
        Task<ExamsUserDTO> GetExamsForUserBL(int userId);
    }
}