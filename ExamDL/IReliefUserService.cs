namespace ExamDL
{
    internal interface IReliefUserService
    {
        Task<global::System.Boolean> AddRealif(ReliefUser Reliefuser);
        Task<List<ReliefUser>> GetAllPersonRelief(global::System.Int32 userId);
        Task<List<ReliefReason>> GetallReliefReason();
        Task<List<ReliefType>> GetAllReliefType();
    }
}