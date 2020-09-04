using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace College.Models
{
    public class Classroom
    {
        public string Subject { get; set; }
        public string ProfessorName { get; set; }
        public string ProfessorSurname { get; set; }
        public string ProfessorFullName { get { return ProfessorName + " " + ProfessorSurname; } }
        public string Day { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public int Capacity { get; set; }
    }
}