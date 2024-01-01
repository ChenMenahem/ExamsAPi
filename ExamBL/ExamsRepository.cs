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



        public async Task<List<ExamsDTO>> GetExamsBl()
        {
            try
            {
                List<Exam> exams = await _ExamsDL.GetExams();
                List<ExamsDTO> exDTO = _mapper.Map<List<ExamsDTO>>(exams);
                return exDTO;

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in GetExamsBl: {ex.Message}");
                return null;
            }
        }

        public async Task<ExamsDTO> GetExamsById(int Idexam)
        {
            try
            {
                Exam allexams = await _ExamsDL.GetExamsById(Idexam);
                ExamsDTO exDTO = _mapper.Map<ExamsDTO>(allexams);
                return exDTO;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in GetAllPersonExamsBL: {ex.Message}");
                return null;
            }
        }




    }

}

