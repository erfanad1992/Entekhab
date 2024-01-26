using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entekhab.Domain
{
    public class Resid
    {
        public int ResidId { get; set; }
        public int TrackingCode { get; set; }
        public ICollection<Mojavez> Mojavezes { get; set; }
    }
}
