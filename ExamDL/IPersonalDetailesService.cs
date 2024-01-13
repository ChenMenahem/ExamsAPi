using ExamDL.Models;

namespace ExamDL
{
    public interface IPersonalDetailesService
    {
        Task<PersonalDetaile> Add(PersonalDetaile personalDetaile);
        Task<List<PersonalDetaile>> GetAllPersonalDetailsEmployee();
        Task<List<PersonalDetaile>> GetAllPersonalDetailsTesters();
        Task<PersonalDetaile> GetPersonalLogin(string Email, string UserPassword);
        Task<PersonalDetaile> GetPersonDetailsById(int iduser);
        Task<PersonalDetaile> Update(PersonalDetaile personalDetaile,int id);
    }
}