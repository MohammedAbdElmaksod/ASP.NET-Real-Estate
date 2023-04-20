using System;
using System.Collections.Generic;

#nullable disable

namespace RealEstate.Models
{
    public partial class TbMatrial
    {
        public TbMatrial()
        {
            MatrialVideos = new HashSet<MatrialVideo>();
            StudentMatrials = new HashSet<StudentMatrial>();
            TbAssignments = new HashSet<TbAssignment>();
            TbMatrialTeachers = new HashSet<TbMatrialTeacher>();
        }

        public int MatrialId { get; set; }
        public string MatrialName { get; set; }

        public virtual ICollection<MatrialVideo> MatrialVideos { get; set; }
        public virtual ICollection<StudentMatrial> StudentMatrials { get; set; }
        public virtual ICollection<TbAssignment> TbAssignments { get; set; }
        public virtual ICollection<TbMatrialTeacher> TbMatrialTeachers { get; set; }
    }
}
