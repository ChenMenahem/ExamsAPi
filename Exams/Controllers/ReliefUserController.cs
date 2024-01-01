using Exam_DTO.DTO;
using ExamBL;
using ExamDL.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Exams.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReliefUserController : ControllerBase
    {
        IReliefUserRepository _ReliefUserRepository;

        public ReliefUserController(IReliefUserRepository reliefUserRepository)
        {
            _ReliefUserRepository = reliefUserRepository;
        }
        

        // GET api/<ReliefUserController>/5
        [HttpGet]
        [Route("GetAllPersonGetPersonReliefBLReliefBL")]

        public Task<ReliefUserDTO> GetPersonReliefBL(int iduser)
        {
            return _ReliefUserRepository.GetPersonReliefBL(iduser);

        }
        [HttpGet]
        [Route("GetAllReliefTypeBL")]
        public async Task<List<RelifTypeDTO>> GetAllReliefTypeBL()
        {
            return await _ReliefUserRepository.GetAllReliefTypeBL();
        }
        [HttpGet]
        [Route("GetallReliefReasonBL")]
        public async Task<List<ReliefReasonDTO>> GetallReliefReasonBL()
        {
            return await _ReliefUserRepository.GetallReliefReasonBL();
        }

        [HttpPost]
        [Route("AddRealif_UserBL")]
        public async Task<bool> AddRealif_UserBL(ReliefUserDTO Reliefuser)
        {
            bool isAddReliefUser = await _ReliefUserRepository.AddRealif_UserBL(Reliefuser);
            return isAddReliefUser;
        }
            // PUT api/<ReliefUserController>/5
            [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ReliefUserController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
