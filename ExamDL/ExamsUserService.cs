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
        ExamsContext _examsContext;
        public ExamsUserService(ExamsContext examsContext)
        {
            _examsContext = examsContext;
        }


        public async Task<List<ExamsUser>> GetAllExams()
        {
            List<ExamsUser> result = await _examsContext.ExamsUsers
                     .ToListAsync();
            return result;
        }


        public async Task<ExamsUser> GetAllExamsForUser(int userId)
        {
            try
            {
                ExamsUser result = await _examsContext.ExamsUsers
                    .Where(u => u.IdUser == userId)
                    .FirstOrDefaultAsync();

                return result;
            }
            catch (Exception ex)
            {

                Console.WriteLine($"An error occurred while fetching exams for user: {ex.Message}");

                throw;
            }
        }

        public async Task<ExamsUser> Add(ExamsUser examsUser)
        {
            try
            {
                 _examsContext.ExamsUsers.AddAsync(examsUser);
              await  _examsContext.SaveChangesAsync();
                ExamsUser e = await _examsContext.ExamsUsers
                    .OrderByDescending(e => e.IdUser)
                    .FirstOrDefaultAsync();
                return e;
            }
            catch (Exception ex)
            {

                Console.WriteLine($"An error occurred while adding an exams user: {ex.Message}");

                throw;
            }
        }
        public async Task<ExamsUser> Update(ExamsUser examUserToUpdate,int id)
        {
            try
            {
                ExamsUser updateOffice = _examsContext.ExamsUsers.FirstOrDefault(x => x.IdExamUser == id);

                if (updateOffice != null)
                {

                    updateOffice.Class = examUserToUpdate.Class;
                    updateOffice.Grade = examUserToUpdate.Grade;
                    updateOffice.ExamsStatus = examUserToUpdate.ExamsStatus;
                   

                    _examsContext.Update(updateOffice);

                    await _examsContext.SaveChangesAsync();
                }

                return examUserToUpdate;
            }
            catch (Exception ex)
            {

                Console.WriteLine($"An error occurred during update: {ex.Message}");

                throw;
            }
        }


    }
}
