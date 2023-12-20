using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_DTO.DTO
{
    class ReliefUserDTO
    {
        public int IdReliefUser { get; set; }

        public int IdUser { get; set; }

        public int IdReliefTypes { get; set; }

        public int IdReliefReasons { get; set; }

        public string ReliefExplanation { get; set; } = null!;

        public bool ReliefStatus { get; set; }

        public string ReliefFile { get; set; } = null!;
    }
}
