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


        public async Task <List<ExamsUser>> GetAllExamsForUser(int userId)
        {
            try
            {
                List<ExamsUser> result = await _ExamsContext.ExamsUsers
                    .Where(u => u.IdUser == userId)
                    .ToListAsync();

                return result;
            }
            catch (Exception ex)
            {

                Console.WriteLine($"An error occurred while fetching exams for user: {ex.Message}");

                throw;
            }
        }

        public async Task<bool> Add(ExamsUser examsUser)
        {
            try
            {
                _ExamsContext.ExamsUsers.Add(examsUser);
                await _ExamsContext.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {

                Console.WriteLine($"An error occurred while adding an exams user: {ex.Message}");

                throw;
            }
        }


    }
}
