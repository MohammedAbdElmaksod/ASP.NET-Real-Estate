using System;
using System.Collections.Generic;

#nullable disable

namespace RealEstate.Models
{
    public partial class TbAssignment
    {
        public int StudentId { get; set; }
        public int MatrialId { get; set; }
        public bool Done { get; set; }

        public virtual TbMatrial Matrial { get; set; }
        public virtual TbStudent Student { get; set; }
    }
}
