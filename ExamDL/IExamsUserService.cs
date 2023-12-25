using ExamDL.Models;
namespace ExamDL
{
    public interface IExamsUserService
    {
        global::System.Boolean Add(ExamsUser examsUser);
        List<ExamsUser> GetAllExamsForUser(global::System.Int32 userId);
    }
}