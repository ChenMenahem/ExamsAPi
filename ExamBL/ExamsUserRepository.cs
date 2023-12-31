﻿using System;
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
    public class ExamsUserRepository : IExamsUserRepository
    {
        IExamsUserService _ExamsUsersDL;
        IMapper _mapper;

        public ExamsUserRepository(IExamsUserService examUserDL , IMapper mapper)
        {
            _ExamsUsersDL = examUserDL;
            _mapper = mapper;
        }

        public async Task<List<ExamsUserDTO>> GetAllExamsBL()
        {
            try
            {
                List<ExamsUser> ExamsForUser = await _ExamsUsersDL.GetAllExams();
                List<ExamsUserDTO> exuDTO = _mapper.Map<List<ExamsUserDTO>>(ExamsForUser);
                return exuDTO;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in GetAllExamsForUserBL: {ex.Message}");
                return null;
            }

        }

        public async Task<ExamsUserDTO> GetExamsForUserBL(int userId)
        {
            try
            {
                ExamsUser ExamsForUser = await _ExamsUsersDL.GetAllExamsForUser(userId);
                ExamsUserDTO exuDTO = _mapper.Map<ExamsUserDTO>(ExamsForUser);
                return exuDTO;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in GetAllExamsForUserBL: {ex.Message}");
                return null;
            }
        }

        public async Task<ExamsUserDTO> Add(ExamsUserDTO examsUser)
        {
            try
            {
                ExamsUser ex = _mapper.Map<ExamsUser>(examsUser);
                ExamsUser isAdd = await _ExamsUsersDL.Add(ex);
                ExamsUserDTO exu = _mapper.Map<ExamsUserDTO>(isAdd);
                return exu;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in Add: {ex.Message}");
                return null;
            }
        }





    }
}

