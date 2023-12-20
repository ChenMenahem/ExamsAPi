using AutoMapper;
using Exam_DTO.DTO;
using ExamDL;
using ExamDL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ExamBL
{
    public class PersonalDetailesRepository : IPersonalDetailesRepository
    {
        IPersonalDetailesService _PersonalDetailsDL;
        IMapper _mapper;

        public PersonalDetailesRepository(IPersonalDetailesService PersonalDetailsDL, IMapper mapper)
        {
            _PersonalDetailsDL = PersonalDetailsDL;
            _mapper = mapper;

        }
        public PersonalDetailesRepository()
        {
            _PersonalDetailsDL = new PersonalDetailesService();
        }

        public async Task<List<PersonalDetaile>> GetAllPersonDetailsByIdBl(int iduser)
        {
            List<PersonalDetaile> currentUser = await _PersonalDetailsDL.GetAllPersonDetailsById(iduser);
            return currentUser;
        }
        public async Task<List<PersonalDetaileDTO>> GetAllPersonalDetailsBL()
        {
            List<PersonalDetaile> personalsDetailes = await _PersonalDetailsDL.GetAllPersonalDetails();
            List<PersonalDetaileDTO> pdDTO = _mapper.Map<List<PersonalDetaileDTO>>(personalsDetailes);
            return pdDTO;
        }


        public async Task<bool> AddPersonalDelailesBL(PersonalDetaileDTO Id_User)
        {
            PersonalDetaile pd = _mapper.Map<PersonalDetaile>(Id_User);
            bool isAddPersonalDetails = await _PersonalDetailsDL.Add(pd);
            return isAddPersonalDetails;
        }

        public async Task<bool> UpdatePersonalDetailesBL(PersonalDetaile Id_User)
        {
            bool isUpdatePersonalDetailes = await _PersonalDetailsDL.Update(Id_User);
            return isUpdatePersonalDetailes;
        }
    }

}

