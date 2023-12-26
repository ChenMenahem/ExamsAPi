using ExamDL.Models;

namespace ExamBL
{
    public interface IReliefUserRepository
    {
        Task<bool> AddRealif_UserBL(ReliefUser Reliefuser);
        Task<List<ReliefUser>> GetAllPersonReliefBL(int userId);
        Task<List<ReliefReason>> GetallReliefReasonBL();
        Task<List<ReliefType>> GetAllReliefTypeBL();
    }
}