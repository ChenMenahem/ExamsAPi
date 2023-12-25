using ExamDL.Models;

namespace ExamBL
{
    public interface IExamsRepository
    {
        Task<List<Exam>> GetAllPersonExamsBL(int Idexam);
        Task<List<Exam>> GetExamsBl();
    }
}