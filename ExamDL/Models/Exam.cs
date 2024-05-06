using System;
using System.Collections.Generic;

namespace ExamDL.Models;

public partial class Exam
{
    public int IdExam { get; set; }

    public DateOnly? Date { get; set; }

    public string Subjects { get; set; } = null!;

    public DateOnly StartDate { get; set; }

    public DateOnly EndDate { get; set; }

    public string Time { get; set; } = null!;

    public double Cost { get; set; }

    public virtual ICollection<DueDate> DueDates { get; set; } = new List<DueDate>();

    public virtual ICollection<ExamsUser> ExamsUsers { get; set; } = new List<ExamsUser>();
}
