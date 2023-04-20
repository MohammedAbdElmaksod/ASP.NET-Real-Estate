using System;
using System.Collections.Generic;

#nullable disable

namespace RealEstate.Models
{
    public partial class TbVideo
    {
        public TbVideo()
        {
            MatrialVideos = new HashSet<MatrialVideo>();
        }

        public int VideoId { get; set; }
        public string Url { get; set; }

        public virtual ICollection<MatrialVideo> MatrialVideos { get; set; }
    }
}
