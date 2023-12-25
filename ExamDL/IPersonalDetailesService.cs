using ExamDL.Models;

namespace ExamDL
{
    public interface IPersonalDetailesService
    {
        Task<bool> Add(PersonalDetaile personalDetaile);
        Task<List<PersonalDetaile>> GetAllPersonalDetails();
        Task<PersonalDetaile> GetAllPersonDetailsById(int iduser);
        Task<bool> Update(PersonalDetaile personalDetaile);
    }
}