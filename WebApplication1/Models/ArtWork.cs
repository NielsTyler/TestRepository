using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using WebApplication1.Interfaces;

namespace WebApplication1.Models
{
    public class ArtWork 
    {
        public int ArtWorkId { get; set; }
        public decimal Cost { get; set; }
        public int Name { get; set; }
        public int Description { get; set; }
        public Image Picture { get; set; }
        public int MusicId { get; set; }
    }
}