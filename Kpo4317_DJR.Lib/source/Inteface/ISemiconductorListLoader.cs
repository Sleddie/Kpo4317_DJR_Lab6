using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kpo4317_DJR.Lib
{
    public interface ISemiconductorListLoader
    {
        List<SemiConductor> semiconductorList { get; }
        LoadStatus status { get; }
        OnLoadFileDelegate LoadingRow { get; set; }
        void Execute();
    }
}
