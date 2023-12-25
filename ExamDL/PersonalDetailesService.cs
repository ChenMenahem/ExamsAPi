using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamDL.Models;
using Microsoft.EntityFrameworkCore;

namespace ExamDL
{
    public class PersonalDetailesService : IPersonalDetailesService
    {
        ExamsContext _personalDetails = new ExamsContext();


        public async Task<List<PersonalDetaile>> GetAllPersonDetailsById(int iduser)
        {
            List<PersonalDetaile> result = await _personalDetails.PersonalDetailes
                 .Where(u => u.IdUser == iduser)
                 .ToListAsync();
            return result;
        }
        


        public async Task<List<PersonalDetaile>> GetAllPersonalDetails()
        {
            List<PersonalDetaile> result = await _personalDetails.PersonalDetailes
                     .ToListAsync();
            return result;
        }
        //
        public async Task<bool> Add(PersonalDetaile personalDetaile)
        {
            try
            {
                await _personalDetails.PersonalDetailes.AddAsync(personalDetaile);
                _personalDetails.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }

        public async Task<bool> Update(PersonalDetaile personalDetaile)

        {
            PersonalDetaile existingPerson = _personalDetails.PersonalDetailes.FirstOrDefault(x => x.IdUser == personalDetaile.IdUser);

            if (existingPerson != null)
            {
                existingPerson.City = personalDetaile.City;
                _personalDetails.Update(existingPerson);

                await _personalDetails.SaveChangesAsync();
            }

            return true;
        }

    }
}


