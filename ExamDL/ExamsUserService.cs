using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ExamDL.Models;

namespace ExamDL
{
    public class ExamsUserService : IExamsUserService
    {
        ExamsContext _ExamsContext = new ExamsContext();

        public async Task<List<ExamsUser>> GetAllExams()
        {
            List<ExamsUser> result = await _ExamsContext.ExamsUsers
                     .ToListAsync();
            return result;
        }


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
