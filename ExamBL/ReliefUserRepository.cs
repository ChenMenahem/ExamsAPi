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
        IReliefUserService _ReliefDL;

        public ReliefUserRepository(IReliefUserService reliefDL)
        {
            _ReliefDL = reliefDL;
        }


        public ReliefUserRepository()
        {
            _ReliefDL = new ReliefUserService();
        }

        public async Task<List<ReliefUser>> GetAllPersonReliefBL(int userId)
        {
            try
            {
                List<ReliefUser> relief = await _ReliefDL.GetAllPersonRelief(userId);
                return relief;
            }
            catch (Exception ex)
            {
               
                Console.WriteLine($"Error in GetAllPersonReliefBL: {ex.Message}");
                return new List<ReliefUser>(); 
            }
        }

        public async Task<List<ReliefType>> GetAllReliefTypeBL()
        {
            try
            {
                List<ReliefType> reliefType = await _ReliefDL.GetAllReliefType();
                return reliefType;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in GetAllReliefTypeBL: {ex.Message}");
                return new List<ReliefType>(); 
            }
        }
        public async Task<List<ReliefReason>> GetallReliefReasonBL()
        {
            try
            {
                List<ReliefReason> reliefReason = await _ReliefDL.GetallReliefReason();
                return reliefReason;
            }
            catch (Exception ex)
            {
                
                Console.WriteLine($"Error in GetallReliefReasonBL: {ex.Message}");
                return new List<ReliefReason>(); 
            }
        }
        public async Task<bool> AddRealif_UserBL(ReliefUser Reliefuser)
        {
            try
            {
                bool isAdd = await _ReliefDL.AddRealif(Reliefuser);
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

    

