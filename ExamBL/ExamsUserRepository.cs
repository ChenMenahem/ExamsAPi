using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Exam_DTO.DTO;
using ExamDL;
using ExamDL.Models;


namespace ExamBL
{
    class ExamsUserRepository : IExamsUserRepository
    {
        IExamsUserService _ExamsUsersDL;
        IMapper _mapper;

        public ExamsUserRepository(IExamsUserService examUserDL)
        {
            _ExamsUsersDL = examUserDL;
            IMapper _mapper;
        }

        public async Task<List<ExamsUser>> GetAllExamsForUserBL(int userId)
        {
            try
            {
                List<ExamsUser> ExamsForUser = await _ExamsUsersDL.GetAllExamsForUser(userId);
                return ExamsForUser;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in GetAllExamsForUserBL: {ex.Message}");
                return null;
            }
        }

        public async Task<bool> Add(ExamsUser examsUser)
        {
            try
            {
                bool isAdd = await _ExamsUsersDL.Add(examsUser);
                return isAdd;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in Add: {ex.Message}");
                return false;
            }
        }





    }
}

