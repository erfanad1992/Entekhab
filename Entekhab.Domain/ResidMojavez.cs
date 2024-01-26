using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entekhab.Domain
{
    public class ResidMojavez
    {
        public ResidMojavez(int residId, int mojavezId, Resid resid, Mojavez mojavez)
        {
            ResidId = residId;
            MojavezId = mojavezId;
            Resid = resid;
            Mojavez = mojavez;
        }

        public int ResidId { get; set; }
        public Resid Resid { get; set; }

        public int MojavezId { get; set; }
        public Mojavez Mojavez { get; set; }

    }
}
