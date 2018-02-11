using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Interfaces
{
    public interface IArtist
    {
        int ID { get; set; }
        string Name { get; set; }
        List<ArtWork> ArtWorks { get; set; }
    }
}
