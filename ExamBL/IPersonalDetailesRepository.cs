using Exam_DTO.DTO;
using ExamDL.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ExamBL
{
    public interface IPersonalDetailesRepository
    {
        Task<List<PersonalDetaileDTO>> GetAllPersonalDetailsBL();
        Task<List<PersonalDetaile>> GetAllPersonDetailsByIdBl(int iduser);
        Task<bool> AddPersonalDelailesBL(PersonalDetaileDTO Id_User);
        Task<bool> UpdatePersonalDetailesBL(PersonalDetaile Id_User);
    }
}