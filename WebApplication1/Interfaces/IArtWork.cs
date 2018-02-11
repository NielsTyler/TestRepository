using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication1.Interfaces
{
    public interface IArtWork
    {
        int ID { get; set; }
        string Name { get; set; }
        Decimal Cost { get; set; }
    }
}
