using Exam_DTO.DTO;

namespace ExamBL
{
    public interface IReliefUserRepository
    {
        Task<bool> AddRealif_UserBL(ReliefUserDTO Reliefuser);
        Task<ReliefUserDTO> GetPersonReliefBL(int userId);
        Task<List<ReliefReasonDTO>> GetallReliefReasonBL();
        Task<List<RelifTypeDTO>> GetAllReliefTypeBL();
    }
}