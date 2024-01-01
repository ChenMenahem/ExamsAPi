using Exam_DTO.DTO;

namespace ExamBL
{
    public interface IExamsRepository
    {
        Task<ExamsDTO> GetExamsById(int Idexam);
        Task<List<ExamsDTO>> GetExamsBl();
    }
}