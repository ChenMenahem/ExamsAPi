using ExamDL.Models;
namespace ExamDL
{
    public interface IExamsService
    {
        Task<Exam> GetExamsById(int Idexam);
        Task<List<Exam>> GetExams();
    }
}