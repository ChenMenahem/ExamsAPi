using ExamDL.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ExamDL
{
    public interface IPersonalDetailesService
    {
        Task<bool> Add(PersonalDetaile personalDetaile);
        Task<List<PersonalDetaile>> GetAllPersonalDetails();
        Task<List<PersonalDetaile>> GetAllPersonDetailsById(int iduser);
        Task<bool> Update(PersonalDetaile personalDetaile);
    }
}