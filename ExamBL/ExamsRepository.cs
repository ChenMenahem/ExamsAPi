using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamBL
{
    class ExamsRepository
    {
        public class ExamsRepository : IExamsRepository
        {
            IExsamsService _ExamsDL;
            IMapper _mapper;

            public ExamsRepository(IExsamsService examDL, IMapper mapper)
            {
                _ExamsDL = examDL;
                _mapper = mapper;
            }

            public ExamsRepository()
            {
                _ExamsDL = new ExsamsService();
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
}
