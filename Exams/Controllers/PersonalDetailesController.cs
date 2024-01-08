using Exam_DTO.DTO;
using ExamBL;
using ExamDL.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exams.Contoller
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonalDetailesController : ControllerBase
    {
        IPersonalDetailesRepository _PersonalDetailsRepository;

        public PersonalDetailesController(IPersonalDetailesRepository personalDetailesRepository)
        {
            _PersonalDetailsRepository = personalDetailesRepository;
        }

        [HttpGet]
        [Route("GetPersonalDetails")]
        public async Task<List<PersonalDetaileDTO>> GetlPersonalDetailsByEmp()
        {
            return await _PersonalDetailsRepository.GetAllPersonalDetailsEmployeeBL();
        }

        [HttpGet]
        [Route("GetAllPersonDetailsById")]

        public Task<PersonalDetaileDTO> GetPersonDetailsByIdBl(int iduser)
        {
            return _PersonalDetailsRepository.GetPersonDetailsByIdBl(iduser);

        }
        [HttpGet]
        [Route("GetPersonalLogin")]

        public Task<PersonalDetaileDTO> GetPersonalLogin(string email, string userpassword)
        {
            return _PersonalDetailsRepository.GetPersonalLogin(email, userpassword);

        }

        [HttpPost]
        [Route("AddPersonalDelailes")]
        public async Task<PersonalDetaileDTO> AddPersonalDelailesBL(PersonalDetaileDTO Id_User)
        {
            PersonalDetaileDTO isAddPersonalDetails =await  _PersonalDetailsRepository.AddPersonalDelailesBL(Id_User);
            return isAddPersonalDetails;

        }


        [HttpPut]
        [Route("UpdatePersonalDetails/{id}")]
        public async Task<PersonalDetaileDTO> UpdatePersonalDetailesBL(int id, PersonalDetaileDTO User)
        {
            PersonalDetaileDTO isUpdate = await _PersonalDetailsRepository.UpdatePersonalDetailesBL(id, User);
            return isUpdate;
        }
    }
}
