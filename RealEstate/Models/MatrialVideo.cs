using System;
using System.Collections.Generic;

#nullable disable

namespace RealEstate.Models
{
    public partial class MatrialVideo
    {
        public int MatrialId { get; set; }
        public int VideoId { get; set; }

        public virtual TbMatrial Matrial { get; set; }
        public virtual TbVideo Video { get; set; }
    }
}
