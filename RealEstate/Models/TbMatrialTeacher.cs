using System;
using System.Collections.Generic;

#nullable disable

namespace RealEstate.Models
{
    public partial class TbMatrialTeacher
    {
        public int MatrialId { get; set; }
        public int TeacherId { get; set; }

        public virtual TbMatrial Matrial { get; set; }
        public virtual TbTeacher Teacher { get; set; }
    }
}
