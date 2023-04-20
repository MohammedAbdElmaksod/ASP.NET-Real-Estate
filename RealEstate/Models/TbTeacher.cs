using System;
using System.Collections.Generic;

#nullable disable

namespace RealEstate.Models
{
    public partial class TbTeacher
    {
        public TbTeacher()
        {
            TbMatrialTeachers = new HashSet<TbMatrialTeacher>();
        }

        public int TeacherId { get; set; }
        public string TeacherName { get; set; }

        public virtual ICollection<TbMatrialTeacher> TbMatrialTeachers { get; set; }
    }
}
