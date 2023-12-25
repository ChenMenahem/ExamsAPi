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


        public async Task<List<ReliefUser>> GetAllPersonRelief(int userId)//מחזירה את כל ההקלות של בן אדם מסויים
        {
            List<ReliefUser> result = await _Relief.ReliefUsers
                 .Where(u => u.IdUser == userId)
                  .ToListAsync();
            return result;
        }
        public async Task<List<ReliefType>> GetAllReliefType()
        {
            List<ReliefType> result = await _Relief.ReliefTypes
                 .ToListAsync();
            return result;
        }

        public async Task<List<ReliefReason>> GetallReliefReason()
        {
            List<ReliefReason> result = await _Relief.ReliefReasons
                 .ToListAsync();
            return result;
        }

        public async Task<bool> AddRealif(ReliefUser Reliefuser)
        {
            {
                var Relief = await _Relief.ReliefUsers.AddAsync(Reliefuser);
                _Relief.SaveChanges();
                return true;
            }

        }
    }
}
