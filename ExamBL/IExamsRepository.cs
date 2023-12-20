namespace ExamBL
{
    public interface IExamsRepository
    {
        Task<List<Exam>> GetAllPersonExamsBL(global::System.Int32 Idexam);
        Task<List<Exam>> GetExamsBl();
    }
}