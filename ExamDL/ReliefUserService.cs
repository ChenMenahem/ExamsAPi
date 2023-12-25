using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamDL.Models;
using Microsoft.EntityFrameworkCore;

namespace ExamDL
{
    public class ReliefUserService : IReliefUserService
    {
        ExamsContext _Relief = new ExamsContext();
        //פוקצית GET
        public async Task<List<ReliefUser>> GetAllPersonRelief(int userId)
        {
            try
            {
                List<ReliefUser> result = await _Relief.ReliefUsers
                    .Where(u => u.IdUser == userId)
                    .ToListAsync();
                return result;
            }
            catch (Exception ex)
            {
                
                Console.WriteLine($"An error occurred while fetching relief data: {ex.Message}");
                
                throw;
            }
        }
        public async Task<List<ReliefType>> GetAllReliefType()
        {
            try
            {
                List<ReliefType> result = await _Relief.ReliefTypes
                    .ToListAsync();
                return result;
            }
            catch (Exception ex)
            {
            
                Console.WriteLine($"An error occurred while fetching relief types: {ex.Message}");
              
                throw;
            }
        }

        public async Task<List<ReliefReason>> GetallReliefReason()
        {
            try
            {
                List<ReliefReason> result = await _Relief.ReliefReasons
                    .ToListAsync();
                return result;
            }
            catch (Exception ex)
            {
            
                Console.WriteLine($"An error occurred while fetching relief reasons: {ex.Message}");
               
                throw;
            }
        }

        public async Task<bool> AddRealif(ReliefUser Reliefuser)
        {
            try
            {
                var Relief = await _Relief.ReliefUsers.AddAsync(Reliefuser);
                await _Relief.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                
                Console.WriteLine($"An error occurred while adding relief: {ex.Message}");
              
                throw;
            }
        }

     
    }
}
