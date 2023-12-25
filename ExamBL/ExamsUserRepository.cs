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

