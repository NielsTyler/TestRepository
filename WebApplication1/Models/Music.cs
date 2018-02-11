using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Music
    {
        public virtual int MusicId { get; set; }
        
        public virtual String MusicName { get; set; }

        public virtual String MusicFileName { get; set; }

        public virtual Image AlbumPic { get; set; }  
    }
}