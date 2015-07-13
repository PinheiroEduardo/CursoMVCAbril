using CommonServiceLocator.NinjectAdapter.Unofficial;
using Microsoft.Practices.ServiceLocation;
using Ninject;

namespace CursoMVCAbril.Infra.CrossCutting.IoC
{
    public class Container
    {
        public Container()
        {
            ServiceLocator.SetLocatorProvider(() => new NinjectServiceLocator(GetMolude()) );
        }

        public StandardKernel GetMolude()
        {
            return new StandardKernel(new NinjectModulo());
        }
    }
}