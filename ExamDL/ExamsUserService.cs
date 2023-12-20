using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamDL
{
    internal class ExamsUserService : IExamsUserService
    {
        ExamsContext _ExamsContext = new ExamsContext();


        public List<ExamsUser> GetAllExamsForUser(int userId)
        {
            List<ExamsUser> result = _ExamsContext.ExamsUsers
                 .Where(u => u.IdUser == userId)
                 .ToList();
            return result;
        }
        public bool Add(ExamsUser examsUser)

        {
            _ExamsContext.ExamsUsers.Add(examsUser);
            _ExamsContext.SaveChanges();
            return true;
        }

    }
}
