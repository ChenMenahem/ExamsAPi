using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamBL
{
    class ReliefUserRepository : IReliefUserRepository
    {
        IRelief_UsersService _ReliefDL;

        public Relief_UsersRepository(IRelief_UsersService reliefDL)
        {
            _ReliefDL = reliefDL;
        }


        public Relief_UsersRepository()
        {
            _ReliefDL = new Relief_UsersService();
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

    

