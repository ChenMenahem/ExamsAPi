using AutoMapper;
using Exam_DTO.DTO;
using ExamDL;
using ExamDL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ExamBL
{
    public class PersonalDetailesRepository : IPersonalDetailesRepository
    {
        IPersonalDetailesService _PersonalDetailsDL;
        IMapper _mapper;

        public PersonalDetailesRepository(IPersonalDetailesService PersonalDetailsDL, IMapper mapper)
        {
            _PersonalDetailsDL = PersonalDetailsDL;
            _mapper = mapper;

        }
        public async Task<List<PersonalDetaile>> GetAllPersonDetailsByIdBl(int iduser)
        {
            try
            {
                List<PersonalDetaile> currentUser = await _PersonalDetailsDL.GetAllPersonDetailsById(iduser);
                return currentUser;
            }
            catch (Exception ex)
            {
                
                Console.WriteLine($"Error in GetAllPersonDetailsByIdBl: {ex.Message}");
                return null; 
            }
        }
        public async Task<List<PersonalDetaileDTO>> GetAllPersonalDetailsBL()
        {
            try
            {
                List<PersonalDetaile> personalsDetailes = await _PersonalDetailsDL.GetAllPersonalDetails();
                List<PersonalDetaileDTO> pdDTO = _mapper.Map<List<PersonalDetaileDTO>>(personalsDetailes);
                return pdDTO;
            }
            catch (Exception ex)
            {
        
                Console.WriteLine($"Error in GetAllPersonalDetailsBL: {ex.Message}");
                return null; 
            }
        }

        public async Task<bool> AddPersonalDelailesBL(PersonalDetaileDTO Id_User)
        {
            try
            {
                PersonalDetaile pd = _mapper.Map<PersonalDetaile>(Id_User);
                bool isAddPersonalDetails = await _PersonalDetailsDL.Add(pd);
                return isAddPersonalDetails;
            }
            catch (Exception ex)
            {
            
                Console.WriteLine($"Error in AddPersonalDelailesBL: {ex.Message}");
                return false; 
            }
        }

        public async Task<bool> UpdatePersonalDetailesBL(PersonalDetaile Id_User)
        {
            try
            {
                bool isUpdatePersonalDetailes = await _PersonalDetailsDL.Update(Id_User);
                return isUpdatePersonalDetailes;
            }
            catch (Exception ex)
            {
         
                Console.WriteLine($"Error in UpdatePersonalDetailesBL: {ex.Message}");
                return false; 
            }
        }
    }

}

