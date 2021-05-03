using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castle.Windsor;
using Castle.MicroKernel.Registration;

namespace Kpo4317_DJR.Lib
{
    public static class CastleWindsorContainer
    {
        public static WindsorContainer container { get; private set; }

        static CastleWindsorContainer()
        {
            container = new WindsorContainer();
            container.Register(Component
                .For<ISemiconductorListLoader>()
                .ImplementedBy<SemiconductorListSplitFileLoader>()
                .Named("SplitFile"));
            container.Register(Component
                .For<ISemiconductorListLoader>()
                .ImplementedBy<SemiconductorListTestLoader>()
                .Named("Test"));
        }
    }
}