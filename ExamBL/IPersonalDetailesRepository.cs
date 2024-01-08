﻿using Exam_DTO.DTO;

namespace ExamBL
{
    public interface IPersonalDetailesRepository
    {
        Task<PersonalDetaileDTO> AddPersonalDelailesBL(PersonalDetaileDTO Id_User);
        Task<List<PersonalDetaileDTO>> GetAllPersonalDetailsEmployeeBL();
        Task<List<PersonalDetaileDTO>> GetAllPersonalDetailsTestersBL();
        Task<PersonalDetaileDTO> GetPersonalLogin(string email, string userpassword);
        Task<PersonalDetaileDTO> GetPersonDetailsByIdBl(int iduser);
        Task<PersonalDetaileDTO> UpdatePersonalDetailesBL(int id, PersonalDetaileDTO user);
    }
}