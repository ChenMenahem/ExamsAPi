using ExamDL.Models;

namespace ExamDL
{
    public interface IReliefUserService
    {
        Task<bool> AddRealif(ReliefUser Reliefuser);
        Task<List<ReliefReason>> GetallReliefReason();
        Task<List<ReliefType>> GetAllReliefType();
        Task<ReliefUser> GetPersonRelief(int userId);
    }
}