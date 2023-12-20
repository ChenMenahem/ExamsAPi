namespace ExamBL
{
    interface IExamsUserRepository
    {
        global::System.Boolean Add(ExamsUser examsUser);
        List<ExamsUser> GetAllExamsForUserBL(global::System.Int32 userId);
    }
}