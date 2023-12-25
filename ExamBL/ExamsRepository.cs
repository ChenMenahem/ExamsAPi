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

    public class ExamsRepository : IExamsRepository
    {
        IExamsService _ExamsDL;
        IMapper _mapper;

        public ExamsRepository(IExamsService examDL, IMapper mapper)
        {
            _ExamsDL = examDL;
            _mapper = mapper;
        }


        public async Task<List<Exam>> GetExamsBl()
        {
            List<Exam> exams = await _ExamsDL.GetExams();
            return exams;
        }
        public async Task<List<Exam>> GetAllPersonExamsBL(int Idexam)
        {
            List<Exam> relief = await _ExamsDL.GetAllPersonExams(Idexam);
            return relief;
        }
    }

}

