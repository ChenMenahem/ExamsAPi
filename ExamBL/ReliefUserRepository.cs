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
            List<ReliefUser> relief = await _ReliefDL.GetAllPersonRelief(userId);
            return relief;
        }
        public async Task<List<ReliefType>> GetAllReliefTypeBL()
        {
            List<ReliefType> reliefType = await _ReliefDL.GetAllReliefType();
            return reliefType;
        }
        public async Task<List<ReliefReason>> GetallReliefReasonBL()
        {
            List<ReliefReason> reliefReason = await _ReliefDL.GetallReliefReason();
            return reliefReason;
        }
        public async Task<bool> AddRealif_UserBL(ReliefUser Reliefuser)
        {
            bool isAdd = await _ReliefDL.AddRealif(Reliefuser);
            return isAdd;
        }
    }
}

    

