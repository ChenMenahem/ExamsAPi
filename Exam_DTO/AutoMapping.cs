using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Exam_DTO.DTO;
using ExamDL.Models;


namespace Exam_DTO
{
    public class AutoMapping : Profile
    {
        public AutoMapping()
        {
            //CreateMap<ExamsRepository, ExamsDto>();
            CreateMap<PersonalDetaileDTO, PersonalDetaile>();
            CreateMap<PersonalDetaile, PersonalDetaileDTO>();
            CreateMap<ExamsDTO, Exam>();
            CreateMap<Exam, ExamsDTO>();
            CreateMap<ExamsUserDTO, ExamsUser>();
            CreateMap<ExamsUser, ExamsUserDTO>();
            CreateMap<ReliefUserDTO, ReliefReason>();
            CreateMap<ReliefReason, ReliefUserDTO>();






        }



    }
}
