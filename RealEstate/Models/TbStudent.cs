using System;
using System.Collections.Generic;

#nullable disable

namespace RealEstate.Models
{
    public partial class TbStudent
    {
        public TbStudent()
        {
            StudentMatrials = new HashSet<StudentMatrial>();
            TbAssignments = new HashSet<TbAssignment>();
            TbCodes = new HashSet<TbCode>();
        }

        public int StudentId { get; set; }
        public string StudentFullName { get; set; }
        public int YearLevel { get; set; }

        public virtual ICollection<StudentMatrial> StudentMatrials { get; set; }
        public virtual ICollection<TbAssignment> TbAssignments { get; set; }
        public virtual ICollection<TbCode> TbCodes { get; set; }
    }
}
