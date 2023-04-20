using System;
using System.Collections.Generic;

#nullable disable

namespace RealEstate.Models
{
    public partial class TbCode
    {
        public int CodeId { get; set; }
        public string Code { get; set; }
        public int StudentId { get; set; }

        public virtual TbStudent Student { get; set; }
    }
}
