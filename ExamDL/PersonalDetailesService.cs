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


        public async Task<PersonalDetaile> GetAllPersonDetailsById(int iduser)
        {
            try
            {
                PersonalDetaile result = await _personalDetails.PersonalDetailes
                     .Where(u => u.IdUser == iduser)
                     .FirstOrDefaultAsync();
                return result;
            }
            catch (Exception ex)
            {

                Console.WriteLine($"An error occurred while fetching personal details by ID: {ex.Message}");

                throw;
            }
        }
        //public async Task<PersonalDetaile> GetByPermision(int permission)
        //{
        //    try
        //    {
        //        PersonalDetaile result = await _personalDetails.PersonalDetailes
        //             .Where(u => u.IdUser == iduser)
        //             .FirstOrDefaultAsync();
        //        return result;
        //    }
        //    catch (Exception ex)
        //    {

        //        Console.WriteLine($"An error occurred while fetching personal details by ID: {ex.Message}");

        //        throw;
        //    }
        //}


        public async Task<List<PersonalDetaile>> GetAllPersonalDetails()
        {
            try
            {
                List<PersonalDetaile> result = await _personalDetails.PersonalDetailes
                     .ToListAsync();
                return result;
            }
            catch (Exception ex)
            {

                Console.WriteLine($"An error occurred while fetching personal details: {ex.Message}");

                throw;
            }
        }

        public async Task<bool> Add(PersonalDetaile personalDetaile)
        {
            try
            {
                await _personalDetails.PersonalDetailes.AddAsync(personalDetaile);
                _personalDetails.SaveChanges();
                //שליפה של האוביקט האחרון שהוכנס
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
            try
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
            catch (Exception ex)
            {

                Console.WriteLine($"An error occurred during update: {ex.Message}");

                throw;
            }
        }



    }
}


