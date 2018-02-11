using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using WebApplication1.Interfaces;

namespace WebApplication1.Models
{
    public class Artist 
    {      
        public int ArtistId { get; set; }
        public string Name { get; set; }
        public int Email { get; set; }
        public String Descriptoion { get; set; }
        public Image Avatar  { get; set; }
        public List<ArtWork> ArtWorks { get; set; }                
    }
}