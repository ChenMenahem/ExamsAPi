﻿using ExamDL.Models;
namespace ExamDL
{
    public interface IExamsService
    {
        Task<List<Exam>> GetAllPersonExams(global::System.Int32 Idexam);
        Task<List<Exam>> GetExams();
    }
}