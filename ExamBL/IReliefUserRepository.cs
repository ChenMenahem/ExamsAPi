using Exam_DTO.DTO;

namespace ExamBL
{
    public interface IReliefUserRepository
    {
        Task<bool> AddRealif_UserBL(ReliefUserDTO Reliefuser);
        Task<List<ReliefReasonDTO>> GetallReliefReasonBL();
        Task<List<ReliefUserDTO>> GetAllReliefsBl();
        Task<List<ReliefTypeDTO>> GetAllReliefTypeBL();
        Task<List<ReliefUserDTO>> GetPersonReliefBL(int userId);
    }
}