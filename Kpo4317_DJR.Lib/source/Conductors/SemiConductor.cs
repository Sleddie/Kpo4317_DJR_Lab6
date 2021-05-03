using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kpo4317_DJR.Lib
{
    public class SemiConductor
    {
        public SemiConductor()
        {
            Substance_name = "";
            ForbiddenZone_width = 0;
            Electron_move = 0;
            Hole_move = 0;
        }

        public string Substance_name { get; set; }
        public float ForbiddenZone_width { get; set; }
        public int Electron_move { get; set; }
        public int Hole_move { get; set; }
    }
}
