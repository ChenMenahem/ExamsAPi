using ExamDL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_DTO.DTO
{
   public class ReliefUserDTO
    {
        public int IdReliefUser { get; set; }

        public int IdUser { get; set; }

        public int IdReliefTypes { get; set; }

        public int IdReliefReasons { get; set; }

        public string ReliefExplanation { get; set; } = null!;

        public bool ReliefStatus { get; set; }

        public string ReliefFile { get; set; } = null!;

        public virtual ReliefReason IdReliefReasonsNavigation { get; set; } = null!;

        public virtual ReliefType IdReliefTypesNavigation { get; set; } = null!;

        public virtual PersonalDetaile IdUserNavigation { get; set; } = null!;
    }
}
