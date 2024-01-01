using Exam_DTO.DTO;

namespace ExamBL
{
    public interface IPersonalDetailesRepository
    {
        Task<PersonalDetaileDTO> AddPersonalDelailesBL(PersonalDetaileDTO Id_User);
        Task<List<PersonalDetaileDTO>> GetPersonalDetailsBL();
        Task<PersonalDetaileDTO> GetPersonalLogin(string email, string userpassword);
        Task<PersonalDetaileDTO> GetPersonDetailsByIdBl(int iduser);
        Task<PersonalDetaileDTO> UpdatePersonalDetailesBL(PersonalDetaileDTO Id_User);
    }
}