namespace ExamBL
{
    interface IReliefUserRepository
    {
        Task<global::System.Boolean> AddRealif_UserBL(ReliefUser Reliefuser);
        Task<List<ReliefUser>> GetAllPersonReliefBL(global::System.Int32 userId);
        Task<List<ReliefReason>> GetallReliefReasonBL();
        Task<List<ReliefType>> GetAllReliefTypeBL();
    }
}