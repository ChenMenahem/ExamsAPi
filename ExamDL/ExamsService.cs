using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamDL.Models;
using Microsoft.EntityFrameworkCore;

namespace ExamDL
{
    public class ExamsService : IExamsService
    {
        ExamsContext _examsContext;

        public ExamsService(ExamsContext examsContext)
        {
            _examsContext = examsContext;
        }

        public async Task<List<Exam>> GetExams()
        {
            try
            {
                List<Exam> result = await _examsContext.Exams
                    .ToListAsync();
                return result;
            }
            catch (Exception ex)
            {
                
                Console.WriteLine($"An error occurred while fetching exams: {ex.Message}");
          
                throw;
            }
        }



        public async Task<Exam> GetExamsById(int Idexam)
        {
            try
            {
                Exam result = await _examsContext.Exams
                    .Where(u => u.IdExam == Idexam)
                    .FirstOrDefaultAsync();
                return result;
            }
            catch (Exception ex)
            {
              
                Console.WriteLine($"An error occurred while fetching person exams: {ex.Message}");
           
                throw;
            }
        }

    }
}

    
 