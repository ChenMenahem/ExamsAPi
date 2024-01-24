using ExamDL.Models;

namespace ExamDL
{
    public interface IReliefUserService
    {
        Task<bool> AddRealif(ReliefUser Reliefuser);
        Task<List<ReliefReason>> GetallReliefReason();
        Task<List<ReliefType>> GetAllReliefType();
        Task<List<ReliefUser>> GetPersonRelief(int userId);
    }
}