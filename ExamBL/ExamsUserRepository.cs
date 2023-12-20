using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamBL
{
    class ExamsUserRepository : IExamsUserRepository
    {
        IExams_UsersService _ExamsUsersDL;

        public Exams_UsersRepository(IExams_UsersService examUserDL)
        {
            _ExamsUsersDL = examUserDL;
        }

        public Exams_UsersRepository()
        {
            _ExamsUsersDL = new Exams_UsersService();
        }


        public List<ExamsUser> GetAllExamsForUserBL(int userId)
        {
            List<ExamsUser> ExamsForUser = _ExamsUsersDL.GetAllExamsForUser(userId);
            return ExamsForUser;
        }
        public bool Add(ExamsUser examsUser)
        {
            bool isAdd = _ExamsUsersDL.Add(examsUser);
            return isAdd;
        }
    }
}

