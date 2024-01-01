

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exam_DTO.DTO;
using ExamDL.Models;
using AutoMapper;
using ExamDL;


namespace ExamBL
{
    public class ReliefUserRepository : IReliefUserRepository
    {
        IReliefUserService _ReliefUsersDL;
        IMapper _mapper;

        public ReliefUserRepository(ReliefUserService reliefDL, IMapper mapper)
        {
            _ReliefUsersDL = reliefDL;
            _mapper = mapper;
        }



        public async Task<ReliefUserDTO> GetPersonReliefBL(int userId)
        {
            try
            {
                ReliefUser relief = await _ReliefUsersDL.GetPersonRelief(userId);
                ReliefUserDTO rlDTO = _mapper.Map<ReliefUserDTO>(relief);
                return rlDTO;

            }
            catch (Exception ex)
            {

                Console.WriteLine($"Error in GetAllPersonReliefBL: {ex.Message}");
                return null;
            }
        }

        public async Task<List<RelifTypeDTO>> GetAllReliefTypeBL()
        {
            try
            {
                List<ReliefType> reliefType = await _ReliefUsersDL.GetAllReliefType();
                List<RelifTypeDTO> rlDTO = _mapper.Map<List<RelifTypeDTO>>(reliefType);
                return rlDTO;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in GetAllReliefTypeBL: {ex.Message}");
                return new List<RelifTypeDTO>();
            }
        }
        public async Task<List<ReliefReasonDTO>> GetallReliefReasonBL()
        {
            try
            {
                List<ReliefReason> reliefReason = await _ReliefUsersDL.GetallReliefReason();
                List<ReliefReasonDTO> rlDTO = _mapper.Map<List<ReliefReasonDTO>>(reliefReason);
                return rlDTO;
            }
            catch (Exception ex)
            {

                Console.WriteLine($"Error in GetallReliefReasonBL: {ex.Message}");
                return new List<ReliefReasonDTO>();
            }
        }
        public async Task<bool> AddRealif_UserBL(ReliefUserDTO Reliefuser)
        {
            try
            {
                ReliefUser ru = _mapper.Map<ReliefUser>(Reliefuser);
                bool isAdd = await _ReliefUsersDL.AddRealif(ru);
                return isAdd;
            }
            catch (Exception ex)
            {

                Console.WriteLine($"Error in AddRealif_UserBL: {ex.Message}");
                return false;
            }
        }

    }
}


    

